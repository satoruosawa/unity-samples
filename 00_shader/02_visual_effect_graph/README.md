# Environment
- Unity Version 2019.2.5f1

# Get start
- "Window - Package Manager" で Package Manager を開き、 "Advanced" から "Show preview packages" にチェックを入れて Preview Package も表示するようにした上で下記 3 つを install
  - Core RP Library
    - Version 6.9.1
  - High Definition RP
    - Version 6.9.1
  - install Visual Effect Graph
    - Version 6.9.1
- "Assets - Create - Rendering - High Definition Render Pipeline Asset" で HDRP asset を作成
- "Edit - Project Settings" で Project Settings を開く。
  - その中の "Graphics - Scriptable Render Pipeline Settings" に作成した asset を設定。
  - 合わせて "Player - Other Settings - Rendering" の Color Space を "Linear" に設定 (HDRP は Linear 必須)
- "GameObject - Rendering - Scene Settings" で Scene 上に Scene Settings を作成
- "Assets - Create - Visual Effects - Visual Effect Graph" で VFX asset を作成
- "Game Object - Visual Effects - Visual Effect" で Scene 上に Visual Effect を作成し、作成した VFX asset を Asset Template に登録
