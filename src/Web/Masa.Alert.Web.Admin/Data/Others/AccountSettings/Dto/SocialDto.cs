﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.Alert.Web.Admin.Data.Others.AccountSettings.Dto
{
    public class SocialDto
    {
        public string Twitter { get; set; }

        public string Facebook { get; set; }

        public string Google { get; set; }

        public string LinkedIn { get; set; }

        public string Instagram { get; set; }

        public string Quora { get; set; }

        public SocialDto(string twitter, string facebook, string google, string linkedIn, string instagram, string quora)
        {
            Twitter = twitter;
            Facebook = facebook;
            Google = google;
            LinkedIn = linkedIn;
            Instagram = instagram;
            Quora = quora;
        }
    }
}
