using System;
using System.Drawing;
using System.Windows.Forms;

class Program : Form{
	static readonly int FONT_SIZE = 24;
	static readonly int WIDTH     = 640;
	static readonly int HEIGHT    = 480;
	
	protected override void OnLoad( EventArgs e ){
		ClientSize = new Size( WIDTH, HEIGHT );
	}
	
	protected override void OnPaint(PaintEventArgs e){
		var     g  = e.Graphics;
		var     bm = new Bitmap(" map.png");//BitmapはSystem.Deawing
		g.DrawString
		
		var		f  = new System.Drawing.Font("Meiryo",FONT_SIZE);//フォントの作成
		e.Graphics.DrawString("こんにちは世界",f,System.Drawing.Brushes.Blue,32,64);//最後の値は座標
	}
	public static void Main(){
		Application.Run( new Program());
	}
}

