using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirewallManager.Classes
{
    public class FirewallRule
    {
        public int RuleId { get; set; }
        public string Name { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public int SourcePort { get; set; }
        public int DestinationPort { get; set; }
        public string Protocol { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public bool IsValid()
        {
            // Add your custom validation logic here
            // Return true if the rule is valid, otherwise return false

            // Example validation: Check if required fields are not empty
            return !string.IsNullOrEmpty(Name) &&
                   !string.IsNullOrEmpty(SourceAddress) &&
                   !string.IsNullOrEmpty(DestinationAddress) &&
                   !string.IsNullOrEmpty(Protocol) &&
                   !string.IsNullOrEmpty(Action);
        }
    }
}
