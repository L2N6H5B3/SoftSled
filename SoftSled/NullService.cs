using Intel.UPNP;

namespace SoftSled
{
    /// <summary>
    /// Transparent DeviceSide UPnP Service
    /// </summary>
    public class NullService : IUPnPService
    {

        // Place your declarations above this line

        #region AutoGenerated Code Section [Do NOT Modify, unless you know what you're doing]
        //{{{{{ Begin Code Block

        private _NullService _S;
        public static string URN = "urn:schemas-microsoft-com:service:NULL:1";
        public double VERSION
        {
            get
            {
                return (double.Parse(_S.GetUPnPService().Version));
            }
        }

        public delegate void OnStateVariableModifiedHandler(NullService sender);
        public event OnStateVariableModifiedHandler OnStateVariableModified_Target;
        public System.Boolean Target
        {
            get
            {
                return ((System.Boolean)_S.GetStateVariable("Target"));
            }
            set
            {
                _S.SetStateVariable("Target", value);
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_Target
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("Target")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("Target")).Accumulator = value;
            }
        }
        public double ModerationDuration_Target
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("Target")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("Target")).ModerationPeriod = value;
            }
        }


        public void RemoveStateVariable_Target()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("Target"));
        }
        public System.Net.IPEndPoint GetCaller()
        {
            return (_S.GetUPnPService().GetCaller());
        }
        public System.Net.IPEndPoint GetReceiver()
        {
            return (_S.GetUPnPService().GetReceiver());
        }

        private class _NullService
        {
            private NullService Outer = null;
            private UPnPService S;
            internal _NullService(NullService n)
            {
                Outer = n;
                S = BuildUPnPService();
            }
            public UPnPService GetUPnPService()
            {
                return (S);
            }
            public void SetStateVariable(string VarName, object VarValue)
            {
                S.SetStateVariable(VarName, VarValue);
            }
            public object GetStateVariable(string VarName)
            {
                return (S.GetStateVariable(VarName));
            }
            protected UPnPService BuildUPnPService()
            {
                UPnPStateVariable[] RetVal = new UPnPStateVariable[1];
                RetVal[0] = new UPnPModeratedStateVariable("Target", typeof(System.Boolean), false);

                UPnPService S = new UPnPService(1, "urn:microsoft-com:serviceId:NULL", "urn:schemas-microsoft-com:service:NULL:1", true, this);
                for (int i = 0; i < RetVal.Length; ++i)
                {
                    S.AddStateVariable(RetVal[i]);
                }
                return (S);
            }


        }
        public NullService()
        {
            _S = new _NullService(this);
            _S.GetUPnPService().GetStateVariableObject("Target").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_Target);
        }
        public NullService(string ID)
            : this()
        {
            _S.GetUPnPService().ServiceID = ID;
        }
        public UPnPService GetUPnPService()
        {
            return (_S.GetUPnPService());
        }
        private void OnModifiedSink_Target(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_Target != null) OnStateVariableModified_Target(this);
        }
        //}}}}} End of Code Block

        #endregion

    }
}