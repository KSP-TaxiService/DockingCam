namespace OLDD_camera.Utils
{
    public class ModuleSpyExperiment : ModuleScienceExperiment
    {
        //[KSPEvent(guiName = "Deploy", active = true, guiActive = false)] //Obsolete in KSP 1.7
        public new void DeployExperiment()
        {
            base.DeployExperiment();
        }

        //[KSPEvent(guiName = "Review Data", active = true, guiActive = true)] //Obsolete in KSP 1.7
        public new void ReviewDataEvent()
        {
            base.ReviewData();
        }
    }
}