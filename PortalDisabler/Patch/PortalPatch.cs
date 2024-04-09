using Fusion;
using UnityEngine;

namespace PortalDisabler.Patch
{
    internal class PortalPatch
    {
        public static void patch()
        {
            On.Portal.StartActivationTimer += Portal_StartActivationTimer;
        }

        private static void Portal_StartActivationTimer(On.Portal.orig_StartActivationTimer orig, Portal self)
        {
            if (self.HasStateAuthority)
            {
                self.Active = false;
                //Désactivation du timer
                //self.ActivationTimer = TickTimer.CreateFromSeconds(self.Runner, Random.Range(5f, 5f));
                //Je ne retire pas le code du timer car il servira plus tard avec un fichier de conf pour configurer un delais max d'activation du portail
            }
        }
    }
}
