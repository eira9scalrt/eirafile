using System;
class Test{
	static public void Main(){
		string s = "test";//		↓これって何？引数？Functionのf？
		Function.show(() => s );//ここの(() => s )
	}
}

class Function{
	static public void show(Func<string > f){
		Console.Write(f());
	}
}

