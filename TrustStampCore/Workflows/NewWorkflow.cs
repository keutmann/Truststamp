﻿using TrustStampCore.Repository;

namespace TrustStampCore.Workflows
{
    public class NewWorkflow : WorkflowBatch
    {
        public override void Execute()
        {

            using (var db = TimeStampDatabase.Open())
            {
                WriteLog("Workflow started", db);

                //Push(new MerkleWorkflow());

                db.BatchTable.Update(CurrentBatch);
            }
        }

    }
}
