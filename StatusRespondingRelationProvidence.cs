using ABI_RC.Core.Savior;
using HarmonyLib;
using MelonLoader;

[assembly:
    MelonInfo(typeof(StatusRespondingRelationProvidence.StatusRespondingRelationProvidence),
        "StatusRespondingRelationProvidence", "1.0.0", "hill")]

namespace StatusRespondingRelationProvidence
{
    [HarmonyPatch(typeof(MetaPort), "Start")]
    public class StatusRespondingRelationProvidence : MelonMod
    {
        private static void Postfix()
        {
            MetaPort.Instance.matureContentAllowed = true;
        }
    }
}