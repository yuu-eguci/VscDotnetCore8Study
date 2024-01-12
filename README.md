VSCode Dotnet Core 8 Study!
===

Visual Studio Code で .NET コンソール アプリケーションを作成するチュートリアルを見つけてワオってなったのでやってみようぜ!

```bash
# バージョン
dotnet --version
# --> 8.0.101

# 🙈 .gitignore 作ってくれるの嬉しすぎ
dotnet new gitignore

# 🎉 new console でプロジェクト作成
dotnet new console --framework net8.0 --use-program-main

# 実行できる!
dotnet run

# ✨ Console.ReadLine を使うと入力を受け付けることができる

# ✨ VSCode でもブレークポイントを使ってデバッグできる (integratedTerminal が必要っぽい)
# ✨ デバッグ中に変数の値を変更する方法を記載

# ✨ リリース バージョンをビルドしてテストする (でも Release 用の設定はどう書くんだ?)
dotnet run --configuration Release

# 🚀 アプリを発行する
# 既定のビルド構成は "デバッグ" であるため、このコマンドでは "リリース" ビルド構成を指定する
dotnet publish --configuration Release
```
