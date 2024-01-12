VSCode Dotnet Core 8 Study!
===

Visual Studio Code で .NET コンソール アプリケーションを作成するチュートリアルを見つけてワオってなったのでやってみようぜ!

https://learn.microsoft.com/ja-jp/dotnet/core/tutorials/with-visual-studio-code

## Summary

このチュートリアルは、単体のコンソールアプリを作るものだった。

- Util クラスなどは範疇外ってこと
- コンソールアプリ以外のプロジェクトがないから、ソリューションファイルも不要ってこと

dotnet コマンドを使ってプロジェクトを作って、 dotnet コマンドを使って実行、ビルド、発行する。
あと VSCode でブレークポイントを使ってデバッグする方法も書いてある。

Exe を Windows で動かすためにはこれ↓が必要。

https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-8.0.1-windows-x64-installer

## Notes in Progress

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
