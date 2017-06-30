/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Basics
{
	public partial class Main : GComponent
	{
		public Controller c1;
		public GComponent container1;
		public GButton btn_Back;
		public GButton btn_Button;
		public GButton btn_Image;
		public GButton btn_Graph;
		public GButton btn_MovieClip;
		public GButton btn_Depth;
		public GButton btn_Loader;
		public GButton btn_List;
		public GButton btn_ProgressBar;
		public GButton btn_Slider;
		public GButton btn_ComboBox;
		public GButton btn_Clip_Scroll;
		public GButton btn_Controller;
		public GButton btn_Relation;
		public GButton btn_Label;
		public GButton btn_Popup;
		public GButton btn_Window;
		public GButton btn_Drag_Drop;
		public GButton btn_Component;
		public GButton btn_Grid;
		public GButton btn_Text;
		public GGroup btns;

		public const string URL = "ui://9leh0eyfrpmb1c";

		public static Main CreateInstance()
		{
			return (Main)UIPackage.CreateObject("Basics","Main");
		}

		public Main()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			c1 = this.GetController("c1");
			container1 = (GComponent)this.GetChild("container1");
			btn_Back = (GButton)this.GetChild("btn_Back");
			btn_Button = (GButton)this.GetChild("btn_Button");
			btn_Image = (GButton)this.GetChild("btn_Image");
			btn_Graph = (GButton)this.GetChild("btn_Graph");
			btn_MovieClip = (GButton)this.GetChild("btn_MovieClip");
			btn_Depth = (GButton)this.GetChild("btn_Depth");
			btn_Loader = (GButton)this.GetChild("btn_Loader");
			btn_List = (GButton)this.GetChild("btn_List");
			btn_ProgressBar = (GButton)this.GetChild("btn_ProgressBar");
			btn_Slider = (GButton)this.GetChild("btn_Slider");
			btn_ComboBox = (GButton)this.GetChild("btn_ComboBox");
			btn_Clip_Scroll = (GButton)this.GetChild("btn_Clip_Scroll");
			btn_Controller = (GButton)this.GetChild("btn_Controller");
			btn_Relation = (GButton)this.GetChild("btn_Relation");
			btn_Label = (GButton)this.GetChild("btn_Label");
			btn_Popup = (GButton)this.GetChild("btn_Popup");
			btn_Window = (GButton)this.GetChild("btn_Window");
			btn_Drag_Drop = (GButton)this.GetChild("btn_Drag_Drop");
			btn_Component = (GButton)this.GetChild("btn_Component");
			btn_Grid = (GButton)this.GetChild("btn_Grid");
			btn_Text = (GButton)this.GetChild("btn_Text");
			btns = (GGroup)this.GetChild("btns");
		}
	}
}