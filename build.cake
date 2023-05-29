// パラメーター設定
// 第一引数が名前、第二引数がデフォルト値
string target = Argument("Target", "Default");
// タスクの定義
Task("Default")
.Does(() =>
{
  Information("Hello World");
});

// 指定されたターゲットの実行。必須
RunTarget(target);