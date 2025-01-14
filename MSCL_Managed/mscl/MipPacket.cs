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

public class MipPacket : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MipPacket(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MipPacket obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MipPacket() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_MipPacket(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MipPacket() : this(msclPINVOKE.new_MipPacket(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isDataPacket() {
    bool ret = msclPINVOKE.MipPacket_isDataPacket(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte descriptorSet() {
    byte ret = msclPINVOKE.MipPacket_descriptorSet(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bytes payload() {
    Bytes ret = new Bytes(msclPINVOKE.MipPacket_payload(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum MipAckNack {
    MIP_ACK_NACK_ERROR_NONE = 0,
    MIP_ACK_NACK_ERROR_UNKNOWN_COMMAND = 1,
    MIP_ACK_NACK_ERROR_CHECKSUM_INVALID = 2,
    MIP_ACK_NACK_ERROR_PARAMETER_INVALID = 3,
    MIP_ACK_NACK_ERROR_COMMAND_FAILED = 4,
    MIP_ACK_NACK_ERROR_COMMAND_TIMEOUT = 5,
    MIP_ACK_NACK_ERROR_UNKNOWN_DESCRIPTOR_SET = 6
  }

}

}
