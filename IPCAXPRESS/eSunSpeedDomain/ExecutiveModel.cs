﻿namespace eSunSpeedDomain
{
    public class ExecutiveModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string AliasName { get; set; }
        public string Primary { get; set; }
        public string UnderGroup { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool CanDelete { get; set; }
        public object ContactName { get; set; }
    }
}
