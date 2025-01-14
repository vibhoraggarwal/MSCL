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

public class BitMask : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BitMask(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BitMask obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BitMask() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_BitMask(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

    public override bool Equals(object obj) { BitMask other = obj as BitMask; return this.__eq__(other); }
    public override int GetHashCode() { return (int)(toMask()); }
    public static bool operator<(BitMask v1, BitMask v2) { return v1.__lt__(v2); }
    public static bool operator>(BitMask v1, BitMask v2) { return v1.__gt__(v2); }

  public BitMask(ushort val) : this(msclPINVOKE.new_BitMask__SWIG_0(val), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public BitMask() : this(msclPINVOKE.new_BitMask__SWIG_1(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool __eq__(BitMask other) {
    bool ret = msclPINVOKE.BitMask___eq__(swigCPtr, BitMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool __ne__(BitMask other) {
    bool ret = msclPINVOKE.BitMask___ne__(swigCPtr, BitMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool __lt__(BitMask other) {
    bool ret = msclPINVOKE.BitMask___lt__(swigCPtr, BitMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool __gt__(BitMask other) {
    bool ret = msclPINVOKE.BitMask___gt__(swigCPtr, BitMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void fromMask(ushort val) {
    msclPINVOKE.BitMask_fromMask(swigCPtr, val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ushort toMask() {
    ushort ret = msclPINVOKE.BitMask_toMask(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual byte enabledCount() {
    byte ret = msclPINVOKE.BitMask_enabledCount(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool enabled(byte bitIndex) {
    bool ret = msclPINVOKE.BitMask_enabled(swigCPtr, bitIndex);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void enable(byte bitIndex, bool enable) {
    msclPINVOKE.BitMask_enable__SWIG_0(swigCPtr, bitIndex, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void enable(byte bitIndex) {
    msclPINVOKE.BitMask_enable__SWIG_1(swigCPtr, bitIndex);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual short lastBitEnabled() {
    short ret = msclPINVOKE.BitMask_lastBitEnabled(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
