// パラメーター設定
// 第一引数が名前、第二引数がデフォルト値
string target = Argument("Target", "Default");

// 動作確認用のタスク
Task("Default")
.Does(() =>
{
  Information("Hello World");
});

// 変数とデータ型
Task("var")
.Does(() =>
{
	int score = 90;
  double percentage = 85.6;
  bool isPassed = true;
  string name = "John";

  Console.WriteLine("Name: " + name);
  Console.WriteLine("Score: " + score);
  Console.WriteLine("Percentage: " + percentage + "%"); 
  Console.WriteLine("Passed: " + isPassed);

  int[] scores = new int[] {90, 80, 70, 60};

  Console.WriteLine("Scores: " + String.Join(", ", scores));
});


// 演算子
Task("operator")
.Does(() =>
{
  int alpha = 5,beta = 3;
  Console.WriteLine(alpha+beta);
  Console.WriteLine(alpha-beta);
  Console.WriteLine(alpha*beta);
  Console.WriteLine(alpha/beta);
  Console.WriteLine(alpha==beta);
  if(alpha>=beta){
    Console.WriteLine("True");
  }else{
    Console.WriteLine("False");
  }
});

// if文
Task("if")
.Does(() =>
{
  int score = 85;
  if (score >= 60)
  { 
    Console.WriteLine("You passed the exam."); 
  }
});

// switch文
Task("switch")
.Does(() =>
{
int dayOfWeek = 0;
switch (dayOfWeek) { 
case 1: 
Console.WriteLine("Monday"); 
break;
case 2: 
Console.WriteLine("Tuesday"); 
break; 
case 3: 
Console.WriteLine("Wednesday"); 
break;
case 4: 
Console.WriteLine("Thursday"); 
break; 
case 5: 
Console.WriteLine("Friday"); 
break; 
case 6: 
Console.WriteLine("Saturday"); 
break; 
case 7: 
Console.WriteLine("Sunday"); 
break; 
default: 
Console.WriteLine("Invalid day of week"); 
break;
}

});

// for文
Task("for")
.Does(() =>
{
  for (int i = 0; i < 5; i++)
  { 
    Console.WriteLine(i);
  }

});

// while文
Task("while")
.Does(() =>
{
    int i = 0,ans = 0,cnt = 0;
  while (i <= 100)
  {
    ans = i/2;
    //Console.WriteLine(i);
    i++;
  if (ans==0 && cnt<10)
  { 
    Console.WriteLine(i);
    cnt++;
    //break;
  // iが10以上になったらループを抜ける 
  }else
  {
    break;
  }
  }
});


// 関数の実行確認用
Task("useSampleFunction")
.Does(() =>
{
  Information("useSampleFunction");
  SampleFunction();
  Console.WriteLine("SampleInt -> " + SampleIntFunction().ToString());
});

Task("function")
.Does(() =>
{
  Information("function");
});

void SampleFunction()
{
  Console.WriteLine("This is SampleFunction");
}

int SampleIntFunction()
{
  return 1;
}

public class Book {
  public string title;
  public string author;
  public int stok;
}

public Book(string title,string author,int stok)
{
  this.title =title; 
  this.author =author; 
  this.stok =stok; 
}

public void addstock(int add)
{
  this.stock += add;
    Console.WriteLine($"{this.title}を{add.ToString()}冊追加しました。");
}


public void checkstock()
{
  Console.WriteLine($"{this.title}の在庫は{this.stock.ToString()}冊です。");
}
Task("book")
.Does(() =>
{
  bookArray[0] = new Book("吾輩は猫である", "夏目漱石", 10);
  bookArray[1] = new Book("こころ", "夏目漱石", 10);
  bookArray[2] = new Book("坊ちゃん", "夏目漱石", 10);
  bookArray[3] = new Book("三四郎", "夏目漱石", 10);
  bookArray[4] = new Book("それから", "夏目漱石", 10);
  bookArray[5] = new Book("門", "夏目漱石", 10);
  bookArray[6] = new Book("虞美人草", "夏目漱石", 10);
  bookArray[7] = new Book("羅生門", "芥川龍之介", 10);
  bookArray[8] = new Book("鼻", "芥川龍之介", 10);
  bookArray[9] = new Book("蟹工船", "小林多喜二", 10);

  checkstock(bookAray,40);
  addstock(bookAray,"吾輩は猫である",10);
  addstock(bookAray,"坊ちゃん",10);
  Console.WriteLine("--------------------");
  CheckStock(bookArray, 40);
})

