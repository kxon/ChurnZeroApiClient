﻿namespace ChurnZeroApiClient.Models.Request
{
    public class BaseRequest
    {
        /// <summary>
        /// The AccountExternalID is your unique record to identify your account. This ID should be in your CRM.
        /// </summary>
        public string AccountExternalId { get; }

        /// <summary>
        /// The contactExternalId must be unique within the account. 
        /// This could be a email address, a unique record that is also contained in your CRM, or the ID of the contact record of your CRM.
        /// </summary>
        public string ContactExternalId { get; }
    }
}
