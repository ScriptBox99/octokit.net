using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ReleaseAsset
    {
        public string Url { get; protected set; }

        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public string Label { get; protected set; }

        public string State { get; protected set; }

        public string ContentType { get; protected set; }

        public int Size { get; protected set; }

        public int DownloadCount { get; protected set; }

        public DateTimeOffset CreatedAt { get; protected set; }

        public DateTimeOffset UpdatedAt { get; protected set; }

        public string BrowserDownloadUrl { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return String.Format(CultureInfo.InvariantCulture, "Name: {0} CreatedAt: {1}", Name, CreatedAt); }
        }

        public ReleaseAssetUpdate ToUpdate()
        {
            return new ReleaseAssetUpdate(Name)
            {
                Label = Label
            };
        }
    }
}
