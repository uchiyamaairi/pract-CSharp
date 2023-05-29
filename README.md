# C#演習用プロジェクト

このプロジェクトは C#と Cake.build を利用しています。

## プロジェクトの初期セットアップ

1. プロジェクトをクローンします。

```bash
git clone https://github.com/CHARI-AKIO/pract-CSharp
```

2. プロジェクトのディレクトリに移動します。

```bash
cd pract-CSharp
```

## Cake を利用する

このプロジェクトは Cake.build を利用しています。

1. デフォルトのタスクを実行します。

```bash
.\build.ps1
```

2. 特定のタスクを実行します。

```bash
.\build.ps1 -Target <タスク名>
```

`"TaskName"`の部分には実行したいタスク名を指定します。これにより、`build.cake`の`Task("TaskName")`で定義されたタスクが実行されます。
