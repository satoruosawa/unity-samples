Shader "Unlit/LineAnimation" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _Speed ("Speed", Float) = 1
        _Length ("Length", Range (0, 1)) = 0.5
    }

    SubShader {
        Tags {
            // "Queue" = "AlphaTest"
            "RenderType"="Transparent"
        }
        LOD 100

        // ZWrite Off

        Blend SrcAlpha OneMinusSrcAlpha // Alpha blending
        // Blend One One // Additive
        // Blend OneMinusDstColor One // Soft Additive
        // Blend DstColor Zero // Multiplicative
        // Blend DstColor SrcColor // 2x Multiplicative

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _Color;
            float _Speed;
            float _Length;

            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target {
                float phase = (_Time.y *_Speed) % 1;
                float start = phase;
                float end = phase + _Length;

                float pos_x = i.uv.x % 1;
                fixed4 col;

                if (end <= 1.0) {
                    if (start< pos_x && pos_x < end) {
                        col = _Color;
                        } else {
                        col = fixed4(0.0, 0.0, 0.0, 0.0);
                    }
                    } else {
                    if (pos_x < (end % 1) || start < pos_x) {
                        col = _Color;
                        } else {
                        col = fixed4(0.0, 0.0, 0.0, 0.0);
                    }
                }

                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
