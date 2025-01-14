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

public class CalCoefficients : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CalCoefficients(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CalCoefficients obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CalCoefficients() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_CalCoefficients(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CalCoefficients() : this(msclPINVOKE.new_CalCoefficients__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public CalCoefficients(WirelessTypes.CalCoef_EquationType eqType, WirelessTypes.CalCoef_Unit unit, LinearEquation linearEq) : this(msclPINVOKE.new_CalCoefficients__SWIG_1((int)eqType, (int)unit, LinearEquation.getCPtr(linearEq)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public WirelessTypes.CalCoef_EquationType equationType() {
    WirelessTypes.CalCoef_EquationType ret = (WirelessTypes.CalCoef_EquationType)msclPINVOKE.CalCoefficients_equationType(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public WirelessTypes.CalCoef_Unit unit() {
    WirelessTypes.CalCoef_Unit ret = (WirelessTypes.CalCoef_Unit)msclPINVOKE.CalCoefficients_unit(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LinearEquation linearEquation() {
    LinearEquation ret = new LinearEquation(msclPINVOKE.CalCoefficients_linearEquation(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