void addStock(Book[] bookArray, string bookName, int addCount)
{
  foreach (Book book in bookArray)
  {
    if (book.title == bookName)
    {
      book.addStock(addCount);
    }
  }
}

void CheckStock(Book[] bookArray, int checkCount)
{
  foreach (Book book in bookArray)
  {
    if (book.stock < checkCount)
    {
      book.checkStock();
    }
  }
}

public class Pizza{
  public string name;
  public int value;
  public int pizzastok;
  public string size;
}

public Pizza(string name,int value,int pizzastok,string size)
{
  this.name =name; 
  this.value =value; 
  this.stok =pizzastok;
  this.size =size;
}

public void add(int addp)
{
  this.stock -= addp;
}

public menu()
{
  Console.WriteLine("ピザ注文システム");
  Console.WriteLine("何をするか番号を入力してください。");
  Console.WriteLine("1. 注文受付");
  Console.WriteLine("2. 在庫確認");
  Console.WriteLine("3. 在庫追加");
  Console.WriteLine("4. 終了");

}

public order(Pizza[] pizzaarray,string pizzaName,int addpCount)
{
  While(1){
    Console.WriteLine("ピザの名前を入力してください：");
  string name = Console.ReadLine();
  Console.WriteLine("サイズを入力してください：");
  string size = Console.ReadLine();
  Console.WriteLine("枚数を入力してください：");
  int pnum = Convert.ToInt32(Console.ReadLine());
  foreach (Pizza pizza in pizzaarray){
      if(pizza.name == pizzaName){
        pizza.order(addpCount); 
      }
  }
  Console.WriteLine("注文を追加する場合は1,終了する場合は0");
  Console.WriteLine("番号を入力：");
  int num = Convert.ToInt32(Console.ReadLine());
  }
  
  
}

public checkpstock(string name,int value,int pizzastok)
{
  Console.WriteLine("マルガリータS：" + );
  Console.WriteLine("マルガリータM：" + );
  Console.WriteLine("マルガリータL：" + );
  Console.WriteLine("ペスカトーレS：" + );
  Console.WriteLine("ペスカトーレM：" + );
  
}

public addpstock(string name,int value,int pizzastok)
{
  Console.WriteLine("在庫を追加するピザを選んでください：" + );
  Console.WriteLine("1.マルガリータ");
  Console.WriteLine("2.ペスカトーレ");
  Console.WriteLine("0.メニューに戻る");
  Console.WriteLine("番号を入力：" + );
  
}

Task("book")
.Does(() =>
{
  Pizza pizzaaray = new Pizza[6];
  pizzaaray[0] = new Pizza("マルガリータ",200,3,"S");
  pizzaaray[1] = new Pizza("マルガリータ",200,3,"M");
  pizzaaray[2] = new Pizza("マルガリータ",200,3,"L");
  pizzaaray[3] = new Pizza("ペスカトーレ",200,3,"S");
  pizzaaray[4] = new Pizza("ペスカトーレ",200,3,"M");
  pizzaaray[5] = new Pizza("ペスカトーレ",200,3,"L");
  menu();
  Console.Write("番号を入力：");
  int num = Convert.ToInt32(Console.ReadLine());

  switch(num){
    case1 :
    
    break;
    case2 :
    
    break;
    case3 :
    
    break;
    case4 :
    
    break;
    default:
    
    break;
  }
)}
  
  

// 指定されたターゲットの実行。必須
RunTarget(target);