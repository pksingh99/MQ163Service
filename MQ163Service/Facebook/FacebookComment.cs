﻿using System;

namespace MQ163.External.Facebook
{
    public class FacebookComment
    {
        /// <summary>
        /// Facebook Profile of the User who commented on the post
        /// </summary>
        public IFacebookProfile User
        {
            /* this is a temporary work around for not being able to parse child JSON objects in Objective C. Need to change later. */
            get
            {
                return null;
            }
            set
            {
                
                this.FirstName = value.FirstName;
                this.LastName = value.LastName;
                this.UserName = value.UserName;
            }
        }

       

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        /* end of work around */

        /// <summary>
        /// Commented Text
        /// </summary>
        public string CommentText
        {
            get;
            set;
        }

        /// <summary>
        /// Is User liked the post
        /// </summary>
        public Nullable<bool> IsSupportive
        {
            get;
            set;
        }

        /// <summary>
        /// Facebook Comment ID
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// Comment Creation Date and Time
        /// </summary>
        public DateTime CreatedDateAndTime
        {
            get;
            set;
        }
    }
}
