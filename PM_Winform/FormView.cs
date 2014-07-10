using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace PM_Winform
{
    /// <summary>
    /// Base view class
    /// </summary>
    /// <typeparam name="PM"></typeparam>
    public abstract class FormView<PM> : Form where PM: BasePresentationModel, new()
    {
        public FormView()
        {
            this.Model = new PM();
            this.Model.Initialize(); 
        }

        private PM _model;
        public PM Model
        {
            get { return _model; }
            set
            {
                _model = value;
                _model.Changed += new EventHandler<EventArgs>(OnModelChanged);
            }
        }

        protected virtual void OnModelChanged(object sender, EventArgs e)
        {
          
           
        }
    }
}