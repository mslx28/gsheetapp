
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Entry entry1;
	
	private global::Gtk.Button button1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label lbQueryStatus;
	
	private global::Gtk.VSeparator vseparator1;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.HSeparator hseparator1;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.Entry entry2;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.Label label7;
	
	private global::Gtk.Label label8;
	
	private global::Gtk.Label label9;
	
	private global::Gtk.Label label10;
	
	private global::Gtk.Label label11;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("GSheetApp");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.WidthRequest = 600;
		this.fixed1.HeightRequest = 280;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Your Query :");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w1.X = 30;
		w1.Y = 10;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.WidthRequest = 425;
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w2.X = 25;
		w2.Y = 35;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.WidthRequest = 100;
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("_ExecuteQuery");
		this.fixed1.Add (this.button1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button1]));
		w3.X = 470;
		w3.Y = 35;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Query Status :");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w4.X = 30;
		w4.Y = 80;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lbQueryStatus = new global::Gtk.Label ();
		this.lbQueryStatus.Name = "lbQueryStatus";
		this.lbQueryStatus.LabelProp = global::Mono.Unix.Catalog.GetString ("Unknown");
		this.fixed1.Add (this.lbQueryStatus);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lbQueryStatus]));
		w5.X = 125;
		w5.Y = 80;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.vseparator1 = new global::Gtk.VSeparator ();
		this.vseparator1.HeightRequest = 25;
		this.vseparator1.Name = "vseparator1";
		this.fixed1.Add (this.vseparator1);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.vseparator1]));
		w6.X = 300;
		w6.Y = 80;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Query Result :");
		this.fixed1.Add (this.label4);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
		w7.X = 320;
		w7.Y = 80;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Unknown");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w8.X = 415;
		w8.Y = 80;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.WidthRequest = 530;
		this.hseparator1.HeightRequest = 3;
		this.hseparator1.Name = "hseparator1";
		this.fixed1.Add (this.hseparator1);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.hseparator1]));
		w9.X = 30;
		w9.Y = 120;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Sheet Filename :");
		this.fixed1.Add (this.label6);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label6]));
		w10.X = 30;
		w10.Y = 140;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.WidthRequest = 425;
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w11.X = 25;
		w11.Y = 165;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.WidthRequest = 100;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("_Write to Sheet");
		this.fixed1.Add (this.button2);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
		w12.X = 470;
		w12.Y = 165;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Writing Status :");
		this.fixed1.Add (this.label7);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label7]));
		w13.X = 30;
		w13.Y = 210;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Unknown");
		this.fixed1.Add (this.label8);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label8]));
		w14.X = 130;
		w14.Y = 210;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Spreadsheet Fileinfo :");
		this.fixed1.Add (this.label9);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label9]));
		w15.X = 30;
		w15.Y = 240;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Unknown");
		this.fixed1.Add (this.label10);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label10]));
		w16.X = 165;
		w16.Y = 240;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("(c) 2015 BI Dept.");
		this.label11.Justify = ((global::Gtk.Justification)(1));
		this.fixed1.Add (this.label11);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label11]));
		w17.X = 470;
		w17.Y = 275;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 600;
		this.DefaultHeight = 316;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}