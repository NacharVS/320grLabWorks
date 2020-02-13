using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class Stats 
    {
        public string health { get; set; }
        public string healthRecoveryRate { get; set; }
        public string dexterity { get; set; }
        public string intelligence { get; set; }
        public string sensitivityToForce { get; set; }
        public string reason { get; set; }

        public Stats(string Health, string HealthRecoveryRate, string Dexterity, string Intelligence, 
                     string SensitivityToForce, string Reason)
        {
            health = Health;
            healthRecoveryRate = HealthRecoveryRate;
            dexterity = Dexterity;
            intelligence = Intelligence;
            sensitivityToForce = SensitivityToForce;
            reason = Reason;
        }
    }
}
