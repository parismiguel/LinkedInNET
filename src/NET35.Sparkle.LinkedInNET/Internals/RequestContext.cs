﻿
namespace Sparkle.LinkedInNET.Internals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class RequestContext
    {
        private Dictionary<string, string> queryStrings;
        private Dictionary<string, string> postQueryStrings;
        private bool bufferizeResponseStream = true;

        public string Method { get; set; }

        public string UrlPath { get; set; }

        public UserAuthorization UserAuthorization { get; set; }

        public Dictionary<string, string> QueryStrings
        {
            get { return this.queryStrings; }
        }

        public Dictionary<string, string> PostQueryStrings
        {
            get { return this.postQueryStrings; }
        }

        public bool BufferizeResponseStream
        {
            get { return this.bufferizeResponseStream; }
            set { this.bufferizeResponseStream = value; }
        }

        internal void AddUrlArgumentToUrlQueryString(string key, string value)
        {
            if (this.queryStrings == null)
                this.queryStrings = new Dictionary<string, string>();

            this.queryStrings.Add(key, value);
        }

        internal void AddUrlArgumentToPostContent(string key, string value)
        {
            if (this.postQueryStrings == null)
                this.postQueryStrings = new Dictionary<string, string>();

            this.postQueryStrings.Add(key, value);
        }

        public Stream ResponseStream { get; set; }

        public int HttpStatusCode { get; set; }
    }
}
