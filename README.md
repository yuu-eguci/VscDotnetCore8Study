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
# --use-program-main: エントリポイントを Program.Main にするってこと = Program.cs がクラスベースになる
dotnet new console --framework net8.0 --use-program-main

# 実行できる!
dotnet run

# ✨ Console.ReadLine を使うと入力を受け付けることができる

# ✨ VSCode でもブレークポイントを使ってデバッグできる (integratedTerminal が必要っぽい)
# ✨ デバッグ中に変数の値を変更する方法を記載

# ✨ リリース バージョンをビルドしてテストする (TODO: でも Release 用の設定はどう書くんだ?)
dotnet run --configuration Release

# 🚀 アプリを発行する
# 既定のビルド構成は "デバッグ" であるため、このコマンドでは "リリース" ビルド構成を指定する
dotnet publish --configuration Release

# 📝 アプリを実行する
# 実行方法は、以下の2通り
# 1. 実行可能ファイルを使用する、
(cd bin/Release/net8.0/publish; ./VscDotnetCore8Study)
# 2. コマンド プロンプトから dotnet VscDotnetCore8Study.dll コマンドを実行
(cd bin/Release/net8.0/publish; dotnet VscDotnetCore8Study.dll)

# publish フォルダに作られるもののうち……
# これがないと動かないもの
# - App 名のファイル: 実行可能ファイルね。
# - dll ファイル: これはアセンブリだ。
# - runtimeconfig.json ファイル: 使用する .NET Core ランタイムのバージョンとか。
# これがなくても動くもの
# - deps.json ファイル: アプリケーションの依存関係の詳細。
# - pdb ファイル: デバッグ時に役立つが、アプリケーションの実行には不要。
```
