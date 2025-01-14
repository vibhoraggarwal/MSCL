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

public class MipTypes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MipTypes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MipTypes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MipTypes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_MipTypes(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static string channelName(MipTypes.ChannelField field, MipTypes.ChannelQualifier qualifier) {
    string ret = msclPINVOKE.MipTypes_channelName((int)field, (int)qualifier);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipTypes() : this(msclPINVOKE.new_MipTypes(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum DataClass {
    CLASS_AHRS_IMU = 0x80,
    CLASS_GNSS = 0x81,
    CLASS_ESTFILTER = 0x82,
    CLASS_DISPLACEMENT = 0x90
  }

  public enum FunctionSelector {
    USE_NEW_SETTINGS = 0x01,
    READ_BACK_CURRENT_SETTINGS = 0x02,
    SAVE_CURRENT_SETTINGS = 0x03,
    LOAD_STARTUP_SETTINGS = 0x04,
    RESET_TO_DEFAULT = 0x05
  }

  public enum StatusSelector {
    BASIC_STATUS_STRUCTURE = 0x01,
    DIAGNOSTIC_STATUS_STRUCTURE = 0x02
  }

  public enum EnableSetting {
    DISABLED = 0,
    ENABLED = 1
  }

  public enum TimeFrame {
    TIME_FRAME_WEEKS = 0,
    TIME_FRAME_SECONDS = 1
  }

  public enum Command {
    CMD_PING = 0x0101,
    CMD_SET_IDLE = 0x0102,
    CMD_GET_DEVICE_INFO = 0x0103,
    CMD_GET_DESCRIPTOR_SETS = 0x0104,
    CMD_BUILT_IN_TEST = 0x0105,
    CMD_RESUME = 0x0106,
    CMD_GET_EXT_DESCRIPTOR_SETS = 0x0107,
    CMD_GPS_TIME_UPDATE = 0x0172,
    CMD_RESET = 0x017E,
    CMD_POLL_SENSOR_DATA = 0x0C01,
    CMD_POLL_GNSS_DATA = 0x0C02,
    CMD_POLL_EF_DATA = 0x0C03,
    CMD_GET_SENSOR_RATE_BASE = 0x0C06,
    CMD_GET_GNSS_RATE_BASE = 0x0C07,
    CMD_GET_EF_RATE_BASE = 0x0C0B,
    CMD_SENSOR_MESSAGE_FORMAT = 0x0C08,
    CMD_GNSS_MESSAGE_FORMAT = 0x0C09,
    CMD_EF_MESSAGE_FORMAT = 0x0C0A,
    CMD_CONTINUOUS_DATA_STREAM = 0x0C11,
    CMD_RAW_RTCM_2_3_MESSAGE = 0x0C20,
    CMD_GNSS_CONSTELLATION_SETTINGS = 0x0C21,
    CMD_GNSS_SBAS_SETTINGS = 0x0C22,
    CMD_GNSS_ASSIST_FIX_CONTROL = 0x0C23,
    CMD_GNSS_ASSIST_TIME_UPDATE = 0x0C24,
    CMD_SAVE_STARTUP_SETTINGS = 0x0C30,
    CMD_GPS_DYNAMICS_MODE = 0x0C34,
    CMD_SENSOR_SIG_COND_SETTINGS = 0x0C35,
    CMD_SENSOR_TIMESTAMP = 0x0C36,
    CMD_ACCEL_BIAS = 0x0C37,
    CMD_GYRO_BIAS = 0x0C38,
    CMD_CAP_GYRO_BIAS = 0x0C39,
    CMD_MAG_HARD_IRON_OFFSET = 0x0C3A,
    CMD_MAG_SOFT_IRON_MATRIX = 0x0C3B,
    CMD_CF_REALIGN_UP = 0x0C3C,
    CMD_CF_REALIGN_NORTH = 0x0C3D,
    CMD_CONING_SCULLING = 0x0C3E,
    CMD_UART_BAUD_RATE = 0x0C40,
    CMD_LOWPASS_FILTER_SETTINGS = 0x0C50,
    CMD_COMPLEMENTARY_FILTER_SETTINGS = 0x0C51,
    CMD_DATA_STREAM_FORMAT = 0x0C60,
    CMD_POWER_STATES = 0x0C61,
    CMD_GPS_STARTUP_SETTINGS = 0x0C62,
    CMD_DEVICE_STATUS = 0x0C64,
    CMD_EF_RESET_FILTER = 0x0D01,
    CMD_EF_INIT_ATTITUDE = 0x0D02,
    CMD_EF_INIT_HEADING = 0x0D03,
    CMD_EF_INIT_ATTITUDE_FROM_AHRS = 0x0D04,
    CMD_EF_VEHIC_DYNAMICS_MODE = 0x0D10,
    CMD_EF_SENS_VEHIC_FRAME_TRANS = 0x0D11,
    CMD_EF_SENS_VEHIC_FRAME_OFFSET = 0x0D12,
    CMD_EF_ANTENNA_OFFSET = 0x0D13,
    CMD_EF_BIAS_EST_CTRL = 0x0D14,
    CMD_EF_GNSS_SRC_CTRL = 0x0D15,
    CMD_EF_EXTERN_GNSS_UPDATE = 0x0D16,
    CMD_EF_EXTERN_HEADING_UPDATE = 0x0D17,
    CMD_EF_HEADING_UPDATE_CTRL = 0x0D18,
    CMD_EF_AUTO_INIT_CTRL = 0x0D19,
    CMD_EF_ACCEL_WHT_NSE_STD_DEV = 0x0D1A,
    CMD_EF_GYRO_WHT_NSE_STD_DEV = 0x0D1B,
    CMD_EF_ACCEL_BIAS_MODEL_PARAMS = 0x0D1C,
    CMD_EF_GYRO_BIAS_MODEL_PARAMS = 0x0D1D,
    CMD_EF_ZERO_VEL_UPDATE_CTRL = 0x0D1E,
    CMD_EF_EXT_HEADING_UPDATE_TS = 0x0D1F,
    CMD_EF_ZERO_ANG_RATE_UPDATE_CTRL = 0x0D20,
    CMD_EF_TARE_ORIENT = 0x0D21,
    CMD_EF_CMDED_ZERO_VEL_UPDATE = 0x0D22,
    CMD_EF_CMDED_ZERO_ANG_RATE_UPDATE = 0x0D23,
    CMD_EF_SET_REF_POSITION = 0x0D26,
    CMD_EF_MAG_CAPTURE_AUTO_CAL = 0x0D27,
    CMD_EF_GRAVITY_NOISE_STD_DEV = 0x0D28,
    CMD_EF_PRESS_ALT_NOISE_STD_DEV = 0x0D29,
    CMD_EF_HARD_IRON_OFFSET_PROCESS_NOISE = 0x0D2B,
    CMD_EF_SOFT_IRON_OFFSET_PROCESS_NOISE = 0x0D2C,
    CMD_EF_ENABLE_DISABLE_MEASUREMENTS = 0x0D41,
    CMD_EF_MAG_NOISE_STD_DEV = 0x0D42,
    CMD_EF_DECLINATION_SRC = 0x0D43,
    CMD_EF_GRAV_MAGNITUDE_ERR_ADAPT_MEASURE = 0x0D44,
    CMD_EF_MAG_MAGNITUDE_ERR_ADAPT_MEASURE = 0x0D45,
    CMD_EF_MAG_DIP_ANGLE_ERR_ADAPT_MEASURE = 0x0D46,
    CMD_EF_ALTITUDE_AID_CTRL = 0x0D47,
    CMD_EF_PITCH_ROLL_AID_CTRL = 0x0D4B,
    CMD_EF_INCLINATION_SRC = 0x0D4C,
    CMD_EF_FIELD_MAGNITUDE_SRC = 0x0D4D,
    CMD_COMMUNICATION_MODE = 0x7F10,
    CMD_HARDWARE_CTRL = 0x7F11,
    CMD_GET_ANALOG_DISPLACEMENT_CALS = 0x1101,
    CMD_DISPLACEMENT_OUTPUT_RATE = 0x1102,
    CMD_DISPLACEMENT_DEVICE_TIME = 0x1104
  }

  public enum ChannelField {
    CH_FIELD_SENSOR_RAW_ACCEL_VEC = 0x8001,
    CH_FIELD_SENSOR_RAW_GYRO_VEC = 0x8002,
    CH_FIELD_SENSOR_RAW_MAG_VEC = 0x8003,
    CH_FIELD_SENSOR_SCALED_ACCEL_VEC = 0x8004,
    CH_FIELD_SENSOR_SCALED_GYRO_VEC = 0x8005,
    CH_FIELD_SENSOR_SCALED_MAG_VEC = 0x8006,
    CH_FIELD_SENSOR_DELTA_THETA_VEC = 0x8007,
    CH_FIELD_SENSOR_DELTA_VELOCITY_VEC = 0x8008,
    CH_FIELD_SENSOR_ORIENTATION_MATRIX = 0x8009,
    CH_FIELD_SENSOR_ORIENTATION_QUATERNION = 0x800A,
    CH_FIELD_SENSOR_ORIENTATION_UPDATE_MATRIX = 0x800B,
    CH_FIELD_SENSOR_EULER_ANGLES = 0x800C,
    CH_FIELD_SENSOR_INTERNAL_TIMESTAMP = 0x800E,
    CH_FIELD_SENSOR_BEACONED_TIMESTAMP = 0x800F,
    CH_FIELD_SENSOR_STABILIZED_MAG_VEC = 0x8010,
    CH_FIELD_SENSOR_STABILIZED_ACCEL_VEC = 0x8011,
    CH_FIELD_SENSOR_GPS_CORRELATION_TIMESTAMP = 0x8012,
    CH_FIELD_SENSOR_SCALED_AMBIENT_PRESSURE = 0x8017,
    CH_FIELD_GNSS_LLH_POSITION = 0x8103,
    CH_FIELD_GNSS_ECEF_POSITION = 0x8104,
    CH_FIELD_GNSS_NED_VELOCITY = 0x8105,
    CH_FIELD_GNSS_ECEF_VELOCITY = 0x8106,
    CH_FIELD_GNSS_DOP = 0x8107,
    CH_FIELD_GNSS_UTC_TIME = 0x8108,
    CH_FIELD_GNSS_GPS_TIME = 0x8109,
    CH_FIELD_GNSS_CLOCK_INFO = 0x810A,
    CH_FIELD_GNSS_FIX_INFO = 0x810B,
    CH_FIELD_GNSS_SPACE_VEHICLE_INFO = 0x810C,
    CH_FIELD_GNSS_HARDWARE_STATUS = 0x810D,
    CH_FIELD_GNSS_DGNSS_INFO = 0x810E,
    CH_FIELD_GNSS_DGNSS_CHANNEL_STATUS = 0x810F,
    CH_FIELD_ESTFILTER_ESTIMATED_LLH_POS = 0x8201,
    CH_FIELD_ESTFILTER_ESTIMATED_NED_VELOCITY = 0x8202,
    CH_FIELD_ESTFILTER_ESTIMATED_ORIENT_QUATERNION = 0x8203,
    CH_FIELD_ESTFILTER_ESTIMATED_ORIENT_MATRIX = 0x8204,
    CH_FIELD_ESTFILTER_ESTIMATED_ORIENT_EULER = 0x8205,
    CH_FIELD_ESTFILTER_ESTIMATED_GYRO_BIAS = 0x8206,
    CH_FIELD_ESTFILTER_ESTIMATED_ACCEL_BIAS = 0x8207,
    CH_FIELD_ESTFILTER_ESTIMATED_LLH_UNCERT = 0x8208,
    CH_FIELD_ESTFILTER_ESTIMATED_NED_UNCERT = 0x8209,
    CH_FIELD_ESTFILTER_ESTIMATED_ATT_UNCERT_EULER = 0x820A,
    CH_FIELD_ESTFILTER_ESTIMATED_GYRO_BIAS_UNCERT = 0x820B,
    CH_FIELD_ESTFILTER_ESTIMATED_ACCEL_BIAS_UNCERT = 0x820C,
    CH_FIELD_ESTFILTER_ESTIMATED_LINEAR_ACCEL = 0x820D,
    CH_FIELD_ESTFILTER_ESTIMATED_ANGULAR_RATE = 0x820E,
    CH_FIELD_ESTFILTER_WGS84_LOC_GRAV_MAGNITUDE = 0x820F,
    CH_FIELD_ESTFILTER_FILTER_STATUS = 0x8210,
    CH_FIELD_ESTFILTER_GPS_TIMESTAMP = 0x8211,
    CH_FIELD_ESTFILTER_ESTIMATED_ATT_UNCERT_QUAT = 0x8212,
    CH_FIELD_ESTFILTER_ESTIMATED_GRAVITY_VECTOR = 0x8213,
    CH_FIELD_ESTFILTER_HEADING_UPDATE_SOURCE = 0x8214,
    CH_FIELD_ESTFILTER_MAGNETIC_MODEL_SLN = 0x8215,
    CH_FIELD_ESTFILTER_ESTIMATED_GYRO_SCALE_FACTOR = 0x8216,
    CH_FIELD_ESTFILTER_ACCEL_SCALE_FACTOR = 0x8217,
    CH_FIELD_ESTFILTER_GYRO_SCALE_FACTOR_UNCERT = 0x8218,
    CH_FIELD_ESTFILTER_ACCEL_SCALE_FACTOR_UNCERT = 0x8219,
    CH_FIELD_ESTFILTER_COMPENSATED_ACCEL = 0x821C,
    CH_FIELD_ESTFILTER_STD_ATMOSPHERE_MODEL = 0x8220,
    CH_FIELD_ESTFILTER_PRESSURE_ALTITUDE = 0x8221,
    CH_FIELD_ESTFILTER_MAG_AUTO_HARD_IRON_OFFSET = 0x8225,
    CH_FIELD_ESTFILTER_MAG_AUTO_SOFT_IRON_MATRIX = 0x8226,
    CH_FIELD_ESTFILTER_MAG_AUTO_HARD_IRON_OFFSET_UNCERT = 0x8228,
    CH_FIELD_ESTFILTER_MAG_AUTO_SOFT_IRON_MATRIX_UNCERT = 0x8229,
    CH_FIELD_ESTFILTER_GNSS_ANTENNA_CORRECTION = 0x8230,
    CH_FIELD_ESTFILTER_GNSS_ANTENNA_CORRECTION_UNCERT = 0x8231,
    CH_FIELD_DISP_DISPLACEMENT_RAW = 0x9001,
    CH_FIELD_DISP_DISPLACEMENT_MM = 0x9002,
    CH_FIELD_DISP_DISPLACEMENT_TS = 0x9004
  }

  public enum ChannelQualifier {
    CH_UNKNOWN = 0,
    CH_X = 1,
    CH_Y = 2,
    CH_Z = 3,
    CH_MATRIX = 4,
    CH_QUATERNION = 5,
    CH_ROLL = 6,
    CH_PITCH = 7,
    CH_YAW = 8,
    CH_TICK = 9,
    CH_TIMESTAMP = 10,
    CH_STATUS = 11,
    CH_TIME_OF_WEEK = 12,
    CH_WEEK_NUMBER = 13,
    CH_LATITUDE = 14,
    CH_LONGITUDE = 15,
    CH_HEIGHT_ABOVE_ELLIPSOID = 16,
    CH_HEIGHT_ABOVE_MSL = 17,
    CH_HORIZONTAL_ACCURACY = 18,
    CH_VERTICAL_ACCURACY = 19,
    CH_POSITION_ACCURACY = 20,
    CH_NORTH = 21,
    CH_EAST = 22,
    CH_DOWN = 23,
    CH_SPEED = 24,
    CH_GROUND_SPEED = 25,
    CH_HEADING = 26,
    CH_SPEED_ACCURACY = 27,
    CH_HEADING_ACCURACY = 28,
    CH_VELOCITY_ACCURACY = 29,
    CH_GEOMETRIC_DOP = 30,
    CH_POSITION_DOP = 31,
    CH_HORIZONTAL_DOP = 32,
    CH_VERTICAL_DOP = 33,
    CH_TIME_DOP = 34,
    CH_NORTHING_DOP = 35,
    CH_EASTING_DOP = 36,
    CH_FLAGS = 37,
    CH_BIAS = 38,
    CH_DRIFT = 39,
    CH_ACCURACY_ESTIMATE = 40,
    CH_FIX_TYPE = 41,
    CH_SV_COUNT = 42,
    CH_CHANNEL = 43,
    CH_ID = 44,
    CH_CARRIER_TO_NOISE_RATIO = 45,
    CH_AZIMUTH = 46,
    CH_ELEVATION = 47,
    CH_SENSOR_STATE = 48,
    CH_ANTENNA_STATE = 49,
    CH_ANTENNA_POWER = 50,
    CH_FILTER_STATE = 51,
    CH_DYNAMICS_MODE = 52,
    CH_MAGNITUDE = 53,
    CH_HEADING_UNCERTAINTY = 54,
    CH_SOURCE = 55,
    CH_INCLINATION = 56,
    CH_DECLINATION = 57,
    CH_PRESSURE = 58,
    CH_AGE = 59,
    CH_NUM_CHANNELS = 60,
    CH_CORRECTION = 61,
    CH_RATE_CORRECTION = 62,
    CH_GEOMETRIC_ALTITUDE = 63,
    CH_GEOPOTENTIAL_ALTITUDE = 64,
    CH_TEMPERATURE = 65,
    CH_DENSITY = 66,
    CH_ALTITUDE = 67,
    CH_DISPLACEMENT = 68
  }

}

}
