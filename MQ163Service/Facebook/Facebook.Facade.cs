﻿
using System;
using System.Collections.Generic;
using MQ163.Application.External;
using MQ163.External.Facebook;
namespace MQ163.Application.Facade
{
    public class FacebookFacade : IDisposable
    {
        private IFacebookPage page = null;

        //TOBE: Used by the tests only
        public FacebookFacade(IFacebookPage page)
        {
            this.page = page;
        }

        public FacebookFacade()
        {
            page = new FacebookPage();
        }

        /// <summary>
        /// Activates the FaceBook Page with new Access Token
        /// </summary>
        /// <param name="accessToken">New Access Token</param>
        //private FacebookFacade Activate(string accessToken)
        //{
        //    page = new FacebookPage(accessToken);
        //    return this;
        //}

        /// <summary>
        /// Gets information of all the posts of type "picture" of the Page MQ163
        /// </summary>
        /// <returns>IEnumerable of all the Posts</returns>
        public IEnumerable<IFacebookPost> GetAllPosts()
        {
            try
            {
                if (null == page)
                {
                    page = new FacebookPage();
                }
                return page.GetAllPosts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adds the post to the Page MQ163
        /// </summary>
        /// <param name="message">Message of the POst</param>
        /// <param name="picUrl">Picture URL</param>
        /// <param name="taggedUserEmail">emial ID of the User tagged in the Post</param>
        /// <returns></returns>
        public bool PostPictureMesssage(string message, string picUrl, string taggedUserEmail)
        {
            try
            {
                if (null == picUrl)
                    throw new ArgumentNullException("PicUrl", "Cannot post an empty image to Facebook.");
                IFacebookPostData data = new FacebookPostData();
                data.Message = message;
                data.PictureUrl = picUrl;
                data.TaggedUserEmail = taggedUserEmail;

                return page.AddPost(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets all the comments for the given post ID
        /// </summary>
        /// <param name="postID">Post ID</param>
        /// <returns>Returns List of all the comments for the post</returns>
        public IEnumerable<FacebookComment> GetAllCommentsForPost(string postID)
        {
            try
            {
                if (null == postID)
                    throw new ArgumentNullException("PostID", "Cannot get the comments for null post ID.");
                return page.GetAllCommentsForPost(postID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the Profiles of the users who liked the post
        /// </summary>
        /// <param name="postID">Post ID</param>
        /// <returns>Returns list of all the likes for the post</returns>
        public IEnumerable<IFacebookProfile> GetAllLikesForPost(string postID)
        {
            try
            {
                if (null == postID)
                    throw new ArgumentNullException("PostID", "Cannot get like for null post ID.");
                return page.GetAllLikesForPost(postID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updates the Facebook Agent to use the new access Token
        /// </summary>
        /// <param name="accessToken">New Access Token to be used</param>
        //public FacebookFacade UpdateAccessToken(string accessToken)
        //{
        //    try
        //    {
        //        return Activate(accessToken);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        #region IDisposable Members

        public void Dispose()
        {
            this.page.Dispose();
        }

        #endregion
    }
}