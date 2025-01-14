//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.6
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class DataSweep : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DataSweep(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DataSweep obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DataSweep() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_DataSweep(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DataSweep() : this(msclPINVOKE.new_DataSweep(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public Timestamp timestamp() {
    Timestamp ret = new Timestamp(msclPINVOKE.DataSweep_timestamp(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint tick() {
    uint ret = msclPINVOKE.DataSweep_tick(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SampleRate sampleRate() {
    SampleRate ret = new SampleRate(msclPINVOKE.DataSweep_sampleRate(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint nodeAddress() {
    uint ret = msclPINVOKE.DataSweep_nodeAddress(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChannelData data() {
    ChannelData ret = new ChannelData(msclPINVOKE.DataSweep_data(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DataSweep.SamplingType samplingType() {
    DataSweep.SamplingType ret = (DataSweep.SamplingType)msclPINVOKE.DataSweep_samplingType(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public short nodeRssi() {
    short ret = msclPINVOKE.DataSweep_nodeRssi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public short baseRssi() {
    short ret = msclPINVOKE.DataSweep_baseRssi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public WirelessTypes.Frequency frequency() {
    WirelessTypes.Frequency ret = (WirelessTypes.Frequency)msclPINVOKE.DataSweep_frequency(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool calApplied() {
    bool ret = msclPINVOKE.DataSweep_calApplied(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum SamplingType {
    samplingType_NonSync = 0,
    samplingType_NonSync_Buffered = 1,
    samplingType_SyncSampling = 2,
    samplingType_SyncSampling_Burst = 3,
    samplingType_AsyncDigital = 4,
    samplingType_AsyncDigitalAnalog = 5,
    samplingType_SHM = 6,
    samplingType_BeaconEcho = 7,
    samplingType_RfSweep = 8,
    samplingType_Diagnostic = 9
  }

}

}
