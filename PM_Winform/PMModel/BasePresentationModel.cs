using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PM_Winform
{
    public abstract class BasePresentationModel
    {
        public event EventHandler<EventArgs> Changed;

        /// <summary>
        ///
        /// </summary>
        public virtual void Initialize()
        {
            OnChanged(EventArgs.Empty);
        }

        protected void OnChanged(EventArgs args) 
        {
            if (Changed != null)
                Changed(this, args);
        }
    }
}