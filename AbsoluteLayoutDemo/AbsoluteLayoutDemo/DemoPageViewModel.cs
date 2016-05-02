using System;
using Xamarin.Forms;
using System.ComponentModel;
namespace AbsoluteLayoutDemo
{
	public class DemoPageViewModel :INotifyPropertyChanged
	{
		private double x;
		private double y;
		private double width;
		private double height;
		private bool flagsAll;
		private bool flagsNone;
		private bool flagsXProp;
		private bool flagsYProp;
		private bool flagsWidthProp;
		private bool flagsHeightProp;
		private bool flagsPositionProp;
		private bool flagsSizeProp;
		private double xMin;
		private double xMax;
		private double yMin;
		private double yMax;
		private double widthMin;
		private double widthMax;
		private double heightMin;
		private double heightMax;

		public DemoPageViewModel()
		{
			this.x = 0.5;
			this.y = 0.5;
			this.width = 0.5;
			this.height = 0.5;
			this.flagsAll = true;
			this.SetMinMaxs();
		}

		public void SetMinMaxs()
		{
			if (this.flagsAll || this.flagsPositionProp || this.flagsXProp)
			{
				this.XMin = -1;
				this.XMax = 2;
			}
			else
			{
				this.XMin = -100;
				this.XMax = 1000;
			}

			if (this.flagsAll || this.flagsPositionProp || this.flagsYProp)
			{
				this.YMin = -1;
				this.YMax = 2;
			}
			else
			{
				this.YMin = -100;
				this.YMax = 1000;
			}

			if (this.flagsAll || this.flagsSizeProp || this.flagsWidthProp)
			{
				this.WidthMin = 0;
				this.WidthMax = 2;
			}
			else
			{
				this.WidthMin = 0;
				this.WidthMax = 1000;
			}

			if (this.flagsAll || this.flagsSizeProp || this.flagsHeightProp)
			{
				this.HeightMin = 0;
				this.HeightMax = 2;
			}
			else
			{
				this.HeightMin = 0;
				this.HeightMax = 1000;
			}
		}

		public double X
		{
			get { return this.x; }

			set 
			{
				if (!this.x.Equals(value))
				{
					this.x = Math.Round(value, 2);
					this.RaisePropertyChanged("X");
				}
			}
		}

		public double Y
		{
			get { return this.y; }

			set
			{
				if (!this.y.Equals(value))
				{
					this.y = Math.Round(value, 2);
					this.RaisePropertyChanged("Y");
				}
			}
		}

		public double Width
		{
			get { return this.width; }

			set
			{
				if (!this.width.Equals(value))
				{
					this.width = Math.Round(value, 2);
					this.RaisePropertyChanged("Width");
				}
			}
		}

		public double Height
		{
			get { return this.height; }

			set
			{
				if (!this.height.Equals(value))
				{
					this.height = Math.Round(value, 2);
					this.RaisePropertyChanged("Height");
				}
			}
		}

		public bool FlagsAll
		{
			get
			{
				return flagsAll;
			}

			set
			{
				if (!this.flagsAll == value)
				{
					this.flagsAll = value;
					this.RaisePropertyChanged("FlagsAll");
				}
			}
		}

		public bool FlagsNone
		{
			get
			{
				return flagsNone;
			}

			set
			{
				if (!this.flagsNone == value)
				{
					this.flagsNone = value;
					this.RaisePropertyChanged("FlagsNone");
				}
			}
		}

		public bool FlagsXProp
		{
			get
			{
				return flagsXProp;
			}

			set
			{
				if (!this.flagsXProp == value)
				{
					this.flagsXProp = value;
					this.RaisePropertyChanged("FlagsXProp");
				}
			}
		}

		public bool FlagsYProp
		{
			get
			{
				return flagsYProp;
			}

			set
			{
				if (!this.flagsYProp == value)
				{
					this.flagsYProp = value;
					this.RaisePropertyChanged("FlagsYProp");
				}
			}
		}

		public bool FlagsWidthProp
		{
			get
			{
				return flagsWidthProp;
			}

			set
			{
				if (!this.flagsWidthProp == value)
				{
					this.flagsWidthProp= value;
					this.RaisePropertyChanged("FlagsWidthProp");
				}
			}
		}

		public bool FlagsHeightProp
		{
			get
			{
				return flagsHeightProp;
			}

			set
			{
				if (!this.flagsHeightProp == value)
				{
					this.flagsHeightProp = value;
					this.RaisePropertyChanged("FlagsHeightProp");
				}
			}
		}

		public bool FlagsPositionProp
		{
			get
			{
				return flagsPositionProp;
			}

			set
			{
				if (!this.flagsPositionProp == value)
				{
					this.flagsPositionProp = value;
					this.RaisePropertyChanged("FlagsPositionProp");
				}
			}
		}

		public bool FlagsSizeProp
		{
			get
			{
				return flagsSizeProp;
			}

			set
			{
				if (!this.flagsSizeProp == value)
				{
					this.flagsSizeProp = value;
					this.RaisePropertyChanged("FlagsSizeProp");
				}
			}
		}

		public double XMin
		{
			get
			{
				return xMin;
			}

			set
			{
				if (!this.xMin.Equals(value))
				{
					this.xMin = value;
					this.RaisePropertyChanged("XMin");
				}
			}
		}

		public double XMax
		{
			get
			{
				return xMax;
			}

			set
			{
				if (!this.xMax.Equals(value))
				{
					this.xMax = value;
					this.RaisePropertyChanged("XMax");
				}
			}
		}

		public double YMin
		{
			get
			{
				return yMin;
			}

			set
			{
				if (!this.yMin.Equals(value))
				{
					this.yMin = value;
					this.RaisePropertyChanged("YMin");
				}
			}
		}

		public double YMax
		{
			get
			{
				return yMax;
			}

			set
			{
				if (!this.yMax.Equals(value))
				{
					this.yMax = value;
					this.RaisePropertyChanged("YMax");
				}
			}
		}

		public double WidthMin
		{
			get
			{
				return widthMin;
			}

			set
			{
				if (!this.widthMin.Equals(value))
				{
					this.widthMin = value;
					this.RaisePropertyChanged("WidthMin");
				}
			}
		}

		public double WidthMax
		{
			get
			{
				return widthMax;
			}

			set
			{
				if (!this.widthMax.Equals(value))
				{
					this.widthMax = value;
					this.RaisePropertyChanged("WidthMax");
				}
			}
		}

		public double HeightMin
		{
			get
			{
				return heightMin;
			}

			set
			{
				if (!this.heightMin.Equals(value))
				{
					this.heightMin = value;
					this.RaisePropertyChanged("HeightMin");
				}
			}
		}

		public double HeightMax
		{
			get
			{
				return heightMax;
			}

			set
			{
				if (!this.heightMax.Equals(value))
				{
					this.heightMax = value;
					this.RaisePropertyChanged("HeightMax");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

