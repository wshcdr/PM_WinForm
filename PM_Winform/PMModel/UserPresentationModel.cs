using System;
using System.Collections.Generic;
using System.Linq;

using PM_Winform;

namespace PM_Winform
{
    public class UserPresentationModel : BasePresentationModel
    {
        public IEnumerable<User> UserInfo { get; set; }


        protected List<User> mem_list;

        public UserPresentationModel()
        {

            mem_list = new List<User>();

            mem_list.Add(new User { Name = "test1", Score = "11" });
            

        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            UserInfo = mem_list;
            base.Initialize();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void OnSaveUser(string name, string score)
        {
           
            List<User> list = new List<User>(UserInfo);
            list.Add(new User { Name = name, Score = score });


            mem_list = list;
            UserInfo = mem_list;
            OnChanged(EventArgs.Empty); 
        }
    }
}