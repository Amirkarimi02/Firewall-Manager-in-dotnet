using FirewallManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Threading.Tasks;

namespace FirewallManager
{
    public class FirewallManager
    {
        private List<FirewallRule> rules;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        // Use where you want
        /*logger.Info("Information message");
        logger.Debug("Debug message");
        logger.Warn("Warning message");
        logger.Error("Error message");*/

        public FirewallManager()
        {
            rules = new List<FirewallRule>();
        }

        public void AddRule(FirewallRule rule)
        {
            if (rule.IsValid())
            {
                // Check if the rule with the same ID already exists
                if (GetRuleById(rule.RuleId) != null)
                {
                    Console.WriteLine($"A rule with ID {rule.RuleId} already exists. Please provide a unique ID.");
                    return;
                }

                rules.Add(rule);
                Console.WriteLine("Firewall rule added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid firewall rule. Please check the rule details and try again.");
            }
        }

        public void UpdateRule(int ruleId, FirewallRule updatedRule)
        {
            var existingRule = GetRuleById(ruleId);
            if (existingRule != null)
            {
                // Check if the updated rule is valid and does not conflict with existing rules
                if (updatedRule.IsValid() && !HasConflictingRule(updatedRule))
                {
                    existingRule.Name = updatedRule.Name;
                    existingRule.SourceAddress = updatedRule.SourceAddress;
                    existingRule.DestinationAddress = updatedRule.DestinationAddress;
                    existingRule.SourcePort = updatedRule.SourcePort;
                    existingRule.DestinationPort = updatedRule.DestinationPort;
                    existingRule.Protocol = updatedRule.Protocol;
                    existingRule.Action = updatedRule.Action;
                    existingRule.Description = updatedRule.Description;
                    Console.WriteLine("Firewall rule updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid firewall rule or conflicting rule. Please check the rule details and try again.");
                }
            }
            else
            {
                Console.WriteLine("Firewall rule not found. Please provide a valid rule ID.");
            }
        }

        public void DeleteRule(int ruleId)
        {
            var existingRule = GetRuleById(ruleId);
            if (existingRule != null)
            {
                rules.Remove(existingRule);
                Console.WriteLine("Firewall rule deleted successfully.");
            }
            else
            {
                Console.WriteLine("Firewall rule not found. Please provide a valid rule ID.");
            }
        }

        public List<FirewallRule> GetAllRules()
        {
            return rules;
        }

        public FirewallRule GetRuleById(int ruleId)
        {
            return rules.FirstOrDefault(r => r.RuleId == ruleId);
        }

        public List<FirewallRule> GetRulesBySourceAddress(string sourceAddress)
        {
            return rules.Where(r => r.SourceAddress == sourceAddress).ToList();
        }

        public List<FirewallRule> GetRulesByDestinationAddress(string destinationAddress)
        {
            return rules.Where(r => r.DestinationAddress == destinationAddress).ToList();
        }

        public List<FirewallRule> GetRulesByPort(int port)
        {
            return rules.Where(r => r.SourcePort == port || r.DestinationPort == port).ToList();
        }

        public List<FirewallRule> GetRulesByProtocol(string protocol)
        {
            return rules.Where(r => r.Protocol == protocol).ToList();
        }

        public List<FirewallRule> GetRulesByAction(string action)
        {
            return rules.Where(r => r.Action == action).ToList();
        }

        public List<FirewallRule> GetRulesByDescription(string description)
        {
            return rules.Where(r => r.Description.Contains(description)).ToList();
        }

        private bool HasConflictingRule(FirewallRule rule)
        {
            // Check if the rule conflicts with any existing rules
            return rules.Any(r => r.RuleId != rule.RuleId &&
                                  r.SourceAddress == rule.SourceAddress &&
                                  r.DestinationAddress == rule.DestinationAddress &&
                                  r.SourcePort == rule.SourcePort &&
                                  r.DestinationPort == rule.DestinationPort &&
                                  r.Protocol == rule.Protocol);
        }
    }
}
