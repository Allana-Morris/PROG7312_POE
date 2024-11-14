using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models;
using PROG7312_POE.Class.TreeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class
{
    public class RequestManager
    {
        public RequestManager() { }

        private RedBlackTree redBlackTree = new RedBlackTree();

        public void AddRequest(ReportedRequest request)
        {
            redBlackTree.Insert(request);
        }

        public List<ReportedRequest> GetAllRequests()
        {
            return redBlackTree.InOrderTraversal();
        }

        public bool RequestExists(Guid requestId)
        {
            var tempRequest = new ReportedRequest(requestId);
            return redBlackTree.Search(tempRequest);
        }

        public ReportedRequest GetRequestById(Guid requestId)
        {
            var tempRequest = new ReportedRequest(requestId);
            return redBlackTree.Search(tempRequest) ? tempRequest : null;
        }

        public void UpdateRequestStatus(Guid requestId, RequestStatus newStatus, int progress)
        {
            var request = GetRequestById(requestId);
            if (request != null)
            {
                request.UpdateStatus(newStatus, progress);
            }
        }
    }
}

