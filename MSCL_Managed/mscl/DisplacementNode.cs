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

public class DisplacementNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DisplacementNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DisplacementNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DisplacementNode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_DisplacementNode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DisplacementNode(Connection connection) : this(msclPINVOKE.new_DisplacementNode(Connection.getCPtr(connection)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Bytes doCommand(byte descriptorSet, byte cmdDescriptor, Bytes fieldData, bool ackNackResponse, bool dataResponse, byte responseDataDescriptor) {
    Bytes ret = new Bytes(msclPINVOKE.DisplacementNode_doCommand__SWIG_0(swigCPtr, descriptorSet, cmdDescriptor, Bytes.getCPtr(fieldData), ackNackResponse, dataResponse, responseDataDescriptor), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bytes doCommand(byte descriptorSet, byte cmdDescriptor, Bytes fieldData, bool ackNackResponse, bool dataResponse) {
    Bytes ret = new Bytes(msclPINVOKE.DisplacementNode_doCommand__SWIG_1(swigCPtr, descriptorSet, cmdDescriptor, Bytes.getCPtr(fieldData), ackNackResponse, dataResponse), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string deviceName(string serial) {
    string ret = msclPINVOKE.DisplacementNode_deviceName(serial);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Connection connection() {
    Connection ret = new Connection(msclPINVOKE.DisplacementNode_connection(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipNodeFeatures features() {
    MipNodeFeatures ret = new MipNodeFeatures(msclPINVOKE.DisplacementNode_features(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Timestamp lastCommunicationTime() {
    Timestamp ret = new Timestamp(msclPINVOKE.DisplacementNode_lastCommunicationTime(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeviceState lastDeviceState() {
    DeviceState ret = (DeviceState)msclPINVOKE.DisplacementNode_lastDeviceState(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Version firmwareVersion() {
    Version ret = new Version(msclPINVOKE.DisplacementNode_firmwareVersion(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DisplacementModels.NodeModel model() {
    DisplacementModels.NodeModel ret = (DisplacementModels.NodeModel)msclPINVOKE.DisplacementNode_model(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelName() {
    string ret = msclPINVOKE.DisplacementNode_modelName(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelNumber() {
    string ret = msclPINVOKE.DisplacementNode_modelNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string serialNumber() {
    string ret = msclPINVOKE.DisplacementNode_serialNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string lotNumber() {
    string ret = msclPINVOKE.DisplacementNode_lotNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string deviceOptions() {
    string ret = msclPINVOKE.DisplacementNode_deviceOptions(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets(uint timeout, uint maxPackets) {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.DisplacementNode_getDataPackets__SWIG_0(swigCPtr, timeout, maxPackets), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets(uint timeout) {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.DisplacementNode_getDataPackets__SWIG_1(swigCPtr, timeout), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets() {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.DisplacementNode_getDataPackets__SWIG_2(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint totalPackets() {
    uint ret = msclPINVOKE.DisplacementNode_totalPackets(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void timeout(ulong timeout) {
    msclPINVOKE.DisplacementNode_timeout__SWIG_0(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong timeout() {
    ulong ret = msclPINVOKE.DisplacementNode_timeout__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = msclPINVOKE.DisplacementNode_name(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ping() {
    bool ret = msclPINVOKE.DisplacementNode_ping(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setToIdle() {
    msclPINVOKE.DisplacementNode_setToIdle(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool cyclePower() {
    bool ret = msclPINVOKE.DisplacementNode_cyclePower(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resume() {
    msclPINVOKE.DisplacementNode_resume(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public SampleRate getDisplacementOutputDataRate() {
    SampleRate ret = new SampleRate(msclPINVOKE.DisplacementNode_getDisplacementOutputDataRate(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LinearEquation getAnalogToDisplacementCal() {
    LinearEquation ret = new LinearEquation(msclPINVOKE.DisplacementNode_getAnalogToDisplacementCal(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDeviceTime() {
    msclPINVOKE.DisplacementNode_setDeviceTime__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDeviceTime(ulong nanoseconds) {
    msclPINVOKE.DisplacementNode_setDeviceTime__SWIG_1(swigCPtr, nanoseconds);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
