using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using static Mavlink;

// Custom message structs created using Mavgen are located on bottom of file.

/// <summary>
/// Mavlink constants, enums, payload structs and message infos are stored here
/// </summary>
public partial class Mavlink
{
    public const string MAVLINK_BUILD_DATE = "Mon Jun 19 2023";
    public const string MAVLINK_WIRE_PROTOCOL_VERSION = "1.0";
    public const int MAVLINK_MAX_PAYLOAD_LEN = 255;

    public const byte MAVLINK2_CORE_HEADER_LEN = 9; // Length of core header (of the comm. layer)
    public const byte MAVLINK1_CORE_HEADER_LEN = 5; // Length of MAVLink1 core header (of the comm. layer)
    public const byte MAVLINK2_NUM_HEADER_BYTES = (MAVLINK2_CORE_HEADER_LEN + 1); // Length of all header bytes, including core and stx
    public const byte MAVLINK_NUM_CHECKSUM_BYTES = 2;
    public const byte MAVLINK2_NUM_NON_PAYLOAD_BYTES = (MAVLINK2_NUM_HEADER_BYTES + MAVLINK_NUM_CHECKSUM_BYTES);

    public const int MAVLINK2_MAX_PACKET_LEN = (MAVLINK_MAX_PAYLOAD_LEN + MAVLINK2_NUM_NON_PAYLOAD_BYTES + MAVLINK2_SIGNATURE_BLOCK_LEN);///< Maximum packet length  
    public const byte MAVLINK2_SIGNATURE_BLOCK_LEN = 13;

    public const int MAVLINK_LITTLE_ENDIAN = 1;
    public const int MAVLINK_BIG_ENDIAN = 0;

    public const byte MAVLINK2_STX = 0xFD;

    public const byte MAVLINK1_STX = 0xFE;

    public const byte MAVLINK_ENDIAN = MAVLINK_LITTLE_ENDIAN;

    public const bool MAVLINK_ALIGNED_FIELDS = (1 == 1);

    public const byte MAVLINK_CRC_EXTRA = 1;
    
    public const byte MAVLINK_COMMAND_24BIT = 0;
        
    public const bool MAVLINK_NEED_BYTE_SWAP = (MAVLINK_ENDIAN == MAVLINK_LITTLE_ENDIAN);

    public const byte MAVLINK_VERSION = 3;

    public const byte MAVLINK_IFLAG_SIGNED = 0x01;

    public const byte MAVLINK_IFLAG_MASK = 0x01;

    // msgid, name, crc, minlength, length, type
    public static MessageInfo[] MavlinkMessageInfoTable = new MessageInfo[] {
        new MessageInfo(0, "HEARTBEAT", 50, 9, 9, typeof( mavlink_heartbeat_t )), // none 24 bit
        new MessageInfo(1, "SYS_STATUS", 124, 31, 31, typeof( mavlink_sys_status_t )), // none 24 bit
        new MessageInfo(2, "SYSTEM_TIME", 137, 12, 12, typeof( mavlink_system_time_t )), // none 24 bit
        new MessageInfo(4, "PING", 237, 14, 14, typeof( mavlink_ping_t )), // none 24 bit
        new MessageInfo(5, "CHANGE_OPERATOR_CONTROL", 217, 28, 28, typeof( mavlink_change_operator_control_t )), // none 24 bit
        new MessageInfo(6, "CHANGE_OPERATOR_CONTROL_ACK", 104, 3, 3, typeof( mavlink_change_operator_control_ack_t )), // none 24 bit
        new MessageInfo(7, "AUTH_KEY", 119, 32, 32, typeof( mavlink_auth_key_t )), // none 24 bit
        new MessageInfo(8, "LINK_NODE_STATUS", 117, 36, 36, typeof( mavlink_link_node_status_t )), // none 24 bit
        new MessageInfo(11, "SET_MODE", 89, 6, 6, typeof( mavlink_set_mode_t )), // none 24 bit
        new MessageInfo(20, "PARAM_REQUEST_READ", 214, 20, 20, typeof( mavlink_param_request_read_t )), // none 24 bit
        new MessageInfo(21, "PARAM_REQUEST_LIST", 159, 2, 2, typeof( mavlink_param_request_list_t )), // none 24 bit
        new MessageInfo(22, "PARAM_VALUE", 220, 25, 25, typeof( mavlink_param_value_t )), // none 24 bit
        new MessageInfo(23, "PARAM_SET", 168, 23, 23, typeof( mavlink_param_set_t )), // none 24 bit
        new MessageInfo(24, "GPS_RAW_INT", 24, 30, 30, typeof( mavlink_gps_raw_int_t )), // none 24 bit
        new MessageInfo(25, "GPS_STATUS", 23, 101, 101, typeof( mavlink_gps_status_t )), // none 24 bit
        new MessageInfo(26, "SCALED_IMU", 170, 22, 22, typeof( mavlink_scaled_imu_t )), // none 24 bit
        new MessageInfo(27, "RAW_IMU", 144, 26, 26, typeof( mavlink_raw_imu_t )), // none 24 bit
        new MessageInfo(28, "RAW_PRESSURE", 67, 16, 16, typeof( mavlink_raw_pressure_t )), // none 24 bit
        new MessageInfo(29, "SCALED_PRESSURE", 115, 14, 14, typeof( mavlink_scaled_pressure_t )), // none 24 bit
        new MessageInfo(30, "ATTITUDE", 39, 28, 28, typeof( mavlink_attitude_t )), // none 24 bit
        new MessageInfo(31, "ATTITUDE_QUATERNION", 246, 32, 32, typeof( mavlink_attitude_quaternion_t )), // none 24 bit
        new MessageInfo(32, "LOCAL_POSITION_NED", 185, 28, 28, typeof( mavlink_local_position_ned_t )), // none 24 bit
        new MessageInfo(33, "GLOBAL_POSITION_INT", 104, 28, 28, typeof( mavlink_global_position_int_t )), // none 24 bit
        new MessageInfo(34, "RC_CHANNELS_SCALED", 237, 22, 22, typeof( mavlink_rc_channels_scaled_t )), // none 24 bit
        new MessageInfo(35, "RC_CHANNELS_RAW", 244, 22, 22, typeof( mavlink_rc_channels_raw_t )), // none 24 bit
        new MessageInfo(36, "SERVO_OUTPUT_RAW", 222, 21, 21, typeof( mavlink_servo_output_raw_t )), // none 24 bit
        new MessageInfo(37, "MISSION_REQUEST_PARTIAL_LIST", 212, 6, 6, typeof( mavlink_mission_request_partial_list_t )), // none 24 bit
        new MessageInfo(38, "MISSION_WRITE_PARTIAL_LIST", 9, 6, 6, typeof( mavlink_mission_write_partial_list_t )), // none 24 bit
        new MessageInfo(39, "MISSION_ITEM", 254, 37, 37, typeof( mavlink_mission_item_t )), // none 24 bit
        new MessageInfo(40, "MISSION_REQUEST", 230, 4, 4, typeof( mavlink_mission_request_t )), // none 24 bit
        new MessageInfo(41, "MISSION_SET_CURRENT", 28, 4, 4, typeof( mavlink_mission_set_current_t )), // none 24 bit
        new MessageInfo(42, "MISSION_CURRENT", 28, 2, 2, typeof( mavlink_mission_current_t )), // none 24 bit
        new MessageInfo(43, "MISSION_REQUEST_LIST", 132, 2, 2, typeof( mavlink_mission_request_list_t )), // none 24 bit
        new MessageInfo(44, "MISSION_COUNT", 221, 4, 4, typeof( mavlink_mission_count_t )), // none 24 bit
        new MessageInfo(45, "MISSION_CLEAR_ALL", 232, 2, 2, typeof( mavlink_mission_clear_all_t )), // none 24 bit
        new MessageInfo(46, "MISSION_ITEM_REACHED", 11, 2, 2, typeof( mavlink_mission_item_reached_t )), // none 24 bit
        new MessageInfo(47, "MISSION_ACK", 153, 3, 3, typeof( mavlink_mission_ack_t )), // none 24 bit
        new MessageInfo(48, "SET_GPS_GLOBAL_ORIGIN", 41, 13, 13, typeof( mavlink_set_gps_global_origin_t )), // none 24 bit
        new MessageInfo(49, "GPS_GLOBAL_ORIGIN", 39, 12, 12, typeof( mavlink_gps_global_origin_t )), // none 24 bit
        new MessageInfo(50, "PARAM_MAP_RC", 78, 37, 37, typeof( mavlink_param_map_rc_t )), // none 24 bit
        new MessageInfo(51, "MISSION_REQUEST_INT", 196, 4, 4, typeof( mavlink_mission_request_int_t )), // none 24 bit
        new MessageInfo(54, "SAFETY_SET_ALLOWED_AREA", 15, 27, 27, typeof( mavlink_safety_set_allowed_area_t )), // none 24 bit
        new MessageInfo(55, "SAFETY_ALLOWED_AREA", 3, 25, 25, typeof( mavlink_safety_allowed_area_t )), // none 24 bit
        new MessageInfo(61, "ATTITUDE_QUATERNION_COV", 167, 72, 72, typeof( mavlink_attitude_quaternion_cov_t )), // none 24 bit
        new MessageInfo(62, "NAV_CONTROLLER_OUTPUT", 183, 26, 26, typeof( mavlink_nav_controller_output_t )), // none 24 bit
        new MessageInfo(63, "GLOBAL_POSITION_INT_COV", 119, 181, 181, typeof( mavlink_global_position_int_cov_t )), // none 24 bit
        new MessageInfo(64, "LOCAL_POSITION_NED_COV", 191, 225, 225, typeof( mavlink_local_position_ned_cov_t )), // none 24 bit
        new MessageInfo(65, "RC_CHANNELS", 118, 42, 42, typeof( mavlink_rc_channels_t )), // none 24 bit
        new MessageInfo(66, "REQUEST_DATA_STREAM", 148, 6, 6, typeof( mavlink_request_data_stream_t )), // none 24 bit
        new MessageInfo(67, "DATA_STREAM", 21, 4, 4, typeof( mavlink_data_stream_t )), // none 24 bit
        new MessageInfo(69, "MANUAL_CONTROL", 243, 11, 11, typeof( mavlink_manual_control_t )), // none 24 bit
        new MessageInfo(70, "RC_CHANNELS_OVERRIDE", 124, 18, 18, typeof( mavlink_rc_channels_override_t )), // none 24 bit
        new MessageInfo(73, "MISSION_ITEM_INT", 38, 37, 37, typeof( mavlink_mission_item_int_t )), // none 24 bit
        new MessageInfo(74, "VFR_HUD", 20, 20, 20, typeof( mavlink_vfr_hud_t )), // none 24 bit
        new MessageInfo(75, "COMMAND_INT", 158, 35, 35, typeof( mavlink_command_int_t )), // none 24 bit
        new MessageInfo(76, "COMMAND_LONG", 152, 33, 33, typeof( mavlink_command_long_t )), // none 24 bit
        new MessageInfo(77, "COMMAND_ACK", 143, 3, 3, typeof( mavlink_command_ack_t )), // none 24 bit
        new MessageInfo(80, "COMMAND_CANCEL", 14, 4, 4, typeof( mavlink_command_cancel_t )), // none 24 bit
        new MessageInfo(81, "MANUAL_SETPOINT", 106, 22, 22, typeof( mavlink_manual_setpoint_t )), // none 24 bit
        new MessageInfo(82, "SET_ATTITUDE_TARGET", 49, 39, 39, typeof( mavlink_set_attitude_target_t )), // none 24 bit
        new MessageInfo(83, "ATTITUDE_TARGET", 22, 37, 37, typeof( mavlink_attitude_target_t )), // none 24 bit
        new MessageInfo(84, "SET_POSITION_TARGET_LOCAL_NED", 143, 53, 53, typeof( mavlink_set_position_target_local_ned_t )), // none 24 bit
        new MessageInfo(85, "POSITION_TARGET_LOCAL_NED", 140, 51, 51, typeof( mavlink_position_target_local_ned_t )), // none 24 bit
        new MessageInfo(86, "SET_POSITION_TARGET_GLOBAL_INT", 5, 53, 53, typeof( mavlink_set_position_target_global_int_t )), // none 24 bit
        new MessageInfo(87, "POSITION_TARGET_GLOBAL_INT", 150, 51, 51, typeof( mavlink_position_target_global_int_t )), // none 24 bit
        new MessageInfo(89, "LOCAL_POSITION_NED_SYSTEM_GLOBAL_OFFSET", 231, 28, 28, typeof( mavlink_local_position_ned_system_global_offset_t )), // none 24 bit
        new MessageInfo(90, "HIL_STATE", 183, 56, 56, typeof( mavlink_hil_state_t )), // none 24 bit
        new MessageInfo(91, "HIL_CONTROLS", 63, 42, 42, typeof( mavlink_hil_controls_t )), // none 24 bit
        new MessageInfo(92, "HIL_RC_INPUTS_RAW", 54, 33, 33, typeof( mavlink_hil_rc_inputs_raw_t )), // none 24 bit
        new MessageInfo(93, "HIL_ACTUATOR_CONTROLS", 47, 81, 81, typeof( mavlink_hil_actuator_controls_t )), // none 24 bit
        new MessageInfo(100, "OPTICAL_FLOW", 175, 26, 26, typeof( mavlink_optical_flow_t )), // none 24 bit
        new MessageInfo(101, "GLOBAL_VISION_POSITION_ESTIMATE", 102, 32, 32, typeof( mavlink_global_vision_position_estimate_t )), // none 24 bit
        new MessageInfo(102, "VISION_POSITION_ESTIMATE", 158, 32, 32, typeof( mavlink_vision_position_estimate_t )), // none 24 bit
        new MessageInfo(103, "VISION_SPEED_ESTIMATE", 208, 20, 20, typeof( mavlink_vision_speed_estimate_t )), // none 24 bit
        new MessageInfo(104, "VICON_POSITION_ESTIMATE", 56, 32, 32, typeof( mavlink_vicon_position_estimate_t )), // none 24 bit
        new MessageInfo(105, "HIGHRES_IMU", 93, 62, 62, typeof( mavlink_highres_imu_t )), // none 24 bit
        new MessageInfo(106, "OPTICAL_FLOW_RAD", 138, 44, 44, typeof( mavlink_optical_flow_rad_t )), // none 24 bit
        new MessageInfo(107, "HIL_SENSOR", 108, 64, 64, typeof( mavlink_hil_sensor_t )), // none 24 bit
        new MessageInfo(108, "SIM_STATE", 32, 84, 84, typeof( mavlink_sim_state_t )), // none 24 bit
        new MessageInfo(109, "RADIO_STATUS", 185, 9, 9, typeof( mavlink_radio_status_t )), // none 24 bit
        new MessageInfo(110, "FILE_TRANSFER_PROTOCOL", 84, 254, 254, typeof( mavlink_file_transfer_protocol_t )), // none 24 bit
        new MessageInfo(111, "TIMESYNC", 34, 16, 16, typeof( mavlink_timesync_t )), // none 24 bit
        new MessageInfo(112, "CAMERA_TRIGGER", 174, 12, 12, typeof( mavlink_camera_trigger_t )), // none 24 bit
        new MessageInfo(113, "HIL_GPS", 124, 36, 36, typeof( mavlink_hil_gps_t )), // none 24 bit
        new MessageInfo(114, "HIL_OPTICAL_FLOW", 237, 44, 44, typeof( mavlink_hil_optical_flow_t )), // none 24 bit
        new MessageInfo(115, "HIL_STATE_QUATERNION", 4, 64, 64, typeof( mavlink_hil_state_quaternion_t )), // none 24 bit
        new MessageInfo(116, "SCALED_IMU2", 76, 22, 22, typeof( mavlink_scaled_imu2_t )), // none 24 bit
        new MessageInfo(117, "LOG_REQUEST_LIST", 128, 6, 6, typeof( mavlink_log_request_list_t )), // none 24 bit
        new MessageInfo(118, "LOG_ENTRY", 56, 14, 14, typeof( mavlink_log_entry_t )), // none 24 bit
        new MessageInfo(119, "LOG_REQUEST_DATA", 116, 12, 12, typeof( mavlink_log_request_data_t )), // none 24 bit
        new MessageInfo(120, "LOG_DATA", 134, 97, 97, typeof( mavlink_log_data_t )), // none 24 bit
        new MessageInfo(121, "LOG_ERASE", 237, 2, 2, typeof( mavlink_log_erase_t )), // none 24 bit
        new MessageInfo(122, "LOG_REQUEST_END", 203, 2, 2, typeof( mavlink_log_request_end_t )), // none 24 bit
        new MessageInfo(123, "GPS_INJECT_DATA", 250, 113, 113, typeof( mavlink_gps_inject_data_t )), // none 24 bit
        new MessageInfo(124, "GPS2_RAW", 87, 35, 35, typeof( mavlink_gps2_raw_t )), // none 24 bit
        new MessageInfo(125, "POWER_STATUS", 203, 6, 6, typeof( mavlink_power_status_t )), // none 24 bit
        new MessageInfo(126, "SERIAL_CONTROL", 220, 79, 79, typeof( mavlink_serial_control_t )), // none 24 bit
        new MessageInfo(127, "GPS_RTK", 25, 35, 35, typeof( mavlink_gps_rtk_t )), // none 24 bit
        new MessageInfo(128, "GPS2_RTK", 226, 35, 35, typeof( mavlink_gps2_rtk_t )), // none 24 bit
        new MessageInfo(129, "SCALED_IMU3", 46, 22, 22, typeof( mavlink_scaled_imu3_t )), // none 24 bit
        new MessageInfo(130, "DATA_TRANSMISSION_HANDSHAKE", 29, 13, 13, typeof( mavlink_data_transmission_handshake_t )), // none 24 bit
        new MessageInfo(131, "ENCAPSULATED_DATA", 223, 255, 255, typeof( mavlink_encapsulated_data_t )), // none 24 bit
        new MessageInfo(132, "DISTANCE_SENSOR", 85, 14, 14, typeof( mavlink_distance_sensor_t )), // none 24 bit
        new MessageInfo(133, "TERRAIN_REQUEST", 6, 18, 18, typeof( mavlink_terrain_request_t )), // none 24 bit
        new MessageInfo(134, "TERRAIN_DATA", 229, 43, 43, typeof( mavlink_terrain_data_t )), // none 24 bit
        new MessageInfo(135, "TERRAIN_CHECK", 203, 8, 8, typeof( mavlink_terrain_check_t )), // none 24 bit
        new MessageInfo(136, "TERRAIN_REPORT", 1, 22, 22, typeof( mavlink_terrain_report_t )), // none 24 bit
        new MessageInfo(137, "SCALED_PRESSURE2", 195, 14, 14, typeof( mavlink_scaled_pressure2_t )), // none 24 bit
        new MessageInfo(138, "ATT_POS_MOCAP", 109, 36, 36, typeof( mavlink_att_pos_mocap_t )), // none 24 bit
        new MessageInfo(139, "SET_ACTUATOR_CONTROL_TARGET", 168, 43, 43, typeof( mavlink_set_actuator_control_target_t )), // none 24 bit
        new MessageInfo(140, "ACTUATOR_CONTROL_TARGET", 181, 41, 41, typeof( mavlink_actuator_control_target_t )), // none 24 bit
        new MessageInfo(141, "ALTITUDE", 47, 32, 32, typeof( mavlink_altitude_t )), // none 24 bit
        new MessageInfo(142, "RESOURCE_REQUEST", 72, 243, 243, typeof( mavlink_resource_request_t )), // none 24 bit
        new MessageInfo(143, "SCALED_PRESSURE3", 131, 14, 14, typeof( mavlink_scaled_pressure3_t )), // none 24 bit
        new MessageInfo(144, "FOLLOW_TARGET", 127, 93, 93, typeof( mavlink_follow_target_t )), // none 24 bit
        new MessageInfo(146, "CONTROL_SYSTEM_STATE", 103, 100, 100, typeof( mavlink_control_system_state_t )), // none 24 bit
        new MessageInfo(147, "BATTERY_STATUS", 154, 36, 36, typeof( mavlink_battery_status_t )), // none 24 bit
        new MessageInfo(148, "AUTOPILOT_VERSION", 178, 60, 60, typeof( mavlink_autopilot_version_t )), // none 24 bit
        new MessageInfo(149, "LANDING_TARGET", 200, 30, 30, typeof( mavlink_landing_target_t )), // none 24 bit
        new MessageInfo(162, "FENCE_STATUS", 189, 8, 8, typeof( mavlink_fence_status_t )), // none 24 bit
        new MessageInfo(170, "CONTROL_SYSTEM", 67, 8, 8, typeof( mavlink_control_system_t )), // none 24 bit
        new MessageInfo(171, "INSTRUMENTATION", 250, 16, 16, typeof( mavlink_instrumentation_t )), // none 24 bit
        new MessageInfo(172, "TEMPERATURES", 192, 12, 12, typeof( mavlink_temperatures_t )), // none 24 bit
        new MessageInfo(173, "GPS_INFO", 182, 17, 17, typeof( mavlink_gps_info_t )), // none 24 bit
        new MessageInfo(174, "AUX_SYSTEM", 28, 12, 12, typeof( mavlink_aux_system_t )), // none 24 bit
        new MessageInfo(192, "MAG_CAL_REPORT", 36, 44, 44, typeof( mavlink_mag_cal_report_t )), // none 24 bit
        new MessageInfo(225, "EFI_STATUS", 208, 65, 65, typeof( mavlink_efi_status_t )), // none 24 bit
        new MessageInfo(230, "ESTIMATOR_STATUS", 163, 42, 42, typeof( mavlink_estimator_status_t )), // none 24 bit
        new MessageInfo(231, "WIND_COV", 105, 40, 40, typeof( mavlink_wind_cov_t )), // none 24 bit
        new MessageInfo(232, "GPS_INPUT", 151, 63, 63, typeof( mavlink_gps_input_t )), // none 24 bit
        new MessageInfo(233, "GPS_RTCM_DATA", 35, 182, 182, typeof( mavlink_gps_rtcm_data_t )), // none 24 bit
        new MessageInfo(234, "HIGH_LATENCY", 150, 40, 40, typeof( mavlink_high_latency_t )), // none 24 bit
        new MessageInfo(235, "HIGH_LATENCY2", 179, 42, 42, typeof( mavlink_high_latency2_t )), // none 24 bit
        new MessageInfo(241, "VIBRATION", 90, 32, 32, typeof( mavlink_vibration_t )), // none 24 bit
        new MessageInfo(242, "HOME_POSITION", 104, 52, 52, typeof( mavlink_home_position_t )), // none 24 bit
        new MessageInfo(243, "SET_HOME_POSITION", 85, 53, 53, typeof( mavlink_set_home_position_t )), // none 24 bit
        new MessageInfo(244, "MESSAGE_INTERVAL", 95, 6, 6, typeof( mavlink_message_interval_t )), // none 24 bit
        new MessageInfo(245, "EXTENDED_SYS_STATE", 130, 2, 2, typeof( mavlink_extended_sys_state_t )), // none 24 bit
        new MessageInfo(246, "ADSB_VEHICLE", 184, 38, 38, typeof( mavlink_adsb_vehicle_t )), // none 24 bit
        new MessageInfo(247, "COLLISION", 81, 19, 19, typeof( mavlink_collision_t )), // none 24 bit
        new MessageInfo(248, "V2_EXTENSION", 8, 254, 254, typeof( mavlink_v2_extension_t )), // none 24 bit
        new MessageInfo(249, "MEMORY_VECT", 204, 36, 36, typeof( mavlink_memory_vect_t )), // none 24 bit
        new MessageInfo(250, "DEBUG_VECT", 49, 30, 30, typeof( mavlink_debug_vect_t )), // none 24 bit
        new MessageInfo(251, "NAMED_VALUE_FLOAT", 170, 18, 18, typeof( mavlink_named_value_float_t )), // none 24 bit
        new MessageInfo(252, "NAMED_VALUE_INT", 44, 18, 18, typeof( mavlink_named_value_int_t )), // none 24 bit
        new MessageInfo(253, "STATUSTEXT", 83, 51, 51, typeof( mavlink_statustext_t )), // none 24 bit
        new MessageInfo(254, "DEBUG", 46, 9, 9, typeof( mavlink_debug_t )), // none 24 bit

    };


    public struct MessageInfo
    {
        public uint MsgID { get; internal set; }
        public string Name { get; internal set; }
        public byte Crc { get; internal set; }
        public uint MinLength { get; internal set; }
        public uint Length { get; internal set; }
        public Type Type { get; internal set; }

        public MessageInfo(uint msgid, string name, byte crc, uint minlength, uint length, Type type)
        {
            this.MsgID = msgid;
            this.Name = name;
            this.Crc = crc;
            this.MinLength = minlength;
            this.Length = length;
            this.Type = type;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}",Name,MsgID);
        }
    }   

    public enum MAVLINK_MSG_ID 
    {

        HEARTBEAT = 0,
        SYS_STATUS = 1,
        SYSTEM_TIME = 2,
        PING = 4,
        CHANGE_OPERATOR_CONTROL = 5,
        CHANGE_OPERATOR_CONTROL_ACK = 6,
        AUTH_KEY = 7,
        LINK_NODE_STATUS = 8,
        SET_MODE = 11,
        PARAM_REQUEST_READ = 20,
        PARAM_REQUEST_LIST = 21,
        PARAM_VALUE = 22,
        PARAM_SET = 23,
        GPS_RAW_INT = 24,
        GPS_STATUS = 25,
        SCALED_IMU = 26,
        RAW_IMU = 27,
        RAW_PRESSURE = 28,
        SCALED_PRESSURE = 29,
        ATTITUDE = 30,
        ATTITUDE_QUATERNION = 31,
        LOCAL_POSITION_NED = 32,
        GLOBAL_POSITION_INT = 33,
        RC_CHANNELS_SCALED = 34,
        RC_CHANNELS_RAW = 35,
        SERVO_OUTPUT_RAW = 36,
        MISSION_REQUEST_PARTIAL_LIST = 37,
        MISSION_WRITE_PARTIAL_LIST = 38,
        MISSION_ITEM = 39,
        MISSION_REQUEST = 40,
        MISSION_SET_CURRENT = 41,
        MISSION_CURRENT = 42,
        MISSION_REQUEST_LIST = 43,
        MISSION_COUNT = 44,
        MISSION_CLEAR_ALL = 45,
        MISSION_ITEM_REACHED = 46,
        MISSION_ACK = 47,
        SET_GPS_GLOBAL_ORIGIN = 48,
        GPS_GLOBAL_ORIGIN = 49,
        PARAM_MAP_RC = 50,
        MISSION_REQUEST_INT = 51,
        SAFETY_SET_ALLOWED_AREA = 54,
        SAFETY_ALLOWED_AREA = 55,
        ATTITUDE_QUATERNION_COV = 61,
        NAV_CONTROLLER_OUTPUT = 62,
        GLOBAL_POSITION_INT_COV = 63,
        LOCAL_POSITION_NED_COV = 64,
        RC_CHANNELS = 65,
        REQUEST_DATA_STREAM = 66,
        DATA_STREAM = 67,
        MANUAL_CONTROL = 69,
        RC_CHANNELS_OVERRIDE = 70,
        MISSION_ITEM_INT = 73,
        VFR_HUD = 74,
        COMMAND_INT = 75,
        COMMAND_LONG = 76,
        COMMAND_ACK = 77,
        COMMAND_CANCEL = 80,
        MANUAL_SETPOINT = 81,
        SET_ATTITUDE_TARGET = 82,
        ATTITUDE_TARGET = 83,
        SET_POSITION_TARGET_LOCAL_NED = 84,
        POSITION_TARGET_LOCAL_NED = 85,
        SET_POSITION_TARGET_GLOBAL_INT = 86,
        POSITION_TARGET_GLOBAL_INT = 87,
        LOCAL_POSITION_NED_SYSTEM_GLOBAL_OFFSET = 89,
        HIL_STATE = 90,
        HIL_CONTROLS = 91,
        HIL_RC_INPUTS_RAW = 92,
        HIL_ACTUATOR_CONTROLS = 93,
        OPTICAL_FLOW = 100,
        GLOBAL_VISION_POSITION_ESTIMATE = 101,
        VISION_POSITION_ESTIMATE = 102,
        VISION_SPEED_ESTIMATE = 103,
        VICON_POSITION_ESTIMATE = 104,
        HIGHRES_IMU = 105,
        OPTICAL_FLOW_RAD = 106,
        HIL_SENSOR = 107,
        SIM_STATE = 108,
        RADIO_STATUS = 109,
        FILE_TRANSFER_PROTOCOL = 110,
        TIMESYNC = 111,
        CAMERA_TRIGGER = 112,
        HIL_GPS = 113,
        HIL_OPTICAL_FLOW = 114,
        HIL_STATE_QUATERNION = 115,
        SCALED_IMU2 = 116,
        LOG_REQUEST_LIST = 117,
        LOG_ENTRY = 118,
        LOG_REQUEST_DATA = 119,
        LOG_DATA = 120,
        LOG_ERASE = 121,
        LOG_REQUEST_END = 122,
        GPS_INJECT_DATA = 123,
        GPS2_RAW = 124,
        POWER_STATUS = 125,
        SERIAL_CONTROL = 126,
        GPS_RTK = 127,
        GPS2_RTK = 128,
        SCALED_IMU3 = 129,
        DATA_TRANSMISSION_HANDSHAKE = 130,
        ENCAPSULATED_DATA = 131,
        DISTANCE_SENSOR = 132,
        TERRAIN_REQUEST = 133,
        TERRAIN_DATA = 134,
        TERRAIN_CHECK = 135,
        TERRAIN_REPORT = 136,
        SCALED_PRESSURE2 = 137,
        ATT_POS_MOCAP = 138,
        SET_ACTUATOR_CONTROL_TARGET = 139,
        ACTUATOR_CONTROL_TARGET = 140,
        ALTITUDE = 141,
        RESOURCE_REQUEST = 142,
        SCALED_PRESSURE3 = 143,
        FOLLOW_TARGET = 144,
        CONTROL_SYSTEM_STATE = 146,
        BATTERY_STATUS = 147,
        AUTOPILOT_VERSION = 148,
        LANDING_TARGET = 149,
        FENCE_STATUS = 162,
        //////////////////// USER DEFINED MAVLINK MESSAGES HERE

        CONTROL_SYSTEM = 170,
        INSTRUMENTATION = 171,
        TEMPERATURES = 172,
        GPS_INFO = 173,
        AUX_SYSTEM = 174,

        //////////////////// USER DEFINED MAVLINK MESSAGES HERE
        MAG_CAL_REPORT = 192,
        EFI_STATUS = 225,
        ESTIMATOR_STATUS = 230,
        WIND_COV = 231,
        GPS_INPUT = 232,
        GPS_RTCM_DATA = 233,
        HIGH_LATENCY = 234,
        HIGH_LATENCY2 = 235,
        VIBRATION = 241,
        HOME_POSITION = 242,
        SET_HOME_POSITION = 243,
        MESSAGE_INTERVAL = 244,
        EXTENDED_SYS_STATE = 245,
        ADSB_VEHICLE = 246,
        COLLISION = 247,
        V2_EXTENSION = 248,
        MEMORY_VECT = 249,
        DEBUG_VECT = 250,
        NAMED_VALUE_FLOAT = 251,
        NAMED_VALUE_INT = 252,
        STATUSTEXT = 253,
        DEBUG = 254,
    }
    
    
    ///<summary> These values define the type of firmware release.  These values indicate the first version or release of this type.  For example the first alpha release would be 64, the second would be 65. </summary>
    public enum FIRMWARE_VERSION_TYPE: int /*default*/
    {
        ///<summary> development release | </summary>
        [Description("development release")]
        DEV=0, 
        ///<summary> alpha release | </summary>
        [Description("alpha release")]
        ALPHA=64, 
        ///<summary> beta release | </summary>
        [Description("beta release")]
        BETA=128, 
        ///<summary> release candidate | </summary>
        [Description("release candidate")]
        RC=192, 
        ///<summary> official stable release | </summary>
        [Description("official stable release")]
        OFFICIAL=255, 
        
    };
    
    ///<summary> Flags to report failure cases over the high latency telemtry. </summary>
    public enum HL_FAILURE_FLAG: ushort
    {
        ///<summary> GPS failure. | </summary>
        [Description("GPS failure.")]
        GPS=1, 
        ///<summary> Differential pressure sensor failure. | </summary>
        [Description("Differential pressure sensor failure.")]
        DIFFERENTIAL_PRESSURE=2, 
        ///<summary> Absolute pressure sensor failure. | </summary>
        [Description("Absolute pressure sensor failure.")]
        ABSOLUTE_PRESSURE=4, 
        ///<summary> Accelerometer sensor failure. | </summary>
        [Description("Accelerometer sensor failure.")]
        _3D_ACCEL=8, 
        ///<summary> Gyroscope sensor failure. | </summary>
        [Description("Gyroscope sensor failure.")]
        _3D_GYRO=16, 
        ///<summary> Magnetometer sensor failure. | </summary>
        [Description("Magnetometer sensor failure.")]
        _3D_MAG=32, 
        ///<summary> Terrain subsystem failure. | </summary>
        [Description("Terrain subsystem failure.")]
        TERRAIN=64, 
        ///<summary> Battery failure/critical low battery. | </summary>
        [Description("Battery failure/critical low battery.")]
        BATTERY=128, 
        ///<summary> RC receiver failure/no rc connection. | </summary>
        [Description("RC receiver failure/no rc connection.")]
        RC_RECEIVER=256, 
        ///<summary> Offboard link failure. | </summary>
        [Description("Offboard link failure.")]
        OFFBOARD_LINK=512, 
        ///<summary> Engine failure. | </summary>
        [Description("Engine failure.")]
        ENGINE=1024, 
        ///<summary> Geofence violation. | </summary>
        [Description("Geofence violation.")]
        GEOFENCE=2048, 
        ///<summary> Estimator failure, for example measurement rejection or large variances. | </summary>
        [Description("Estimator failure, for example measurement rejection or large variances.")]
        ESTIMATOR=4096, 
        ///<summary> Mission failure. | </summary>
        [Description("Mission failure.")]
        MISSION=8192, 
        
    };
    
    ///<summary> Actions that may be specified in MAV_CMD_OVERRIDE_GOTO to override mission execution. </summary>
    public enum MAV_GOTO: int /*default*/
    {
        ///<summary> Hold at the current position. | </summary>
        [Description("Hold at the current position.")]
        DO_HOLD=0, 
        ///<summary> Continue with the next item in mission execution. | </summary>
        [Description("Continue with the next item in mission execution.")]
        DO_CONTINUE=1, 
        ///<summary> Hold at the current position of the system | </summary>
        [Description("Hold at the current position of the system")]
        HOLD_AT_CURRENT_POSITION=2, 
        ///<summary> Hold at the position specified in the parameters of the DO_HOLD action | </summary>
        [Description("Hold at the position specified in the parameters of the DO_HOLD action")]
        HOLD_AT_SPECIFIED_POSITION=3, 
        
    };
    
    ///<summary> These defines are predefined OR-combined mode flags. There is no need to use values from this enum, but it                simplifies the use of the mode flags. Note that manual input is enabled in all modes as a safety override. </summary>
    public enum MAV_MODE: byte
    {
        ///<summary> System is not ready to fly, booting, calibrating, etc. No flag is set. | </summary>
        [Description("System is not ready to fly, booting, calibrating, etc. No flag is set.")]
        PREFLIGHT=0, 
        ///<summary> System is allowed to be active, under manual (RC) control, no stabilization | </summary>
        [Description("System is allowed to be active, under manual (RC) control, no stabilization")]
        MANUAL_DISARMED=64, 
        ///<summary> UNDEFINED mode. This solely depends on the autopilot - use with caution, intended for developers only. | </summary>
        [Description("UNDEFINED mode. This solely depends on the autopilot - use with caution, intended for developers only.")]
        TEST_DISARMED=66, 
        ///<summary> System is allowed to be active, under assisted RC control. | </summary>
        [Description("System is allowed to be active, under assisted RC control.")]
        STABILIZE_DISARMED=80, 
        ///<summary> System is allowed to be active, under autonomous control, manual setpoint | </summary>
        [Description("System is allowed to be active, under autonomous control, manual setpoint")]
        GUIDED_DISARMED=88, 
        ///<summary> System is allowed to be active, under autonomous control and navigation (the trajectory is decided onboard and not pre-programmed by waypoints) | </summary>
        [Description("System is allowed to be active, under autonomous control and navigation (the trajectory is decided onboard and not pre-programmed by waypoints)")]
        AUTO_DISARMED=92, 
        ///<summary> System is allowed to be active, under manual (RC) control, no stabilization | </summary>
        [Description("System is allowed to be active, under manual (RC) control, no stabilization")]
        MANUAL_ARMED=192, 
        ///<summary> UNDEFINED mode. This solely depends on the autopilot - use with caution, intended for developers only. | </summary>
        [Description("UNDEFINED mode. This solely depends on the autopilot - use with caution, intended for developers only.")]
        TEST_ARMED=194, 
        ///<summary> System is allowed to be active, under assisted RC control. | </summary>
        [Description("System is allowed to be active, under assisted RC control.")]
        STABILIZE_ARMED=208, 
        ///<summary> System is allowed to be active, under autonomous control, manual setpoint | </summary>
        [Description("System is allowed to be active, under autonomous control, manual setpoint")]
        GUIDED_ARMED=216, 
        ///<summary> System is allowed to be active, under autonomous control and navigation (the trajectory is decided onboard and not pre-programmed by waypoints) | </summary>
        [Description("System is allowed to be active, under autonomous control and navigation (the trajectory is decided onboard and not pre-programmed by waypoints)")]
        AUTO_ARMED=220, 
        
    };
    
    ///<summary> These encode the sensors whose status is sent as part of the SYS_STATUS message. </summary>
    public enum MAV_SYS_STATUS_SENSOR: uint
    {
        ///<summary> 0x01 3D gyro | </summary>
        [Description("0x01 3D gyro")]
        _3D_GYRO=1, 
        ///<summary> 0x02 3D accelerometer | </summary>
        [Description("0x02 3D accelerometer")]
        _3D_ACCEL=2, 
        ///<summary> 0x04 3D magnetometer | </summary>
        [Description("0x04 3D magnetometer")]
        _3D_MAG=4, 
        ///<summary> 0x08 absolute pressure | </summary>
        [Description("0x08 absolute pressure")]
        ABSOLUTE_PRESSURE=8, 
        ///<summary> 0x10 differential pressure | </summary>
        [Description("0x10 differential pressure")]
        DIFFERENTIAL_PRESSURE=16, 
        ///<summary> 0x20 GPS | </summary>
        [Description("0x20 GPS")]
        GPS=32, 
        ///<summary> 0x40 optical flow | </summary>
        [Description("0x40 optical flow")]
        OPTICAL_FLOW=64, 
        ///<summary> 0x80 computer vision position | </summary>
        [Description("0x80 computer vision position")]
        VISION_POSITION=128, 
        ///<summary> 0x100 laser based position | </summary>
        [Description("0x100 laser based position")]
        LASER_POSITION=256, 
        ///<summary> 0x200 external ground truth (Vicon or Leica) | </summary>
        [Description("0x200 external ground truth (Vicon or Leica)")]
        EXTERNAL_GROUND_TRUTH=512, 
        ///<summary> 0x400 3D angular rate control | </summary>
        [Description("0x400 3D angular rate control")]
        ANGULAR_RATE_CONTROL=1024, 
        ///<summary> 0x800 attitude stabilization | </summary>
        [Description("0x800 attitude stabilization")]
        ATTITUDE_STABILIZATION=2048, 
        ///<summary> 0x1000 yaw position | </summary>
        [Description("0x1000 yaw position")]
        YAW_POSITION=4096, 
        ///<summary> 0x2000 z/altitude control | </summary>
        [Description("0x2000 z/altitude control")]
        Z_ALTITUDE_CONTROL=8192, 
        ///<summary> 0x4000 x/y position control | </summary>
        [Description("0x4000 x/y position control")]
        XY_POSITION_CONTROL=16384, 
        ///<summary> 0x8000 motor outputs / control | </summary>
        [Description("0x8000 motor outputs / control")]
        MOTOR_OUTPUTS=32768, 
        ///<summary> 0x10000 rc receiver | </summary>
        [Description("0x10000 rc receiver")]
        RC_RECEIVER=65536, 
        ///<summary> 0x20000 2nd 3D gyro | </summary>
        [Description("0x20000 2nd 3D gyro")]
        _3D_GYRO2=131072, 
        ///<summary> 0x40000 2nd 3D accelerometer | </summary>
        [Description("0x40000 2nd 3D accelerometer")]
        _3D_ACCEL2=262144, 
        ///<summary> 0x80000 2nd 3D magnetometer | </summary>
        [Description("0x80000 2nd 3D magnetometer")]
        _3D_MAG2=524288, 
        ///<summary> 0x100000 geofence | </summary>
        [Description("0x100000 geofence")]
        MAV_SYS_STATUS_GEOFENCE=1048576, 
        ///<summary> 0x200000 AHRS subsystem health | </summary>
        [Description("0x200000 AHRS subsystem health")]
        MAV_SYS_STATUS_AHRS=2097152, 
        ///<summary> 0x400000 Terrain subsystem health | </summary>
        [Description("0x400000 Terrain subsystem health")]
        MAV_SYS_STATUS_TERRAIN=4194304, 
        ///<summary> 0x800000 Motors are reversed | </summary>
        [Description("0x800000 Motors are reversed")]
        MAV_SYS_STATUS_REVERSE_MOTOR=8388608, 
        ///<summary> 0x1000000 Logging | </summary>
        [Description("0x1000000 Logging")]
        MAV_SYS_STATUS_LOGGING=16777216, 
        ///<summary> 0x2000000 Battery | </summary>
        [Description("0x2000000 Battery")]
        BATTERY=33554432, 
        ///<summary> 0x4000000 Proximity | </summary>
        [Description("0x4000000 Proximity")]
        PROXIMITY=67108864, 
        ///<summary> 0x8000000 Satellite Communication  | </summary>
        [Description("0x8000000 Satellite Communication ")]
        SATCOM=134217728, 
        ///<summary> 0x10000000 pre-arm check status. Always healthy when armed | </summary>
        [Description("0x10000000 pre-arm check status. Always healthy when armed")]
        MAV_SYS_STATUS_PREARM_CHECK=268435456, 
        ///<summary> 0x20000000 Avoidance/collision prevention | </summary>
        [Description("0x20000000 Avoidance/collision prevention")]
        MAV_SYS_STATUS_OBSTACLE_AVOIDANCE=536870912, 
        ///<summary> 0x40000000 propulsion (actuator, esc, motor or propellor) | </summary>
        [Description("0x40000000 propulsion (actuator, esc, motor or propellor)")]
        PROPULSION=1073741824, 
        ///<summary> 0x80000000 Extended bit-field are used for further sensor status bits (needs to be set in onboard_control_sensors_present only) | </summary>
        [Description("0x80000000 Extended bit-field are used for further sensor status bits (needs to be set in onboard_control_sensors_present only)")]
        MAV_SYS_STATUS_EXTENSION_USED=2147483648, 
        
    };
    
    ///<summary> These encode the sensors whose status is sent as part of the SYS_STATUS message in the extended fields. </summary>
    public enum MAV_SYS_STATUS_SENSOR_EXTENDED: int /*default*/
    {
        ///<summary> 0x01 Recovery system (parachute, balloon, retracts etc) | </summary>
        [Description("0x01 Recovery system (parachute, balloon, retracts etc)")]
        MAV_SYS_STATUS_RECOVERY_SYSTEM=1, 
        
    };
    
    ///<summary> Coordinate frames used by MAVLink. Not all frames are supported by all commands, messages, or vehicles.        Global frames use the following naming conventions:       - 'GLOBAL': Global coordinate frame with WGS84 latitude/longitude and altitude positive over mean sea level (MSL) by default.         The following modifiers may be used with 'GLOBAL':         - 'RELATIVE_ALT': Altitude is relative to the vehicle home position rather than MSL.         - 'TERRAIN_ALT': Altitude is relative to ground level rather than MSL.         - 'INT': Latitude/longitude (in degrees) are scaled by multiplying by 1E7.        Local frames use the following naming conventions:       - 'LOCAL': Origin of local frame is fixed relative to earth. Unless otherwise specified this origin is the origin of the vehicle position-estimator ('EKF').       - 'BODY': Origin of local frame travels with the vehicle. NOTE, 'BODY' does NOT indicate alignment of frame axis with vehicle attitude.       - 'OFFSET': Deprecated synonym for 'BODY' (origin travels with the vehicle). Not to be used for new frames.        Some deprecated frames do not follow these conventions (e.g. MAV_FRAME_BODY_NED and MAV_FRAME_BODY_OFFSET_NED).   </summary>
    public enum MAV_FRAME: byte
    {
        ///<summary> Global (WGS84) coordinate frame + MSL altitude. First value / x: latitude, second value / y: longitude, third value / z: positive altitude over mean sea level (MSL). | </summary>
        [Description("Global (WGS84) coordinate frame + MSL altitude. First value / x: latitude, second value / y: longitude, third value / z: positive altitude over mean sea level (MSL).")]
        GLOBAL=0, 
        ///<summary> NED local tangent frame (x: North, y: East, z: Down) with origin fixed relative to earth. | </summary>
        [Description("NED local tangent frame (x: North, y: East, z: Down) with origin fixed relative to earth.")]
        LOCAL_NED=1, 
        ///<summary> NOT a coordinate frame, indicates a mission command. | </summary>
        [Description("NOT a coordinate frame, indicates a mission command.")]
        MISSION=2, 
        ///<summary>            Global (WGS84) coordinate frame + altitude relative to the home position.           First value / x: latitude, second value / y: longitude, third value / z: positive altitude with 0 being at the altitude of the home position.          | </summary>
        [Description("           Global (WGS84) coordinate frame + altitude relative to the home position.           First value / x: latitude, second value / y: longitude, third value / z: positive altitude with 0 being at the altitude of the home position.         ")]
        GLOBAL_RELATIVE_ALT=3, 
        ///<summary> ENU local tangent frame (x: East, y: North, z: Up) with origin fixed relative to earth. | </summary>
        [Description("ENU local tangent frame (x: East, y: North, z: Up) with origin fixed relative to earth.")]
        LOCAL_ENU=4, 
        ///<summary> Global (WGS84) coordinate frame (scaled) + MSL altitude. First value / x: latitude in degrees*1E7, second value / y: longitude in degrees*1E7, third value / z: positive altitude over mean sea level (MSL). | </summary>
        [Description("Global (WGS84) coordinate frame (scaled) + MSL altitude. First value / x: latitude in degrees*1E7, second value / y: longitude in degrees*1E7, third value / z: positive altitude over mean sea level (MSL).")]
        GLOBAL_INT=5, 
        ///<summary>            Global (WGS84) coordinate frame (scaled) + altitude relative to the home position.           First value / x: latitude in degrees*1E7, second value / y: longitude in degrees*1E7, third value / z: positive altitude with 0 being at the altitude of the home position.          | </summary>
        [Description("           Global (WGS84) coordinate frame (scaled) + altitude relative to the home position.           First value / x: latitude in degrees*1E7, second value / y: longitude in degrees*1E7, third value / z: positive altitude with 0 being at the altitude of the home position.         ")]
        GLOBAL_RELATIVE_ALT_INT=6, 
        ///<summary> NED local tangent frame (x: North, y: East, z: Down) with origin that travels with the vehicle. | </summary>
        [Description("NED local tangent frame (x: North, y: East, z: Down) with origin that travels with the vehicle.")]
        LOCAL_OFFSET_NED=7, 
        ///<summary> Same as MAV_FRAME_LOCAL_NED when used to represent position values. Same as MAV_FRAME_BODY_FRD when used with velocity/acceleration values. | </summary>
        [Description("Same as MAV_FRAME_LOCAL_NED when used to represent position values. Same as MAV_FRAME_BODY_FRD when used with velocity/acceleration values.")]
        BODY_NED=8, 
        ///<summary> This is the same as MAV_FRAME_BODY_FRD. | </summary>
        [Description("This is the same as MAV_FRAME_BODY_FRD.")]
        BODY_OFFSET_NED=9, 
        ///<summary> Global (WGS84) coordinate frame with AGL altitude (at the waypoint coordinate). First value / x: latitude in degrees, second value / y: longitude in degrees, third value / z: positive altitude in meters with 0 being at ground level in terrain model. | </summary>
        [Description("Global (WGS84) coordinate frame with AGL altitude (at the waypoint coordinate). First value / x: latitude in degrees, second value / y: longitude in degrees, third value / z: positive altitude in meters with 0 being at ground level in terrain model.")]
        GLOBAL_TERRAIN_ALT=10, 
        ///<summary> Global (WGS84) coordinate frame (scaled) with AGL altitude (at the waypoint coordinate). First value / x: latitude in degrees*1E7, second value / y: longitude in degrees*1E7, third value / z: positive altitude in meters with 0 being at ground level in terrain model. | </summary>
        [Description("Global (WGS84) coordinate frame (scaled) with AGL altitude (at the waypoint coordinate). First value / x: latitude in degrees*1E7, second value / y: longitude in degrees*1E7, third value / z: positive altitude in meters with 0 being at ground level in terrain model.")]
        GLOBAL_TERRAIN_ALT_INT=11, 
        ///<summary> FRD local frame aligned to the vehicle's attitude (x: Forward, y: Right, z: Down) with an origin that travels with vehicle. | </summary>
        [Description("FRD local frame aligned to the vehicle's attitude (x: Forward, y: Right, z: Down) with an origin that travels with vehicle.")]
        BODY_FRD=12, 
        ///<summary> MAV_FRAME_BODY_FLU - Body fixed frame of reference, Z-up (x: Forward, y: Left, z: Up). | </summary>
        [Description("MAV_FRAME_BODY_FLU - Body fixed frame of reference, Z-up (x: Forward, y: Left, z: Up).")]
        RESERVED_13=13, 
        ///<summary> MAV_FRAME_MOCAP_NED - Odometry local coordinate frame of data given by a motion capture system, Z-down (x: North, y: East, z: Down). | </summary>
        [Description("MAV_FRAME_MOCAP_NED - Odometry local coordinate frame of data given by a motion capture system, Z-down (x: North, y: East, z: Down).")]
        RESERVED_14=14, 
        ///<summary> MAV_FRAME_MOCAP_ENU - Odometry local coordinate frame of data given by a motion capture system, Z-up (x: East, y: North, z: Up). | </summary>
        [Description("MAV_FRAME_MOCAP_ENU - Odometry local coordinate frame of data given by a motion capture system, Z-up (x: East, y: North, z: Up).")]
        RESERVED_15=15, 
        ///<summary> MAV_FRAME_VISION_NED - Odometry local coordinate frame of data given by a vision estimation system, Z-down (x: North, y: East, z: Down). | </summary>
        [Description("MAV_FRAME_VISION_NED - Odometry local coordinate frame of data given by a vision estimation system, Z-down (x: North, y: East, z: Down).")]
        RESERVED_16=16, 
        ///<summary> MAV_FRAME_VISION_ENU - Odometry local coordinate frame of data given by a vision estimation system, Z-up (x: East, y: North, z: Up). | </summary>
        [Description("MAV_FRAME_VISION_ENU - Odometry local coordinate frame of data given by a vision estimation system, Z-up (x: East, y: North, z: Up).")]
        RESERVED_17=17, 
        ///<summary> MAV_FRAME_ESTIM_NED - Odometry local coordinate frame of data given by an estimator running onboard the vehicle, Z-down (x: North, y: East, z: Down). | </summary>
        [Description("MAV_FRAME_ESTIM_NED - Odometry local coordinate frame of data given by an estimator running onboard the vehicle, Z-down (x: North, y: East, z: Down).")]
        RESERVED_18=18, 
        ///<summary> MAV_FRAME_ESTIM_ENU - Odometry local coordinate frame of data given by an estimator running onboard the vehicle, Z-up (x: East, y: North, z: Up). | </summary>
        [Description("MAV_FRAME_ESTIM_ENU - Odometry local coordinate frame of data given by an estimator running onboard the vehicle, Z-up (x: East, y: North, z: Up).")]
        RESERVED_19=19, 
        ///<summary> FRD local tangent frame (x: Forward, y: Right, z: Down) with origin fixed relative to earth. The forward axis is aligned to the front of the vehicle in the horizontal plane. | </summary>
        [Description("FRD local tangent frame (x: Forward, y: Right, z: Down) with origin fixed relative to earth. The forward axis is aligned to the front of the vehicle in the horizontal plane.")]
        LOCAL_FRD=20, 
        ///<summary> FLU local tangent frame (x: Forward, y: Left, z: Up) with origin fixed relative to earth. The forward axis is aligned to the front of the vehicle in the horizontal plane. | </summary>
        [Description("FLU local tangent frame (x: Forward, y: Left, z: Up) with origin fixed relative to earth. The forward axis is aligned to the front of the vehicle in the horizontal plane.")]
        LOCAL_FLU=21, 
        
    };
    
    ///<summary>  </summary>
    public enum MAVLINK_DATA_STREAM_TYPE: byte
    {
        ///<summary>  | </summary>
        [Description("")]
        MAVLINK_DATA_STREAM_IMG_JPEG=0, 
        ///<summary>  | </summary>
        [Description("")]
        MAVLINK_DATA_STREAM_IMG_BMP=1, 
        ///<summary>  | </summary>
        [Description("")]
        MAVLINK_DATA_STREAM_IMG_RAW8U=2, 
        ///<summary>  | </summary>
        [Description("")]
        MAVLINK_DATA_STREAM_IMG_RAW32U=3, 
        ///<summary>  | </summary>
        [Description("")]
        MAVLINK_DATA_STREAM_IMG_PGM=4, 
        ///<summary>  | </summary>
        [Description("")]
        MAVLINK_DATA_STREAM_IMG_PNG=5, 
        
    };
    
    ///<summary> Actions following geofence breach. </summary>
    public enum FENCE_ACTION: int /*default*/
    {
        ///<summary> Disable fenced mode. If used in a plan this would mean the next fence is disabled. | </summary>
        [Description("Disable fenced mode. If used in a plan this would mean the next fence is disabled.")]
        NONE=0, 
        ///<summary> Fly to geofence MAV_CMD_NAV_FENCE_RETURN_POINT in GUIDED mode. Note: This action is only supported by ArduPlane, and may not be supported in all versions. | </summary>
        [Description("Fly to geofence MAV_CMD_NAV_FENCE_RETURN_POINT in GUIDED mode. Note: This action is only supported by ArduPlane, and may not be supported in all versions.")]
        GUIDED=1, 
        ///<summary> Report fence breach, but don't take action | </summary>
        [Description("Report fence breach, but don't take action")]
        REPORT=2, 
        ///<summary> Fly to geofence MAV_CMD_NAV_FENCE_RETURN_POINT with manual throttle control in GUIDED mode. Note: This action is only supported by ArduPlane, and may not be supported in all versions. | </summary>
        [Description("Fly to geofence MAV_CMD_NAV_FENCE_RETURN_POINT with manual throttle control in GUIDED mode. Note: This action is only supported by ArduPlane, and may not be supported in all versions.")]
        GUIDED_THR_PASS=3, 
        ///<summary> Return/RTL mode. | </summary>
        [Description("Return/RTL mode.")]
        RTL=4, 
        ///<summary> Hold at current location. | </summary>
        [Description("Hold at current location.")]
        HOLD=5, 
        ///<summary> Termination failsafe. Motors are shut down (some flight stacks may trigger other failsafe actions). | </summary>
        [Description("Termination failsafe. Motors are shut down (some flight stacks may trigger other failsafe actions).")]
        TERMINATE=6, 
        ///<summary> Land at current location. | </summary>
        [Description("Land at current location.")]
        LAND=7, 
        
    };
    
    ///<summary>  </summary>
    public enum FENCE_BREACH: byte
    {
        ///<summary> No last fence breach | </summary>
        [Description("No last fence breach")]
        NONE=0, 
        ///<summary> Breached minimum altitude | </summary>
        [Description("Breached minimum altitude")]
        MINALT=1, 
        ///<summary> Breached maximum altitude | </summary>
        [Description("Breached maximum altitude")]
        MAXALT=2, 
        ///<summary> Breached fence boundary | </summary>
        [Description("Breached fence boundary")]
        BOUNDARY=3, 
        
    };
    
    ///<summary> Actions being taken to mitigate/prevent fence breach </summary>
    public enum FENCE_MITIGATE: int /*default*/
    {
        ///<summary> Unknown | </summary>
        [Description("Unknown")]
        UNKNOWN=0, 
        ///<summary> No actions being taken | </summary>
        [Description("No actions being taken")]
        NONE=1, 
        ///<summary> Velocity limiting active to prevent breach | </summary>
        [Description("Velocity limiting active to prevent breach")]
        VEL_LIMIT=2, 
        
    };
    
    ///<summary> Enumeration of possible mount operation modes. This message is used by obsolete/deprecated gimbal messages. </summary>
    public enum MAV_MOUNT_MODE: int /*default*/
    {
        ///<summary> Load and keep safe position (Roll,Pitch,Yaw) from permant memory and stop stabilization | </summary>
        [Description("Load and keep safe position (Roll,Pitch,Yaw) from permant memory and stop stabilization")]
        RETRACT=0, 
        ///<summary> Load and keep neutral position (Roll,Pitch,Yaw) from permanent memory. | </summary>
        [Description("Load and keep neutral position (Roll,Pitch,Yaw) from permanent memory.")]
        NEUTRAL=1, 
        ///<summary> Load neutral position and start MAVLink Roll,Pitch,Yaw control with stabilization | </summary>
        [Description("Load neutral position and start MAVLink Roll,Pitch,Yaw control with stabilization")]
        MAVLINK_TARGETING=2, 
        ///<summary> Load neutral position and start RC Roll,Pitch,Yaw control with stabilization | </summary>
        [Description("Load neutral position and start RC Roll,Pitch,Yaw control with stabilization")]
        RC_TARGETING=3, 
        ///<summary> Load neutral position and start to point to Lat,Lon,Alt | </summary>
        [Description("Load neutral position and start to point to Lat,Lon,Alt")]
        GPS_POINT=4, 
        ///<summary> Gimbal tracks system with specified system ID | </summary>
        [Description("Gimbal tracks system with specified system ID")]
        SYSID_TARGET=5, 
        ///<summary> Gimbal tracks home position | </summary>
        [Description("Gimbal tracks home position")]
        HOME_LOCATION=6, 
        
    };
    
    ///<summary> Gimbal device (low level) capability flags (bitmap). </summary>
    [Flags]
	public enum GIMBAL_DEVICE_CAP_FLAGS: int /*default*/
    {
        ///<summary> Gimbal device supports a retracted position. | </summary>
        [Description("Gimbal device supports a retracted position.")]
        HAS_RETRACT=1, 
        ///<summary> Gimbal device supports a horizontal, forward looking position, stabilized. | </summary>
        [Description("Gimbal device supports a horizontal, forward looking position, stabilized.")]
        HAS_NEUTRAL=2, 
        ///<summary> Gimbal device supports rotating around roll axis. | </summary>
        [Description("Gimbal device supports rotating around roll axis.")]
        HAS_ROLL_AXIS=4, 
        ///<summary> Gimbal device supports to follow a roll angle relative to the vehicle. | </summary>
        [Description("Gimbal device supports to follow a roll angle relative to the vehicle.")]
        HAS_ROLL_FOLLOW=8, 
        ///<summary> Gimbal device supports locking to a roll angle (generally that's the default with roll stabilized). | </summary>
        [Description("Gimbal device supports locking to a roll angle (generally that's the default with roll stabilized).")]
        HAS_ROLL_LOCK=16, 
        ///<summary> Gimbal device supports rotating around pitch axis. | </summary>
        [Description("Gimbal device supports rotating around pitch axis.")]
        HAS_PITCH_AXIS=32, 
        ///<summary> Gimbal device supports to follow a pitch angle relative to the vehicle. | </summary>
        [Description("Gimbal device supports to follow a pitch angle relative to the vehicle.")]
        HAS_PITCH_FOLLOW=64, 
        ///<summary> Gimbal device supports locking to a pitch angle (generally that's the default with pitch stabilized). | </summary>
        [Description("Gimbal device supports locking to a pitch angle (generally that's the default with pitch stabilized).")]
        HAS_PITCH_LOCK=128, 
        ///<summary> Gimbal device supports rotating around yaw axis. | </summary>
        [Description("Gimbal device supports rotating around yaw axis.")]
        HAS_YAW_AXIS=256, 
        ///<summary> Gimbal device supports to follow a yaw angle relative to the vehicle (generally that's the default). | </summary>
        [Description("Gimbal device supports to follow a yaw angle relative to the vehicle (generally that's the default).")]
        HAS_YAW_FOLLOW=512, 
        ///<summary> Gimbal device supports locking to an absolute heading, i.e., yaw angle relative to North (earth frame, often this is an option available). | </summary>
        [Description("Gimbal device supports locking to an absolute heading, i.e., yaw angle relative to North (earth frame, often this is an option available).")]
        HAS_YAW_LOCK=1024, 
        ///<summary> Gimbal device supports yawing/panning infinetely (e.g. using slip disk). | </summary>
        [Description("Gimbal device supports yawing/panning infinetely (e.g. using slip disk).")]
        SUPPORTS_INFINITE_YAW=2048, 
        ///<summary> Gimbal device supports yaw angles and angular velocities relative to North (earth frame). This usually requires support by an autopilot via AUTOPILOT_STATE_FOR_GIMBAL_DEVICE. Support can go on and off during runtime, which is reported by the flag GIMBAL_DEVICE_FLAGS_CAN_ACCEPT_YAW_IN_EARTH_FRAME. | </summary>
        [Description("Gimbal device supports yaw angles and angular velocities relative to North (earth frame). This usually requires support by an autopilot via AUTOPILOT_STATE_FOR_GIMBAL_DEVICE. Support can go on and off during runtime, which is reported by the flag GIMBAL_DEVICE_FLAGS_CAN_ACCEPT_YAW_IN_EARTH_FRAME.")]
        SUPPORTS_YAW_IN_EARTH_FRAME=4096, 
        ///<summary> Gimbal device supports radio control inputs as an alternative input for controlling the gimbal orientation. | </summary>
        [Description("Gimbal device supports radio control inputs as an alternative input for controlling the gimbal orientation.")]
        HAS_RC_INPUTS=8192, 
        
    };
    
    ///<summary> Gimbal manager high level capability flags (bitmap). The first 16 bits are identical to the GIMBAL_DEVICE_CAP_FLAGS. However, the gimbal manager does not need to copy the flags from the gimbal but can also enhance the capabilities and thus add flags. </summary>
    [Flags]
	public enum GIMBAL_MANAGER_CAP_FLAGS: int /*default*/
    {
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_RETRACT. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_RETRACT.")]
        HAS_RETRACT=1, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_NEUTRAL. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_NEUTRAL.")]
        HAS_NEUTRAL=2, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_ROLL_AXIS. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_ROLL_AXIS.")]
        HAS_ROLL_AXIS=4, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_ROLL_FOLLOW. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_ROLL_FOLLOW.")]
        HAS_ROLL_FOLLOW=8, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_ROLL_LOCK. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_ROLL_LOCK.")]
        HAS_ROLL_LOCK=16, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_PITCH_AXIS. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_PITCH_AXIS.")]
        HAS_PITCH_AXIS=32, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_PITCH_FOLLOW. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_PITCH_FOLLOW.")]
        HAS_PITCH_FOLLOW=64, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_PITCH_LOCK. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_PITCH_LOCK.")]
        HAS_PITCH_LOCK=128, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_YAW_AXIS. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_YAW_AXIS.")]
        HAS_YAW_AXIS=256, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_YAW_FOLLOW. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_YAW_FOLLOW.")]
        HAS_YAW_FOLLOW=512, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_YAW_LOCK. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_YAW_LOCK.")]
        HAS_YAW_LOCK=1024, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_SUPPORTS_INFINITE_YAW. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_SUPPORTS_INFINITE_YAW.")]
        SUPPORTS_INFINITE_YAW=2048, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_SUPPORTS_YAW_IN_EARTH_FRAME. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_SUPPORTS_YAW_IN_EARTH_FRAME.")]
        SUPPORTS_YAW_IN_EARTH_FRAME=4096, 
        ///<summary> Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_RC_INPUTS. | </summary>
        [Description("Based on GIMBAL_DEVICE_CAP_FLAGS_HAS_RC_INPUTS.")]
        HAS_RC_INPUTS=8192, 
        ///<summary> Gimbal manager supports to point to a local position. | </summary>
        [Description("Gimbal manager supports to point to a local position.")]
        CAN_POINT_LOCATION_LOCAL=65536, 
        ///<summary> Gimbal manager supports to point to a global latitude, longitude, altitude position. | </summary>
        [Description("Gimbal manager supports to point to a global latitude, longitude, altitude position.")]
        CAN_POINT_LOCATION_GLOBAL=131072, 
        
    };
    
    ///<summary> Flags for gimbal device (lower level) operation. </summary>
    [Flags]
	public enum GIMBAL_DEVICE_FLAGS: int /*default*/
    {
        ///<summary> Set to retracted safe position (no stabilization), takes presedence over all other flags. | </summary>
        [Description("Set to retracted safe position (no stabilization), takes presedence over all other flags.")]
        RETRACT=1, 
        ///<summary> Set to neutral/default position, taking precedence over all other flags except RETRACT. Neutral is commonly forward-facing and horizontal (roll=pitch=yaw=0) but may be any orientation. | </summary>
        [Description("Set to neutral/default position, taking precedence over all other flags except RETRACT. Neutral is commonly forward-facing and horizontal (roll=pitch=yaw=0) but may be any orientation.")]
        NEUTRAL=2, 
        ///<summary> Lock roll angle to absolute angle relative to horizon (not relative to vehicle). This is generally the default with a stabilizing gimbal. | </summary>
        [Description("Lock roll angle to absolute angle relative to horizon (not relative to vehicle). This is generally the default with a stabilizing gimbal.")]
        ROLL_LOCK=4, 
        ///<summary> Lock pitch angle to absolute angle relative to horizon (not relative to vehicle). This is generally the default with a stabilizing gimbal. | </summary>
        [Description("Lock pitch angle to absolute angle relative to horizon (not relative to vehicle). This is generally the default with a stabilizing gimbal.")]
        PITCH_LOCK=8, 
        ///<summary> Lock yaw angle to absolute angle relative to North (not relative to vehicle). If this flag is set, the yaw angle and z component of angular velocity are relative to North (earth frame, x-axis pointing North), else they are relative to the vehicle heading (vehicle frame, earth frame rotated so that the x-axis is pointing forward). | </summary>
        [Description("Lock yaw angle to absolute angle relative to North (not relative to vehicle). If this flag is set, the yaw angle and z component of angular velocity are relative to North (earth frame, x-axis pointing North), else they are relative to the vehicle heading (vehicle frame, earth frame rotated so that the x-axis is pointing forward).")]
        YAW_LOCK=16, 
        ///<summary> Yaw angle and z component of angular velocity are relative to the vehicle heading (vehicle frame, earth frame rotated such that the x-axis is pointing forward). | </summary>
        [Description("Yaw angle and z component of angular velocity are relative to the vehicle heading (vehicle frame, earth frame rotated such that the x-axis is pointing forward).")]
        YAW_IN_VEHICLE_FRAME=32, 
        ///<summary> Yaw angle and z component of angular velocity are relative to North (earth frame, x-axis is pointing North). | </summary>
        [Description("Yaw angle and z component of angular velocity are relative to North (earth frame, x-axis is pointing North).")]
        YAW_IN_EARTH_FRAME=64, 
        ///<summary> Gimbal device can accept yaw angle inputs relative to North (earth frame). This flag is only for reporting (attempts to set this flag are ignored). | </summary>
        [Description("Gimbal device can accept yaw angle inputs relative to North (earth frame). This flag is only for reporting (attempts to set this flag are ignored).")]
        ACCEPTS_YAW_IN_EARTH_FRAME=128, 
        ///<summary> The gimbal orientation is set exclusively by the RC signals feed to the gimbal's radio control inputs. MAVLink messages for setting the gimbal orientation (GIMBAL_DEVICE_SET_ATTITUDE) are ignored. | </summary>
        [Description("The gimbal orientation is set exclusively by the RC signals feed to the gimbal's radio control inputs. MAVLink messages for setting the gimbal orientation (GIMBAL_DEVICE_SET_ATTITUDE) are ignored.")]
        RC_EXCLUSIVE=256, 
        ///<summary> The gimbal orientation is determined by combining/mixing the RC signals feed to the gimbal's radio control inputs and the MAVLink messages for setting the gimbal orientation (GIMBAL_DEVICE_SET_ATTITUDE). How these two controls are combined or mixed is not defined by the protocol but is up to the implementation. | </summary>
        [Description("The gimbal orientation is determined by combining/mixing the RC signals feed to the gimbal's radio control inputs and the MAVLink messages for setting the gimbal orientation (GIMBAL_DEVICE_SET_ATTITUDE). How these two controls are combined or mixed is not defined by the protocol but is up to the implementation.")]
        RC_MIXED=512, 
        
    };
    
    ///<summary> Flags for high level gimbal manager operation The first 16 bits are identical to the GIMBAL_DEVICE_FLAGS. </summary>
    [Flags]
	public enum GIMBAL_MANAGER_FLAGS: int /*default*/
    {
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_RETRACT. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_RETRACT.")]
        RETRACT=1, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_NEUTRAL. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_NEUTRAL.")]
        NEUTRAL=2, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_ROLL_LOCK. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_ROLL_LOCK.")]
        ROLL_LOCK=4, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_PITCH_LOCK. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_PITCH_LOCK.")]
        PITCH_LOCK=8, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_YAW_LOCK. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_YAW_LOCK.")]
        YAW_LOCK=16, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_YAW_IN_VEHICLE_FRAME. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_YAW_IN_VEHICLE_FRAME.")]
        YAW_IN_VEHICLE_FRAME=32, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_YAW_IN_EARTH_FRAME. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_YAW_IN_EARTH_FRAME.")]
        YAW_IN_EARTH_FRAME=64, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_ACCEPTS_YAW_IN_EARTH_FRAME. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_ACCEPTS_YAW_IN_EARTH_FRAME.")]
        ACCEPTS_YAW_IN_EARTH_FRAME=128, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_RC_EXCLUSIVE. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_RC_EXCLUSIVE.")]
        RC_EXCLUSIVE=256, 
        ///<summary> Based on GIMBAL_DEVICE_FLAGS_RC_MIXED. | </summary>
        [Description("Based on GIMBAL_DEVICE_FLAGS_RC_MIXED.")]
        RC_MIXED=512, 
        
    };
    
    ///<summary> Gimbal device (low level) error flags (bitmap, 0 means no error) </summary>
    [Flags]
	public enum GIMBAL_DEVICE_ERROR_FLAGS: int /*default*/
    {
        ///<summary> Gimbal device is limited by hardware roll limit. | </summary>
        [Description("Gimbal device is limited by hardware roll limit.")]
        AT_ROLL_LIMIT=1, 
        ///<summary> Gimbal device is limited by hardware pitch limit. | </summary>
        [Description("Gimbal device is limited by hardware pitch limit.")]
        AT_PITCH_LIMIT=2, 
        ///<summary> Gimbal device is limited by hardware yaw limit. | </summary>
        [Description("Gimbal device is limited by hardware yaw limit.")]
        AT_YAW_LIMIT=4, 
        ///<summary> There is an error with the gimbal encoders. | </summary>
        [Description("There is an error with the gimbal encoders.")]
        ENCODER_ERROR=8, 
        ///<summary> There is an error with the gimbal power source. | </summary>
        [Description("There is an error with the gimbal power source.")]
        POWER_ERROR=16, 
        ///<summary> There is an error with the gimbal motors. | </summary>
        [Description("There is an error with the gimbal motors.")]
        MOTOR_ERROR=32, 
        ///<summary> There is an error with the gimbal's software. | </summary>
        [Description("There is an error with the gimbal's software.")]
        SOFTWARE_ERROR=64, 
        ///<summary> There is an error with the gimbal's communication. | </summary>
        [Description("There is an error with the gimbal's communication.")]
        COMMS_ERROR=128, 
        ///<summary> Gimbal device is currently calibrating. | </summary>
        [Description("Gimbal device is currently calibrating.")]
        CALIBRATION_RUNNING=256, 
        ///<summary> Gimbal device is not assigned to a gimbal manager. | </summary>
        [Description("Gimbal device is not assigned to a gimbal manager.")]
        NO_MANAGER=512, 
        
    };
    
    ///<summary> Gripper actions. </summary>
    public enum GRIPPER_ACTIONS: int /*default*/
    {
        ///<summary> Gripper release cargo. | </summary>
        [Description("Gripper release cargo.")]
        GRIPPER_ACTION_RELEASE=0, 
        ///<summary> Gripper grab onto cargo. | </summary>
        [Description("Gripper grab onto cargo.")]
        GRIPPER_ACTION_GRAB=1, 
        
    };
    
    ///<summary> Winch actions. </summary>
    public enum WINCH_ACTIONS: int /*default*/
    {
        ///<summary> Allow motor to freewheel. | </summary>
        [Description("Allow motor to freewheel.")]
        WINCH_RELAXED=0, 
        ///<summary> Wind or unwind specified length of line, optionally using specified rate. | </summary>
        [Description("Wind or unwind specified length of line, optionally using specified rate.")]
        WINCH_RELATIVE_LENGTH_CONTROL=1, 
        ///<summary> Wind or unwind line at specified rate. | </summary>
        [Description("Wind or unwind line at specified rate.")]
        WINCH_RATE_CONTROL=2, 
        ///<summary> Perform the locking sequence to relieve motor while in the fully retracted position. Only action and instance command parameters are used, others are ignored. | </summary>
        [Description("Perform the locking sequence to relieve motor while in the fully retracted position. Only action and instance command parameters are used, others are ignored.")]
        WINCH_LOCK=3, 
        ///<summary> Sequence of drop, slow down, touch down, reel up, lock. Only action and instance command parameters are used, others are ignored. | </summary>
        [Description("Sequence of drop, slow down, touch down, reel up, lock. Only action and instance command parameters are used, others are ignored.")]
        WINCH_DELIVER=4, 
        ///<summary> Engage motor and hold current position. Only action and instance command parameters are used, others are ignored. | </summary>
        [Description("Engage motor and hold current position. Only action and instance command parameters are used, others are ignored.")]
        WINCH_HOLD=5, 
        ///<summary> Return the reel to the fully retracted position. Only action and instance command parameters are used, others are ignored. | </summary>
        [Description("Return the reel to the fully retracted position. Only action and instance command parameters are used, others are ignored.")]
        WINCH_RETRACT=6, 
        ///<summary> Load the reel with line. The winch will calculate the total loaded length and stop when the tension exceeds a threshold. Only action and instance command parameters are used, others are ignored. | </summary>
        [Description("Load the reel with line. The winch will calculate the total loaded length and stop when the tension exceeds a threshold. Only action and instance command parameters are used, others are ignored.")]
        WINCH_LOAD_LINE=7, 
        ///<summary> Spool out the entire length of the line. Only action and instance command parameters are used, others are ignored. | </summary>
        [Description("Spool out the entire length of the line. Only action and instance command parameters are used, others are ignored.")]
        WINCH_ABANDON_LINE=8, 
        ///<summary> Spools out just enough to present the hook to the user to load the payload. Only action and instance command parameters are used, others are ignored | </summary>
        [Description("Spools out just enough to present the hook to the user to load the payload. Only action and instance command parameters are used, others are ignored")]
        WINCH_LOAD_PAYLOAD=9, 
        
    };
    
    ///<summary> Generalized UAVCAN node health </summary>
    public enum UAVCAN_NODE_HEALTH: int /*default*/
    {
        ///<summary> The node is functioning properly. | </summary>
        [Description("The node is functioning properly.")]
        OK=0, 
        ///<summary> A critical parameter went out of range or the node has encountered a minor failure. | </summary>
        [Description("A critical parameter went out of range or the node has encountered a minor failure.")]
        WARNING=1, 
        ///<summary> The node has encountered a major failure. | </summary>
        [Description("The node has encountered a major failure.")]
        ERROR=2, 
        ///<summary> The node has suffered a fatal malfunction. | </summary>
        [Description("The node has suffered a fatal malfunction.")]
        CRITICAL=3, 
        
    };
    
    ///<summary> Generalized UAVCAN node mode </summary>
    public enum UAVCAN_NODE_MODE: int /*default*/
    {
        ///<summary> The node is performing its primary functions. | </summary>
        [Description("The node is performing its primary functions.")]
        OPERATIONAL=0, 
        ///<summary> The node is initializing; this mode is entered immediately after startup. | </summary>
        [Description("The node is initializing; this mode is entered immediately after startup.")]
        INITIALIZATION=1, 
        ///<summary> The node is under maintenance. | </summary>
        [Description("The node is under maintenance.")]
        MAINTENANCE=2, 
        ///<summary> The node is in the process of updating its software. | </summary>
        [Description("The node is in the process of updating its software.")]
        SOFTWARE_UPDATE=3, 
        ///<summary> The node is no longer available online. | </summary>
        [Description("The node is no longer available online.")]
        OFFLINE=7, 
        
    };
    
    ///<summary> Indicates the ESC connection type. </summary>
    public enum ESC_CONNECTION_TYPE: int /*default*/
    {
        ///<summary> Traditional PPM ESC. | </summary>
        [Description("Traditional PPM ESC.")]
        PPM=0, 
        ///<summary> Serial Bus connected ESC. | </summary>
        [Description("Serial Bus connected ESC.")]
        SERIAL=1, 
        ///<summary> One Shot PPM ESC. | </summary>
        [Description("One Shot PPM ESC.")]
        ONESHOT=2, 
        ///<summary> I2C ESC. | </summary>
        [Description("I2C ESC.")]
        I2C=3, 
        ///<summary> CAN-Bus ESC. | </summary>
        [Description("CAN-Bus ESC.")]
        CAN=4, 
        ///<summary> DShot ESC. | </summary>
        [Description("DShot ESC.")]
        DSHOT=5, 
        
    };
    
    ///<summary> Flags to report ESC failures. </summary>
    [Flags]
	public enum ESC_FAILURE_FLAGS: int /*default*/
    {
        ///<summary> No ESC failure. | </summary>
        [Description("No ESC failure.")]
        ESC_FAILURE_NONE=0, 
        ///<summary> Over current failure. | </summary>
        [Description("Over current failure.")]
        ESC_FAILURE_OVER_CURRENT=1, 
        ///<summary> Over voltage failure. | </summary>
        [Description("Over voltage failure.")]
        ESC_FAILURE_OVER_VOLTAGE=2, 
        ///<summary> Over temperature failure. | </summary>
        [Description("Over temperature failure.")]
        ESC_FAILURE_OVER_TEMPERATURE=4, 
        ///<summary> Over RPM failure. | </summary>
        [Description("Over RPM failure.")]
        ESC_FAILURE_OVER_RPM=8, 
        ///<summary> Inconsistent command failure i.e. out of bounds. | </summary>
        [Description("Inconsistent command failure i.e. out of bounds.")]
        ESC_FAILURE_INCONSISTENT_CMD=16, 
        ///<summary> Motor stuck failure. | </summary>
        [Description("Motor stuck failure.")]
        ESC_FAILURE_MOTOR_STUCK=32, 
        ///<summary> Generic ESC failure. | </summary>
        [Description("Generic ESC failure.")]
        ESC_FAILURE_GENERIC=64, 
        
    };
    
    ///<summary> Flags to indicate the status of camera storage. </summary>
    public enum STORAGE_STATUS: int /*default*/
    {
        ///<summary> Storage is missing (no microSD card loaded for example.) | </summary>
        [Description("Storage is missing (no microSD card loaded for example.)")]
        EMPTY=0, 
        ///<summary> Storage present but unformatted. | </summary>
        [Description("Storage present but unformatted.")]
        UNFORMATTED=1, 
        ///<summary> Storage present and ready. | </summary>
        [Description("Storage present and ready.")]
        READY=2, 
        ///<summary> Camera does not supply storage status information. Capacity information in STORAGE_INFORMATION fields will be ignored. | </summary>
        [Description("Camera does not supply storage status information. Capacity information in STORAGE_INFORMATION fields will be ignored.")]
        NOT_SUPPORTED=3, 
        
    };
    
    ///<summary> Flags to indicate the type of storage. </summary>
    public enum STORAGE_TYPE: int /*default*/
    {
        ///<summary> Storage type is not known. | </summary>
        [Description("Storage type is not known.")]
        UNKNOWN=0, 
        ///<summary> Storage type is USB device. | </summary>
        [Description("Storage type is USB device.")]
        USB_STICK=1, 
        ///<summary> Storage type is SD card. | </summary>
        [Description("Storage type is SD card.")]
        SD=2, 
        ///<summary> Storage type is microSD card. | </summary>
        [Description("Storage type is microSD card.")]
        MICROSD=3, 
        ///<summary> Storage type is CFast. | </summary>
        [Description("Storage type is CFast.")]
        CF=4, 
        ///<summary> Storage type is CFexpress. | </summary>
        [Description("Storage type is CFexpress.")]
        CFE=5, 
        ///<summary> Storage type is XQD. | </summary>
        [Description("Storage type is XQD.")]
        XQD=6, 
        ///<summary> Storage type is HD mass storage type. | </summary>
        [Description("Storage type is HD mass storage type.")]
        HD=7, 
        ///<summary> Storage type is other, not listed type. | </summary>
        [Description("Storage type is other, not listed type.")]
        OTHER=254, 
        
    };
    
    ///<summary> Flags to indicate usage for a particular storage (see STORAGE_INFORMATION.storage_usage and MAV_CMD_SET_STORAGE_USAGE). </summary>
    public enum STORAGE_USAGE_FLAG: int /*default*/
    {
        ///<summary> Always set to 1 (indicates STORAGE_INFORMATION.storage_usage is supported). | </summary>
        [Description("Always set to 1 (indicates STORAGE_INFORMATION.storage_usage is supported).")]
        SET=1, 
        ///<summary> Storage for saving photos. | </summary>
        [Description("Storage for saving photos.")]
        PHOTO=2, 
        ///<summary> Storage for saving videos. | </summary>
        [Description("Storage for saving videos.")]
        VIDEO=4, 
        ///<summary> Storage for saving logs. | </summary>
        [Description("Storage for saving logs.")]
        LOGS=8, 
        
    };
    
    ///<summary> Yaw behaviour during orbit flight. </summary>
    public enum ORBIT_YAW_BEHAVIOUR: int /*default*/
    {
        ///<summary> Vehicle front points to the center (default). | </summary>
        [Description("Vehicle front points to the center (default).")]
        HOLD_FRONT_TO_CIRCLE_CENTER=0, 
        ///<summary> Vehicle front holds heading when message received. | </summary>
        [Description("Vehicle front holds heading when message received.")]
        HOLD_INITIAL_HEADING=1, 
        ///<summary> Yaw uncontrolled. | </summary>
        [Description("Yaw uncontrolled.")]
        UNCONTROLLED=2, 
        ///<summary> Vehicle front follows flight path (tangential to circle). | </summary>
        [Description("Vehicle front follows flight path (tangential to circle).")]
        HOLD_FRONT_TANGENT_TO_CIRCLE=3, 
        ///<summary> Yaw controlled by RC input. | </summary>
        [Description("Yaw controlled by RC input.")]
        RC_CONTROLLED=4, 
        
    };
    
    ///<summary> Possible responses from a WIFI_CONFIG_AP message. </summary>
    public enum WIFI_CONFIG_AP_RESPONSE: int /*default*/
    {
        ///<summary> Undefined response. Likely an indicative of a system that doesn't support this request. | </summary>
        [Description("Undefined response. Likely an indicative of a system that doesn't support this request.")]
        UNDEFINED=0, 
        ///<summary> Changes accepted. | </summary>
        [Description("Changes accepted.")]
        ACCEPTED=1, 
        ///<summary> Changes rejected. | </summary>
        [Description("Changes rejected.")]
        REJECTED=2, 
        ///<summary> Invalid Mode. | </summary>
        [Description("Invalid Mode.")]
        MODE_ERROR=3, 
        ///<summary> Invalid SSID. | </summary>
        [Description("Invalid SSID.")]
        SSID_ERROR=4, 
        ///<summary> Invalid Password. | </summary>
        [Description("Invalid Password.")]
        PASSWORD_ERROR=5, 
        
    };
    
    ///<summary> Possible responses from a CELLULAR_CONFIG message. </summary>
    public enum CELLULAR_CONFIG_RESPONSE: int /*default*/
    {
        ///<summary> Changes accepted. | </summary>
        [Description("Changes accepted.")]
        ACCEPTED=0, 
        ///<summary> Invalid APN. | </summary>
        [Description("Invalid APN.")]
        APN_ERROR=1, 
        ///<summary> Invalid PIN. | </summary>
        [Description("Invalid PIN.")]
        PIN_ERROR=2, 
        ///<summary> Changes rejected. | </summary>
        [Description("Changes rejected.")]
        REJECTED=3, 
        ///<summary> PUK is required to unblock SIM card. | </summary>
        [Description("PUK is required to unblock SIM card.")]
        CELLULAR_CONFIG_BLOCKED_PUK_REQUIRED=4, 
        
    };
    
    ///<summary> WiFi Mode. </summary>
    public enum WIFI_CONFIG_AP_MODE: int /*default*/
    {
        ///<summary> WiFi mode is undefined. | </summary>
        [Description("WiFi mode is undefined.")]
        UNDEFINED=0, 
        ///<summary> WiFi configured as an access point. | </summary>
        [Description("WiFi configured as an access point.")]
        AP=1, 
        ///<summary> WiFi configured as a station connected to an existing local WiFi network. | </summary>
        [Description("WiFi configured as a station connected to an existing local WiFi network.")]
        STATION=2, 
        ///<summary> WiFi disabled. | </summary>
        [Description("WiFi disabled.")]
        DISABLED=3, 
        
    };
    
    ///<summary> Supported component metadata types. These are used in the 'general' metadata file returned by COMPONENT_METADATA to provide information about supported metadata types. The types are not used directly in MAVLink messages. </summary>
    public enum COMP_METADATA_TYPE: int /*default*/
    {
        ///<summary> General information about the component. General metadata includes information about other metadata types supported by the component. Files of this type must be supported, and must be downloadable from vehicle using a MAVLink FTP URI. | </summary>
        [Description("General information about the component. General metadata includes information about other metadata types supported by the component. Files of this type must be supported, and must be downloadable from vehicle using a MAVLink FTP URI.")]
        GENERAL=0, 
        ///<summary> Parameter meta data. | </summary>
        [Description("Parameter meta data.")]
        PARAMETER=1, 
        ///<summary> Meta data that specifies which commands and command parameters the vehicle supports. (WIP) | </summary>
        [Description("Meta data that specifies which commands and command parameters the vehicle supports. (WIP)")]
        COMMANDS=2, 
        ///<summary> Meta data that specifies external non-MAVLink peripherals. | </summary>
        [Description("Meta data that specifies external non-MAVLink peripherals.")]
        PERIPHERALS=3, 
        ///<summary> Meta data for the events interface. | </summary>
        [Description("Meta data for the events interface.")]
        EVENTS=4, 
        ///<summary> Meta data for actuator configuration (motors, servos and vehicle geometry) and testing. | </summary>
        [Description("Meta data for actuator configuration (motors, servos and vehicle geometry) and testing.")]
        ACTUATORS=5, 
        
    };
    
    ///<summary> Actuator configuration, used to change a setting on an actuator. Component information metadata can be used to know which outputs support which commands. </summary>
    public enum ACTUATOR_CONFIGURATION: int /*default*/
    {
        ///<summary> Do nothing. | </summary>
        [Description("Do nothing.")]
        NONE=0, 
        ///<summary> Command the actuator to beep now. | </summary>
        [Description("Command the actuator to beep now.")]
        BEEP=1, 
        ///<summary> Permanently set the actuator (ESC) to 3D mode (reversible thrust). | </summary>
        [Description("Permanently set the actuator (ESC) to 3D mode (reversible thrust).")]
        _3D_MODE_ON=2, 
        ///<summary> Permanently set the actuator (ESC) to non 3D mode (non-reversible thrust). | </summary>
        [Description("Permanently set the actuator (ESC) to non 3D mode (non-reversible thrust).")]
        _3D_MODE_OFF=3, 
        ///<summary> Permanently set the actuator (ESC) to spin direction 1 (which can be clockwise or counter-clockwise). | </summary>
        [Description("Permanently set the actuator (ESC) to spin direction 1 (which can be clockwise or counter-clockwise).")]
        SPIN_DIRECTION1=4, 
        ///<summary> Permanently set the actuator (ESC) to spin direction 2 (opposite of direction 1). | </summary>
        [Description("Permanently set the actuator (ESC) to spin direction 2 (opposite of direction 1).")]
        SPIN_DIRECTION2=5, 
        
    };
    
    ///<summary> Actuator output function. Values greater or equal to 1000 are autopilot-specific. </summary>
    public enum ACTUATOR_OUTPUT_FUNCTION: int /*default*/
    {
        ///<summary> No function (disabled). | </summary>
        [Description("No function (disabled).")]
        NONE=0, 
        ///<summary> Motor 1 | </summary>
        [Description("Motor 1")]
        MOTOR1=1, 
        ///<summary> Motor 2 | </summary>
        [Description("Motor 2")]
        MOTOR2=2, 
        ///<summary> Motor 3 | </summary>
        [Description("Motor 3")]
        MOTOR3=3, 
        ///<summary> Motor 4 | </summary>
        [Description("Motor 4")]
        MOTOR4=4, 
        ///<summary> Motor 5 | </summary>
        [Description("Motor 5")]
        MOTOR5=5, 
        ///<summary> Motor 6 | </summary>
        [Description("Motor 6")]
        MOTOR6=6, 
        ///<summary> Motor 7 | </summary>
        [Description("Motor 7")]
        MOTOR7=7, 
        ///<summary> Motor 8 | </summary>
        [Description("Motor 8")]
        MOTOR8=8, 
        ///<summary> Motor 9 | </summary>
        [Description("Motor 9")]
        MOTOR9=9, 
        ///<summary> Motor 10 | </summary>
        [Description("Motor 10")]
        MOTOR10=10, 
        ///<summary> Motor 11 | </summary>
        [Description("Motor 11")]
        MOTOR11=11, 
        ///<summary> Motor 12 | </summary>
        [Description("Motor 12")]
        MOTOR12=12, 
        ///<summary> Motor 13 | </summary>
        [Description("Motor 13")]
        MOTOR13=13, 
        ///<summary> Motor 14 | </summary>
        [Description("Motor 14")]
        MOTOR14=14, 
        ///<summary> Motor 15 | </summary>
        [Description("Motor 15")]
        MOTOR15=15, 
        ///<summary> Motor 16 | </summary>
        [Description("Motor 16")]
        MOTOR16=16, 
        ///<summary> Servo 1 | </summary>
        [Description("Servo 1")]
        SERVO1=33, 
        ///<summary> Servo 2 | </summary>
        [Description("Servo 2")]
        SERVO2=34, 
        ///<summary> Servo 3 | </summary>
        [Description("Servo 3")]
        SERVO3=35, 
        ///<summary> Servo 4 | </summary>
        [Description("Servo 4")]
        SERVO4=36, 
        ///<summary> Servo 5 | </summary>
        [Description("Servo 5")]
        SERVO5=37, 
        ///<summary> Servo 6 | </summary>
        [Description("Servo 6")]
        SERVO6=38, 
        ///<summary> Servo 7 | </summary>
        [Description("Servo 7")]
        SERVO7=39, 
        ///<summary> Servo 8 | </summary>
        [Description("Servo 8")]
        SERVO8=40, 
        ///<summary> Servo 9 | </summary>
        [Description("Servo 9")]
        SERVO9=41, 
        ///<summary> Servo 10 | </summary>
        [Description("Servo 10")]
        SERVO10=42, 
        ///<summary> Servo 11 | </summary>
        [Description("Servo 11")]
        SERVO11=43, 
        ///<summary> Servo 12 | </summary>
        [Description("Servo 12")]
        SERVO12=44, 
        ///<summary> Servo 13 | </summary>
        [Description("Servo 13")]
        SERVO13=45, 
        ///<summary> Servo 14 | </summary>
        [Description("Servo 14")]
        SERVO14=46, 
        ///<summary> Servo 15 | </summary>
        [Description("Servo 15")]
        SERVO15=47, 
        ///<summary> Servo 16 | </summary>
        [Description("Servo 16")]
        SERVO16=48, 
        
    };
    
    ///<summary> Enable axes that will be tuned via autotuning. Used in MAV_CMD_DO_AUTOTUNE_ENABLE. </summary>
    public enum AUTOTUNE_AXIS: int /*default*/
    {
        ///<summary> Flight stack tunes axis according to its default settings. | </summary>
        [Description("Flight stack tunes axis according to its default settings.")]
        DEFAULT=0, 
        ///<summary> Autotune roll axis. | </summary>
        [Description("Autotune roll axis.")]
        ROLL=1, 
        ///<summary> Autotune pitch axis. | </summary>
        [Description("Autotune pitch axis.")]
        PITCH=2, 
        ///<summary> Autotune yaw axis. | </summary>
        [Description("Autotune yaw axis.")]
        YAW=4, 
        
    };
    
    ///<summary>          Actions for reading/writing parameters between persistent and volatile storage when using MAV_CMD_PREFLIGHT_STORAGE.         (Commonly parameters are loaded from persistent storage (flash/EEPROM) into volatile storage (RAM) on startup and written back when they are changed.)        </summary>
    public enum PREFLIGHT_STORAGE_PARAMETER_ACTION: int /*default*/
    {
        ///<summary> Read all parameters from persistent storage. Replaces values in volatile storage. | </summary>
        [Description("Read all parameters from persistent storage. Replaces values in volatile storage.")]
        PARAM_READ_PERSISTENT=0, 
        ///<summary> Write all parameter values to persistent storage (flash/EEPROM) | </summary>
        [Description("Write all parameter values to persistent storage (flash/EEPROM)")]
        PARAM_WRITE_PERSISTENT=1, 
        ///<summary> Reset all user configurable parameters to their default value (including airframe selection, sensor calibration data, safety settings, and so on). Does not reset values that contain operation counters and vehicle computed statistics. | </summary>
        [Description("Reset all user configurable parameters to their default value (including airframe selection, sensor calibration data, safety settings, and so on). Does not reset values that contain operation counters and vehicle computed statistics.")]
        PARAM_RESET_CONFIG_DEFAULT=2, 
        ///<summary> Reset only sensor calibration parameters to factory defaults (or firmware default if not available) | </summary>
        [Description("Reset only sensor calibration parameters to factory defaults (or firmware default if not available)")]
        PARAM_RESET_SENSOR_DEFAULT=3, 
        ///<summary> Reset all parameters, including operation counters, to default values | </summary>
        [Description("Reset all parameters, including operation counters, to default values")]
        PARAM_RESET_ALL_DEFAULT=4, 
        
    };
    
    ///<summary>          Actions for reading and writing plan information (mission, rally points, geofence) between persistent and volatile storage when using MAV_CMD_PREFLIGHT_STORAGE.         (Commonly missions are loaded from persistent storage (flash/EEPROM) into volatile storage (RAM) on startup and written back when they are changed.)        </summary>
    public enum PREFLIGHT_STORAGE_MISSION_ACTION: int /*default*/
    {
        ///<summary> Read current mission data from persistent storage | </summary>
        [Description("Read current mission data from persistent storage")]
        MISSION_READ_PERSISTENT=0, 
        ///<summary> Write current mission data to persistent storage | </summary>
        [Description("Write current mission data to persistent storage")]
        MISSION_WRITE_PERSISTENT=1, 
        ///<summary> Erase all mission data stored on the vehicle (both persistent and volatile storage) | </summary>
        [Description("Erase all mission data stored on the vehicle (both persistent and volatile storage)")]
        MISSION_RESET_DEFAULT=2, 
        
    };
    
    ///<summary> Commands to be executed by the MAV. They can be executed on user request, or as part of a mission script. If the action is used in a mission, the parameter mapping to the waypoint/mission message is as follows: Param 1, Param 2, Param 3, Param 4, X: Param 5, Y:Param 6, Z:Param 7. This command list is similar what ARINC 424 is for commercial aircraft: A data format how to interpret waypoint/mission data. NaN and INT32_MAX may be used in float/integer params (respectively) to indicate optional/default values (e.g. to use the component's current yaw or latitude rather than a specific value). See https://mavlink.io/en/guide/xml_schema.html#MAV_CMD for information about the structure of the MAV_CMD entries </summary>
    public enum MAV_CMD: ushort
    {
        ///<summary> Navigate to waypoint. |Hold time. (ignored by fixed wing, time to stay at waypoint for rotary wing)| Acceptance radius (if the sphere with this radius is hit, the waypoint counts as reached)| 0 to pass through the WP, if > 0 radius to pass by WP. Positive value for clockwise orbit, negative value for counter-clockwise orbit. Allows trajectory control.| Desired yaw angle at waypoint (rotary wing). NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.).| Latitude| Longitude| Altitude|  </summary>
        [Description("Navigate to waypoint.")]
        WAYPOINT=16, 
        ///<summary> Loiter around this waypoint an unlimited amount of time |Empty| Empty| Loiter radius around waypoint for forward-only moving vehicles (not multicopters). If positive loiter clockwise, else counter-clockwise| Desired yaw angle. NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.).| Latitude| Longitude| Altitude|  </summary>
        [Description("Loiter around this waypoint an unlimited amount of time")]
        LOITER_UNLIM=17, 
        ///<summary> Loiter around this waypoint for X turns |Number of turns.| Leave loiter circle only once heading towards the next waypoint (0 = False)| Loiter radius around waypoint for forward-only moving vehicles (not multicopters). If positive loiter clockwise, else counter-clockwise| Loiter circle exit location and/or path to next waypoint ("xtrack") for forward-only moving vehicles (not multicopters). 0 for the vehicle to converge towards the center xtrack when it leaves the loiter (the line between the centers of the current and next waypoint), 1 to converge to the direct line between the location that the vehicle exits the loiter radius and the next waypoint. Otherwise the angle (in degrees) between the tangent of the loiter circle and the center xtrack at which the vehicle must leave the loiter (and converge to the center xtrack). NaN to use the current system default xtrack behaviour.| Latitude| Longitude| Altitude|  </summary>
        [Description("Loiter around this waypoint for X turns")]
        LOITER_TURNS=18, 
        ///<summary> Loiter at the specified latitude, longitude and altitude for a certain amount of time. Multicopter vehicles stop at the point (within a vehicle-specific acceptance radius). Forward-only moving vehicles (e.g. fixed-wing) circle the point with the specified radius/direction. If the Heading Required parameter (2) is non-zero forward moving aircraft will only leave the loiter circle once heading towards the next waypoint. |Loiter time (only starts once Lat, Lon and Alt is reached).| Leave loiter circle only once heading towards the next waypoint (0 = False)| Loiter radius around waypoint for forward-only moving vehicles (not multicopters). If positive loiter clockwise, else counter-clockwise.| Loiter circle exit location and/or path to next waypoint ("xtrack") for forward-only moving vehicles (not multicopters). 0 for the vehicle to converge towards the center xtrack when it leaves the loiter (the line between the centers of the current and next waypoint), 1 to converge to the direct line between the location that the vehicle exits the loiter radius and the next waypoint. Otherwise the angle (in degrees) between the tangent of the loiter circle and the center xtrack at which the vehicle must leave the loiter (and converge to the center xtrack). NaN to use the current system default xtrack behaviour.| Latitude| Longitude| Altitude|  </summary>
        [Description("Loiter at the specified latitude, longitude and altitude for a certain amount of time. Multicopter vehicles stop at the point (within a vehicle-specific acceptance radius). Forward-only moving vehicles (e.g. fixed-wing) circle the point with the specified radius/direction. If the Heading Required parameter (2) is non-zero forward moving aircraft will only leave the loiter circle once heading towards the next waypoint.")]
        LOITER_TIME=19, 
        ///<summary> Return to launch location |Empty| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Return to launch location")]
        RETURN_TO_LAUNCH=20, 
        ///<summary> Land at location. |Minimum target altitude if landing is aborted (0 = undefined/use system default).| Precision land mode.| Empty.| Desired yaw angle. NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.).| Latitude.| Longitude.| Landing altitude (ground level in current frame).|  </summary>
        [Description("Land at location.")]
        LAND=21, 
        ///<summary> Takeoff from ground / hand. Vehicles that support multiple takeoff modes (e.g. VTOL quadplane) should take off using the currently configured mode. |Minimum pitch (if airspeed sensor present), desired pitch without sensor| Empty| Empty| Yaw angle (if magnetometer present), ignored without magnetometer. NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.).| Latitude| Longitude| Altitude|  </summary>
        [Description("Takeoff from ground / hand. Vehicles that support multiple takeoff modes (e.g. VTOL quadplane) should take off using the currently configured mode.")]
        TAKEOFF=22, 
        ///<summary> Land at local position (local frame only) |Landing target number (if available)| Maximum accepted offset from desired landing position - computed magnitude from spherical coordinates: d = sqrt(x^2 + y^2 + z^2), which gives the maximum accepted distance between the desired landing position and the position where the vehicle is about to land| Landing descend rate| Desired yaw angle| Y-axis position| X-axis position| Z-axis / ground level position|  </summary>
        [Description("Land at local position (local frame only)")]
        LAND_LOCAL=23, 
        ///<summary> Takeoff from local position (local frame only) |Minimum pitch (if airspeed sensor present), desired pitch without sensor| Empty| Takeoff ascend rate| Yaw angle (if magnetometer or another yaw estimation source present), ignored without one of these| Y-axis position| X-axis position| Z-axis position|  </summary>
        [Description("Takeoff from local position (local frame only)")]
        TAKEOFF_LOCAL=24, 
        ///<summary> Vehicle following, i.e. this waypoint represents the position of a moving vehicle |Following logic to use (e.g. loitering or sinusoidal following) - depends on specific autopilot implementation| Ground speed of vehicle to be followed| Radius around waypoint. If positive loiter clockwise, else counter-clockwise| Desired yaw angle.| Latitude| Longitude| Altitude|  </summary>
        [Description("Vehicle following, i.e. this waypoint represents the position of a moving vehicle")]
        FOLLOW=25, 
        ///<summary> Continue on the current course and climb/descend to specified altitude.  When the altitude is reached continue to the next command (i.e., don't proceed to the next command until the desired altitude is reached. |Climb or Descend (0 = Neutral, command completes when within 5m of this command's altitude, 1 = Climbing, command completes when at or above this command's altitude, 2 = Descending, command completes when at or below this command's altitude.| Empty| Empty| Empty| Empty| Empty| Desired altitude|  </summary>
        [Description("Continue on the current course and climb/descend to specified altitude.  When the altitude is reached continue to the next command (i.e., don't proceed to the next command until the desired altitude is reached.")]
        CONTINUE_AND_CHANGE_ALT=30, 
        ///<summary> Begin loiter at the specified Latitude and Longitude.  If Lat=Lon=0, then loiter at the current position.  Don't consider the navigation command complete (don't leave loiter) until the altitude has been reached. Additionally, if the Heading Required parameter is non-zero the aircraft will not leave the loiter until heading toward the next waypoint. |Leave loiter circle only once heading towards the next waypoint (0 = False)| Loiter radius around waypoint for forward-only moving vehicles (not multicopters). If positive loiter clockwise, negative counter-clockwise, 0 means no change to standard loiter.| Empty| Loiter circle exit location and/or path to next waypoint ("xtrack") for forward-only moving vehicles (not multicopters). 0 for the vehicle to converge towards the center xtrack when it leaves the loiter (the line between the centers of the current and next waypoint), 1 to converge to the direct line between the location that the vehicle exits the loiter radius and the next waypoint. Otherwise the angle (in degrees) between the tangent of the loiter circle and the center xtrack at which the vehicle must leave the loiter (and converge to the center xtrack). NaN to use the current system default xtrack behaviour.| Latitude| Longitude| Altitude|  </summary>
        [Description("Begin loiter at the specified Latitude and Longitude.  If Lat=Lon=0, then loiter at the current position.  Don't consider the navigation command complete (don't leave loiter) until the altitude has been reached. Additionally, if the Heading Required parameter is non-zero the aircraft will not leave the loiter until heading toward the next waypoint.")]
        LOITER_TO_ALT=31, 
        ///<summary> Begin following a target |System ID (of the FOLLOW_TARGET beacon). Send 0 to disable follow-me and return to the default position hold mode.| Reserved| Reserved| Altitude mode: 0: Keep current altitude, 1: keep altitude difference to target, 2: go to a fixed altitude above home.| Altitude above home. (used if mode=2)| Reserved| Time to land in which the MAV should go to the default position hold mode after a message RX timeout.|  </summary>
        [Description("Begin following a target")]
        DO_FOLLOW=32, 
        ///<summary> Reposition the MAV after a follow target command has been sent |Camera q1 (where 0 is on the ray from the camera to the tracking device)| Camera q2| Camera q3| Camera q4| altitude offset from target| X offset from target| Y offset from target|  </summary>
        [Description("Reposition the MAV after a follow target command has been sent")]
        DO_FOLLOW_REPOSITION=33, 
        ///<summary> Start orbiting on the circumference of a circle defined by the parameters. Setting values to NaN/INT32_MAX (as appropriate) results in using defaults. |Radius of the circle. Positive: orbit clockwise. Negative: orbit counter-clockwise. NaN: Use vehicle default radius, or current radius if already orbiting.| Tangential Velocity. NaN: Use vehicle default velocity, or current velocity if already orbiting.| Yaw behavior of the vehicle.| Orbit around the centre point for this many radians (i.e. for a three-quarter orbit set 270*Pi/180). 0: Orbit forever. NaN: Use vehicle default, or current value if already orbiting.| Center point latitude (if no MAV_FRAME specified) / X coordinate according to MAV_FRAME. INT32_MAX (or NaN if sent in COMMAND_LONG): Use current vehicle position, or current center if already orbiting.| Center point longitude (if no MAV_FRAME specified) / Y coordinate according to MAV_FRAME. INT32_MAX (or NaN if sent in COMMAND_LONG): Use current vehicle position, or current center if already orbiting.| Center point altitude (MSL) (if no MAV_FRAME specified) / Z coordinate according to MAV_FRAME. NaN: Use current vehicle altitude.|  </summary>
        [Description("Start orbiting on the circumference of a circle defined by the parameters. Setting values to NaN/INT32_MAX (as appropriate) results in using defaults.")]
        DO_ORBIT=34, 
        ///<summary> Sets the region of interest (ROI) for a sensor set or the vehicle itself. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. |Region of interest mode.| Waypoint index/ target ID. (see MAV_ROI enum)| ROI index (allows a vehicle to manage multiple ROI's)| Empty| x the location of the fixed ROI (see MAV_FRAME)| y| z|  </summary>
        [Description("Sets the region of interest (ROI) for a sensor set or the vehicle itself. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras.")]
        ROI=80, 
        ///<summary> Control autonomous path planning on the MAV. |0: Disable local obstacle avoidance / local path planning (without resetting map), 1: Enable local path planning, 2: Enable and reset local path planning| 0: Disable full path planning (without resetting map), 1: Enable, 2: Enable and reset map/occupancy grid, 3: Enable and reset planned route, but not occupancy grid| Empty| Yaw angle at goal| Latitude/X of goal| Longitude/Y of goal| Altitude/Z of goal|  </summary>
        [Description("Control autonomous path planning on the MAV.")]
        PATHPLANNING=81, 
        ///<summary> Navigate to waypoint using a spline path. |Hold time. (ignored by fixed wing, time to stay at waypoint for rotary wing)| Empty| Empty| Empty| Latitude/X of goal| Longitude/Y of goal| Altitude/Z of goal|  </summary>
        [Description("Navigate to waypoint using a spline path.")]
        SPLINE_WAYPOINT=82, 
        ///<summary> Takeoff from ground using VTOL mode, and transition to forward flight with specified heading. The command should be ignored by vehicles that dont support both VTOL and fixed-wing flight (multicopters, boats,etc.). |Empty| Front transition heading.| Empty| Yaw angle. NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.).| Latitude| Longitude| Altitude|  </summary>
        [Description("Takeoff from ground using VTOL mode, and transition to forward flight with specified heading. The command should be ignored by vehicles that dont support both VTOL and fixed-wing flight (multicopters, boats,etc.).")]
        VTOL_TAKEOFF=84, 
        ///<summary> Land using VTOL mode |Landing behaviour.| Empty| Approach altitude (with the same reference as the Altitude field). NaN if unspecified.| Yaw angle. NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.).| Latitude| Longitude| Altitude (ground level) relative to the current coordinate frame. NaN to use system default landing altitude (ignore value).|  </summary>
        [Description("Land using VTOL mode")]
        VTOL_LAND=85, 
        ///<summary> hand control over to an external controller |On / Off (> 0.5f on)| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("hand control over to an external controller")]
        GUIDED_ENABLE=92, 
        ///<summary> Delay the next navigation command a number of seconds or until a specified time |Delay (-1 to enable time-of-day fields)| hour (24h format, UTC, -1 to ignore)| minute (24h format, UTC, -1 to ignore)| second (24h format, UTC, -1 to ignore)| Empty| Empty| Empty|  </summary>
        [Description("Delay the next navigation command a number of seconds or until a specified time")]
        DELAY=93, 
        ///<summary> Descend and place payload. Vehicle moves to specified location, descends until it detects a hanging payload has reached the ground, and then releases the payload. If ground is not detected before the reaching the maximum descent value (param1), the command will complete without releasing the payload. |Maximum distance to descend.| Empty| Empty| Empty| Latitude| Longitude| Altitude|  </summary>
        [Description("Descend and place payload. Vehicle moves to specified location, descends until it detects a hanging payload has reached the ground, and then releases the payload. If ground is not detected before the reaching the maximum descent value (param1), the command will complete without releasing the payload.")]
        PAYLOAD_PLACE=94, 
        ///<summary> NOP - This command is only used to mark the upper limit of the NAV/ACTION commands in the enumeration |Empty| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("NOP - This command is only used to mark the upper limit of the NAV/ACTION commands in the enumeration")]
        LAST=95, 
        ///<summary> Delay mission state machine. |Delay| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Delay mission state machine.")]
        CONDITION_DELAY=112, 
        ///<summary> Ascend/descend to target altitude at specified rate. Delay mission state machine until desired altitude reached. |Descent / Ascend rate.| Empty| Empty| Empty| Empty| Empty| Target Altitude|  </summary>
        [Description("Ascend/descend to target altitude at specified rate. Delay mission state machine until desired altitude reached.")]
        CONDITION_CHANGE_ALT=113, 
        ///<summary> Delay mission state machine until within desired distance of next NAV point. |Distance.| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Delay mission state machine until within desired distance of next NAV point.")]
        CONDITION_DISTANCE=114, 
        ///<summary> Reach a certain target angle. |target angle, 0 is north| angular speed| direction: -1: counter clockwise, 1: clockwise| 0: absolute angle, 1: relative offset| Empty| Empty| Empty|  </summary>
        [Description("Reach a certain target angle.")]
        CONDITION_YAW=115, 
        ///<summary> NOP - This command is only used to mark the upper limit of the CONDITION commands in the enumeration |Empty| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("NOP - This command is only used to mark the upper limit of the CONDITION commands in the enumeration")]
        CONDITION_LAST=159, 
        ///<summary> Set system mode. |Mode| Custom mode - this is system specific, please refer to the individual autopilot specifications for details.| Custom sub mode - this is system specific, please refer to the individual autopilot specifications for details.| Empty| Empty| Empty| Empty|  </summary>
        [Description("Set system mode.")]
        DO_SET_MODE=176, 
        ///<summary> Jump to the desired command in the mission list.  Repeat this action only the specified number of times |Sequence number| Repeat count| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Jump to the desired command in the mission list.  Repeat this action only the specified number of times")]
        DO_JUMP=177, 
        ///<summary> Change speed and/or throttle set points. The value persists until it is overridden or there is a mode change. |Speed type (0=Airspeed, 1=Ground Speed, 2=Climb Speed, 3=Descent Speed)| Speed (-1 indicates no change, -2 indicates return to default vehicle speed)| Throttle (-1 indicates no change, -2 indicates return to default vehicle throttle value)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Change speed and/or throttle set points. The value persists until it is overridden or there is a mode change.")]
        DO_CHANGE_SPEED=178, 
        ///<summary>            Sets the home position to either to the current position or a specified position.           The home position is the default position that the system will return to and land on.           The position is set automatically by the system during the takeoff (and may also be set using this command).           Note: the current home position may be emitted in a HOME_POSITION message on request (using MAV_CMD_REQUEST_MESSAGE with param1=242).          |Use current (1=use current location, 0=use specified location)| Empty| Empty| Yaw angle. NaN to use default heading| Latitude| Longitude| Altitude|  </summary>
        [Description("           Sets the home position to either to the current position or a specified position.           The home position is the default position that the system will return to and land on.           The position is set automatically by the system during the takeoff (and may also be set using this command).           Note: the current home position may be emitted in a HOME_POSITION message on request (using MAV_CMD_REQUEST_MESSAGE with param1=242).         ")]
        DO_SET_HOME=179, 
        ///<summary> Set a system parameter.  Caution!  Use of this command requires knowledge of the numeric enumeration value of the parameter. |Parameter number| Parameter value| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Set a system parameter.  Caution!  Use of this command requires knowledge of the numeric enumeration value of the parameter.")]
        DO_SET_PARAMETER=180, 
        ///<summary> Set a relay to a condition. |Relay instance number.| Setting. (1=on, 0=off, others possible depending on system hardware)| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Set a relay to a condition.")]
        DO_SET_RELAY=181, 
        ///<summary> Cycle a relay on and off for a desired number of cycles with a desired period. |Relay instance number.| Cycle count.| Cycle time.| Empty| Empty| Empty| Empty|  </summary>
        [Description("Cycle a relay on and off for a desired number of cycles with a desired period.")]
        DO_REPEAT_RELAY=182, 
        ///<summary> Set a servo to a desired PWM value. |Servo instance number.| Pulse Width Modulation.| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Set a servo to a desired PWM value.")]
        DO_SET_SERVO=183, 
        ///<summary> Cycle a between its nominal setting and a desired PWM for a desired number of cycles with a desired period. |Servo instance number.| Pulse Width Modulation.| Cycle count.| Cycle time.| Empty| Empty| Empty|  </summary>
        [Description("Cycle a between its nominal setting and a desired PWM for a desired number of cycles with a desired period.")]
        DO_REPEAT_SERVO=184, 
        ///<summary> Terminate flight immediately.           Flight termination immediately and irreversably terminates the current flight, returning the vehicle to ground.           The vehicle will ignore RC or other input until it has been power-cycled.           Termination may trigger safety measures, including: disabling motors and deployment of parachute on multicopters, and setting flight surfaces to initiate a landing pattern on fixed-wing).           On multicopters without a parachute it may trigger a crash landing.           Support for this command can be tested using the protocol bit: MAV_PROTOCOL_CAPABILITY_FLIGHT_TERMINATION.           Support for this command can also be tested by sending the command with param1=0 (< 0.5); the ACK should be either MAV_RESULT_FAILED or MAV_RESULT_UNSUPPORTED.          |Flight termination activated if > 0.5. Otherwise not activated and ACK with MAV_RESULT_FAILED.| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Terminate flight immediately.           Flight termination immediately and irreversably terminates the current flight, returning the vehicle to ground.           The vehicle will ignore RC or other input until it has been power-cycled.           Termination may trigger safety measures, including: disabling motors and deployment of parachute on multicopters, and setting flight surfaces to initiate a landing pattern on fixed-wing).           On multicopters without a parachute it may trigger a crash landing.           Support for this command can be tested using the protocol bit: MAV_PROTOCOL_CAPABILITY_FLIGHT_TERMINATION.           Support for this command can also be tested by sending the command with param1=0 (< 0.5); the ACK should be either MAV_RESULT_FAILED or MAV_RESULT_UNSUPPORTED.         ")]
        DO_FLIGHTTERMINATION=185, 
        ///<summary> Change altitude set point. |Altitude.| Frame of new altitude.| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Change altitude set point.")]
        DO_CHANGE_ALTITUDE=186, 
        ///<summary> Sets actuators (e.g. servos) to a desired value. The actuator numbers are mapped to specific outputs (e.g. on any MAIN or AUX PWM or UAVCAN) using a flight-stack specific mechanism (i.e. a parameter). |Actuator 1 value, scaled from [-1 to 1]. NaN to ignore.| Actuator 2 value, scaled from [-1 to 1]. NaN to ignore.| Actuator 3 value, scaled from [-1 to 1]. NaN to ignore.| Actuator 4 value, scaled from [-1 to 1]. NaN to ignore.| Actuator 5 value, scaled from [-1 to 1]. NaN to ignore.| Actuator 6 value, scaled from [-1 to 1]. NaN to ignore.| Index of actuator set (i.e if set to 1, Actuator 1 becomes Actuator 7)|  </summary>
        [Description("Sets actuators (e.g. servos) to a desired value. The actuator numbers are mapped to specific outputs (e.g. on any MAIN or AUX PWM or UAVCAN) using a flight-stack specific mechanism (i.e. a parameter).")]
        DO_SET_ACTUATOR=187, 
        ///<summary> Mission command to perform a landing. This is used as a marker in a mission to tell the autopilot where a sequence of mission items that represents a landing starts. 	  It may also be sent via a COMMAND_LONG to trigger a landing, in which case the nearest (geographically) landing sequence in the mission will be used. 	  The Latitude/Longitude/Altitude is optional, and may be set to 0 if not needed. If specified then it will be used to help find the closest landing sequence. 	 |Empty| Empty| Empty| Empty| Latitude| Longitude| Altitude|  </summary>
        [Description("Mission command to perform a landing. This is used as a marker in a mission to tell the autopilot where a sequence of mission items that represents a landing starts. 	  It may also be sent via a COMMAND_LONG to trigger a landing, in which case the nearest (geographically) landing sequence in the mission will be used. 	  The Latitude/Longitude/Altitude is optional, and may be set to 0 if not needed. If specified then it will be used to help find the closest landing sequence. 	")]
        DO_LAND_START=189, 
        ///<summary> Mission command to perform a landing from a rally point. |Break altitude| Landing speed| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission command to perform a landing from a rally point.")]
        DO_RALLY_LAND=190, 
        ///<summary> Mission command to safely abort an autonomous landing. |Altitude| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission command to safely abort an autonomous landing.")]
        DO_GO_AROUND=191, 
        ///<summary> Reposition the vehicle to a specific WGS84 global position. |Ground speed, less than 0 (-1) for default| Bitmask of option flags.| Loiter radius for planes. Positive values only, direction is controlled by Yaw value. A value of zero or NaN is ignored. | Yaw heading. NaN to use the current system yaw heading mode (e.g. yaw towards next waypoint, yaw to home, etc.). For planes indicates loiter direction (0: clockwise, 1: counter clockwise)| Latitude| Longitude| Altitude|  </summary>
        [Description("Reposition the vehicle to a specific WGS84 global position.")]
        DO_REPOSITION=192, 
        ///<summary> If in a GPS controlled position mode, hold the current position or continue. |0: Pause current mission or reposition command, hold current position. 1: Continue mission. A VTOL capable vehicle should enter hover mode (multicopter and VTOL planes). A plane should loiter with the default loiter radius.| Reserved| Reserved| Reserved| Reserved| Reserved| Reserved|  </summary>
        [Description("If in a GPS controlled position mode, hold the current position or continue.")]
        DO_PAUSE_CONTINUE=193, 
        ///<summary> Set moving direction to forward or reverse. |Direction (0=Forward, 1=Reverse)| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Set moving direction to forward or reverse.")]
        DO_SET_REVERSE=194, 
        ///<summary> Sets the region of interest (ROI) to a location. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal is not to react to this message. |Component ID of gimbal device to address (or 1-6 for non-MAVLink gimbal), 0 for all gimbal device components. Send command multiple times for more than one gimbal (but not all gimbals).| Empty| Empty| Empty| Latitude of ROI location| Longitude of ROI location| Altitude of ROI location|  </summary>
        [Description("Sets the region of interest (ROI) to a location. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal is not to react to this message.")]
        DO_SET_ROI_LOCATION=195, 
        ///<summary> Sets the region of interest (ROI) to be toward next waypoint, with optional pitch/roll/yaw offset. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal device is not to react to this message. |Component ID of gimbal device to address (or 1-6 for non-MAVLink gimbal), 0 for all gimbal device components. Send command multiple times for more than one gimbal (but not all gimbals).| Empty| Empty| Empty| Pitch offset from next waypoint, positive pitching up| Roll offset from next waypoint, positive rolling to the right| Yaw offset from next waypoint, positive yawing to the right|  </summary>
        [Description("Sets the region of interest (ROI) to be toward next waypoint, with optional pitch/roll/yaw offset. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal device is not to react to this message.")]
        DO_SET_ROI_WPNEXT_OFFSET=196, 
        ///<summary> Cancels any previous ROI command returning the vehicle/sensors to default flight characteristics. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal device is not to react to this message. After this command the gimbal manager should go back to manual input if available, and otherwise assume a neutral position. |Component ID of gimbal device to address (or 1-6 for non-MAVLink gimbal), 0 for all gimbal device components. Send command multiple times for more than one gimbal (but not all gimbals).| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Cancels any previous ROI command returning the vehicle/sensors to default flight characteristics. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal device is not to react to this message. After this command the gimbal manager should go back to manual input if available, and otherwise assume a neutral position.")]
        DO_SET_ROI_NONE=197, 
        ///<summary> Mount tracks system with specified system ID. Determination of target vehicle position may be done with GLOBAL_POSITION_INT or any other means. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal device is not to react to this message. |System ID| Component ID of gimbal device to address (or 1-6 for non-MAVLink gimbal), 0 for all gimbal device components. Send command multiple times for more than one gimbal (but not all gimbals).| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Mount tracks system with specified system ID. Determination of target vehicle position may be done with GLOBAL_POSITION_INT or any other means. This command can be sent to a gimbal manager but not to a gimbal device. A gimbal device is not to react to this message.")]
        DO_SET_ROI_SYSID=198, 
        ///<summary> Control onboard camera system. |Camera ID (-1 for all)| Transmission: 0: disabled, 1: enabled compressed, 2: enabled raw| Transmission mode: 0: video stream, >0: single images every n seconds| Recording: 0: disabled, 1: enabled compressed, 2: enabled raw| Empty| Empty| Empty|  </summary>
        [Description("Control onboard camera system.")]
        DO_CONTROL_VIDEO=200, 
        ///<summary> Sets the region of interest (ROI) for a sensor set or the vehicle itself. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras. |Region of interest mode.| Waypoint index/ target ID (depends on param 1).| Region of interest index. (allows a vehicle to manage multiple ROI's)| Empty| MAV_ROI_WPNEXT: pitch offset from next waypoint, MAV_ROI_LOCATION: latitude| MAV_ROI_WPNEXT: roll offset from next waypoint, MAV_ROI_LOCATION: longitude| MAV_ROI_WPNEXT: yaw offset from next waypoint, MAV_ROI_LOCATION: altitude|  </summary>
        [Description("Sets the region of interest (ROI) for a sensor set or the vehicle itself. This can then be used by the vehicle's control system to control the vehicle attitude and the attitude of various sensors such as cameras.")]
        DO_SET_ROI=201, 
        ///<summary> Configure digital camera. This is a fallback message for systems that have not yet implemented PARAM_EXT_XXX messages and camera definition files (see https://mavlink.io/en/services/camera_def.html ). |Modes: P, TV, AV, M, Etc.| Shutter speed: Divisor number for one second.| Aperture: F stop number.| ISO number e.g. 80, 100, 200, Etc.| Exposure type enumerator.| Command Identity.| Main engine cut-off time before camera trigger. (0 means no cut-off)|  </summary>
        [Description("Configure digital camera. This is a fallback message for systems that have not yet implemented PARAM_EXT_XXX messages and camera definition files (see https://mavlink.io/en/services/camera_def.html ).")]
        DO_DIGICAM_CONFIGURE=202, 
        ///<summary> Control digital camera. This is a fallback message for systems that have not yet implemented PARAM_EXT_XXX messages and camera definition files (see https://mavlink.io/en/services/camera_def.html ). |Session control e.g. show/hide lens| Zoom's absolute position| Zooming step value to offset zoom from the current position| Focus Locking, Unlocking or Re-locking| Shooting Command| Command Identity| Test shot identifier. If set to 1, image will only be captured, but not counted towards internal frame count.|  </summary>
        [Description("Control digital camera. This is a fallback message for systems that have not yet implemented PARAM_EXT_XXX messages and camera definition files (see https://mavlink.io/en/services/camera_def.html ).")]
        DO_DIGICAM_CONTROL=203, 
        ///<summary> Mission command to configure a camera or antenna mount |Mount operation mode| stabilize roll? (1 = yes, 0 = no)| stabilize pitch? (1 = yes, 0 = no)| stabilize yaw? (1 = yes, 0 = no)| roll input (0 = angle body frame, 1 = angular rate, 2 = angle absolute frame)| pitch input (0 = angle body frame, 1 = angular rate, 2 = angle absolute frame)| yaw input (0 = angle body frame, 1 = angular rate, 2 = angle absolute frame)|  </summary>
        [Description("Mission command to configure a camera or antenna mount")]
        DO_MOUNT_CONFIGURE=204, 
        ///<summary> Mission command to control a camera or antenna mount |pitch depending on mount mode (degrees or degrees/second depending on pitch input).| roll depending on mount mode (degrees or degrees/second depending on roll input).| yaw depending on mount mode (degrees or degrees/second depending on yaw input).| altitude depending on mount mode.| latitude, set if appropriate mount mode.| longitude, set if appropriate mount mode.| Mount mode.|  </summary>
        [Description("Mission command to control a camera or antenna mount")]
        DO_MOUNT_CONTROL=205, 
        ///<summary> Mission command to set camera trigger distance for this flight. The camera is triggered each time this distance is exceeded. This command can also be used to set the shutter integration time for the camera. |Camera trigger distance. 0 to stop triggering.| Camera shutter integration time. -1 or 0 to ignore| Trigger camera once immediately. (0 = no trigger, 1 = trigger)| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission command to set camera trigger distance for this flight. The camera is triggered each time this distance is exceeded. This command can also be used to set the shutter integration time for the camera.")]
        DO_SET_CAM_TRIGG_DIST=206, 
        ///<summary> Mission command to enable the geofence |enable? (0=disable, 1=enable, 2=disable_floor_only)| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission command to enable the geofence")]
        DO_FENCE_ENABLE=207, 
        ///<summary> Mission item/command to release a parachute or enable/disable auto release. |Action| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission item/command to release a parachute or enable/disable auto release.")]
        DO_PARACHUTE=208, 
        ///<summary> Command to perform motor test. |Motor instance number (from 1 to max number of motors on the vehicle).| Throttle type (whether the Throttle Value in param3 is a percentage, PWM value, etc.)| Throttle value.| Timeout between tests that are run in sequence.| Motor count. Number of motors to test in sequence: 0/1=one motor, 2= two motors, etc. The Timeout (param4) is used between tests.| Motor test order.| Empty|  </summary>
        [Description("Command to perform motor test.")]
        DO_MOTOR_TEST=209, 
        ///<summary> Change to/from inverted flight. |Inverted flight. (0=normal, 1=inverted)| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Change to/from inverted flight.")]
        DO_INVERTED_FLIGHT=210, 
        ///<summary> Mission command to operate a gripper. |Gripper instance number.| Gripper action to perform.| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission command to operate a gripper.")]
        DO_GRIPPER=211, 
        ///<summary> Enable/disable autotune. |Enable (1: enable, 0:disable).| Specify which axis are autotuned. 0 indicates autopilot default settings.| Empty.| Empty.| Empty.| Empty.| Empty.|  </summary>
        [Description("Enable/disable autotune.")]
        DO_AUTOTUNE_ENABLE=212, 
        ///<summary> Sets a desired vehicle turn angle and speed change. |Yaw angle to adjust steering by.| Speed.| Final angle. (0=absolute, 1=relative)| Empty| Empty| Empty| Empty|  </summary>
        [Description("Sets a desired vehicle turn angle and speed change.")]
        SET_YAW_SPEED=213, 
        ///<summary> Mission command to set camera trigger interval for this flight. If triggering is enabled, the camera is triggered each time this interval expires. This command can also be used to set the shutter integration time for the camera. |Camera trigger cycle time. -1 or 0 to ignore.| Camera shutter integration time. Should be less than trigger cycle time. -1 or 0 to ignore.| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Mission command to set camera trigger interval for this flight. If triggering is enabled, the camera is triggered each time this interval expires. This command can also be used to set the shutter integration time for the camera.")]
        DO_SET_CAM_TRIGG_INTERVAL=214, 
        ///<summary> Mission command to control a camera or antenna mount, using a quaternion as reference. |quaternion param q1, w (1 in null-rotation)| quaternion param q2, x (0 in null-rotation)| quaternion param q3, y (0 in null-rotation)| quaternion param q4, z (0 in null-rotation)| Empty| Empty| Empty|  </summary>
        [Description("Mission command to control a camera or antenna mount, using a quaternion as reference.")]
        DO_MOUNT_CONTROL_QUAT=220, 
        ///<summary> set id of master controller |System ID| Component ID| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("set id of master controller")]
        DO_GUIDED_MASTER=221, 
        ///<summary> Set limits for external control |Timeout - maximum time that external controller will be allowed to control vehicle. 0 means no timeout.| Altitude (MSL) min - if vehicle moves below this alt, the command will be aborted and the mission will continue. 0 means no lower altitude limit.| Altitude (MSL) max - if vehicle moves above this alt, the command will be aborted and the mission will continue. 0 means no upper altitude limit.| Horizontal move limit - if vehicle moves more than this distance from its location at the moment the command was executed, the command will be aborted and the mission will continue. 0 means no horizontal move limit.| Empty| Empty| Empty|  </summary>
        [Description("Set limits for external control")]
        DO_GUIDED_LIMITS=222, 
        ///<summary> Control vehicle engine. This is interpreted by the vehicles engine controller to change the target engine state. It is intended for vehicles with internal combustion engines |0: Stop engine, 1:Start Engine| 0: Warm start, 1:Cold start. Controls use of choke where applicable| Height delay. This is for commanding engine start only after the vehicle has gained the specified height. Used in VTOL vehicles during takeoff to start engine after the aircraft is off the ground. Zero for no delay.| Empty| Empty| Empty| Empty|  </summary>
        [Description("Control vehicle engine. This is interpreted by the vehicles engine controller to change the target engine state. It is intended for vehicles with internal combustion engines")]
        DO_ENGINE_CONTROL=223, 
        ///<summary>            Set the mission item with sequence number seq as the current item and emit MISSION_CURRENT (whether or not the mission number changed).           If a mission is currently being executed, the system will continue to this new mission item on the shortest path, skipping any intermediate mission items. 	  Note that mission jump repeat counters are not reset unless param2 is set (see MAV_CMD_DO_JUMP param2).            This command may trigger a mission state-machine change on some systems: for example from MISSION_STATE_NOT_STARTED or MISSION_STATE_PAUSED to MISSION_STATE_ACTIVE.           If the system is in mission mode, on those systems this command might therefore start, restart or resume the mission.           If the system is not in mission mode this command must not trigger a switch to mission mode.            The mission may be 'reset' using param2.           Resetting sets jump counters to initial values (to reset counters without changing the current mission item set the param1 to `-1`).           Resetting also explicitly changes a mission state of MISSION_STATE_COMPLETE to MISSION_STATE_PAUSED or MISSION_STATE_ACTIVE, potentially allowing it to resume when it is (next) in a mission mode.  	  The command will ACK with MAV_RESULT_FAILED if the sequence number is out of range (including if there is no mission item).          |Mission sequence value to set. -1 for the current mission item (use to reset mission without changing current mission item).| Resets mission. 1: true, 0: false. Resets jump counters to initial values and changes mission state "completed" to be "active" or "paused".| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("           Set the mission item with sequence number seq as the current item and emit MISSION_CURRENT (whether or not the mission number changed).           If a mission is currently being executed, the system will continue to this new mission item on the shortest path, skipping any intermediate mission items. 	  Note that mission jump repeat counters are not reset unless param2 is set (see MAV_CMD_DO_JUMP param2).            This command may trigger a mission state-machine change on some systems: for example from MISSION_STATE_NOT_STARTED or MISSION_STATE_PAUSED to MISSION_STATE_ACTIVE.           If the system is in mission mode, on those systems this command might therefore start, restart or resume the mission.           If the system is not in mission mode this command must not trigger a switch to mission mode.            The mission may be 'reset' using param2.           Resetting sets jump counters to initial values (to reset counters without changing the current mission item set the param1 to `-1`).           Resetting also explicitly changes a mission state of MISSION_STATE_COMPLETE to MISSION_STATE_PAUSED or MISSION_STATE_ACTIVE, potentially allowing it to resume when it is (next) in a mission mode.  	  The command will ACK with MAV_RESULT_FAILED if the sequence number is out of range (including if there is no mission item).         ")]
        DO_SET_MISSION_CURRENT=224, 
        ///<summary> NOP - This command is only used to mark the upper limit of the DO commands in the enumeration |Empty| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("NOP - This command is only used to mark the upper limit of the DO commands in the enumeration")]
        DO_LAST=240, 
        ///<summary> Trigger calibration. This command will be only accepted if in pre-flight mode. Except for Temperature Calibration, only one sensor should be set in a single message and all others should be zero. |1: gyro calibration, 3: gyro temperature calibration| 1: magnetometer calibration| 1: ground pressure calibration| 1: radio RC calibration, 2: RC trim calibration| 1: accelerometer calibration, 2: board level calibration, 3: accelerometer temperature calibration, 4: simple accelerometer calibration| 1: APM: compass/motor interference calibration (PX4: airspeed calibration, deprecated), 2: airspeed calibration| 1: ESC calibration, 3: barometer temperature calibration|  </summary>
        [Description("Trigger calibration. This command will be only accepted if in pre-flight mode. Except for Temperature Calibration, only one sensor should be set in a single message and all others should be zero.")]
        PREFLIGHT_CALIBRATION=241, 
        ///<summary> Set sensor offsets. This command will be only accepted if in pre-flight mode. |Sensor to adjust the offsets for: 0: gyros, 1: accelerometer, 2: magnetometer, 3: barometer, 4: optical flow, 5: second magnetometer, 6: third magnetometer| X axis offset (or generic dimension 1), in the sensor's raw units| Y axis offset (or generic dimension 2), in the sensor's raw units| Z axis offset (or generic dimension 3), in the sensor's raw units| Generic dimension 4, in the sensor's raw units| Generic dimension 5, in the sensor's raw units| Generic dimension 6, in the sensor's raw units|  </summary>
        [Description("Set sensor offsets. This command will be only accepted if in pre-flight mode.")]
        PREFLIGHT_SET_SENSOR_OFFSETS=242, 
        ///<summary> Trigger UAVCAN configuration (actuator ID assignment and direction mapping). Note that this maps to the legacy UAVCAN v0 function UAVCAN_ENUMERATE, which is intended to be executed just once during initial vehicle configuration (it is not a normal pre-flight command and has been poorly named). |1: Trigger actuator ID assignment and direction mapping. 0: Cancel command.| Reserved| Reserved| Reserved| Reserved| Reserved| Reserved|  </summary>
        [Description("Trigger UAVCAN configuration (actuator ID assignment and direction mapping). Note that this maps to the legacy UAVCAN v0 function UAVCAN_ENUMERATE, which is intended to be executed just once during initial vehicle configuration (it is not a normal pre-flight command and has been poorly named).")]
        PREFLIGHT_UAVCAN=243, 
        ///<summary> Request storage of different parameter values and logs. This command will be only accepted if in pre-flight mode. |Action to perform on the persistent parameter storage| Action to perform on the persistent mission storage| Onboard logging: 0: Ignore, 1: Start default rate logging, -1: Stop logging, > 1: logging rate (e.g. set to 1000 for 1000 Hz logging)| Reserved| Empty| Empty| Empty|  </summary>
        [Description("Request storage of different parameter values and logs. This command will be only accepted if in pre-flight mode.")]
        PREFLIGHT_STORAGE=245, 
        ///<summary> Request the reboot or shutdown of system components. |0: Do nothing for autopilot, 1: Reboot autopilot, 2: Shutdown autopilot, 3: Reboot autopilot and keep it in the bootloader until upgraded.| 0: Do nothing for onboard computer, 1: Reboot onboard computer, 2: Shutdown onboard computer, 3: Reboot onboard computer and keep it in the bootloader until upgraded.| 0: Do nothing for component, 1: Reboot component, 2: Shutdown component, 3: Reboot component and keep it in the bootloader until upgraded| MAVLink Component ID targeted in param3 (0 for all components).| Reserved (set to 0)| Reserved (set to 0)| WIP: ID (e.g. camera ID -1 for all IDs)|  </summary>
        [Description("Request the reboot or shutdown of system components.")]
        PREFLIGHT_REBOOT_SHUTDOWN=246, 
        ///<summary> Override current mission with command to pause mission, pause mission and move to position, continue/resume mission. When param 1 indicates that the mission is paused (MAV_GOTO_DO_HOLD), param 2 defines whether it holds in place or moves to another position. |MAV_GOTO_DO_HOLD: pause mission and either hold or move to specified position (depending on param2), MAV_GOTO_DO_CONTINUE: resume mission.| MAV_GOTO_HOLD_AT_CURRENT_POSITION: hold at current position, MAV_GOTO_HOLD_AT_SPECIFIED_POSITION: hold at specified position.| Coordinate frame of hold point.| Desired yaw angle.| Latitude/X position.| Longitude/Y position.| Altitude/Z position.|  </summary>
        [Description("Override current mission with command to pause mission, pause mission and move to position, continue/resume mission. When param 1 indicates that the mission is paused (MAV_GOTO_DO_HOLD), param 2 defines whether it holds in place or moves to another position.")]
        OVERRIDE_GOTO=252, 
        ///<summary> Mission command to set a Camera Auto Mount Pivoting Oblique Survey (Replaces CAM_TRIGG_DIST for this purpose). The camera is triggered each time this distance is exceeded, then the mount moves to the next position. Params 4~6 set-up the angle limits and number of positions for oblique survey, where mount-enabled vehicles automatically roll the camera between shots to emulate an oblique camera setup (providing an increased HFOV). This command can also be used to set the shutter integration time for the camera. |Camera trigger distance. 0 to stop triggering.| Camera shutter integration time. 0 to ignore| The minimum interval in which the camera is capable of taking subsequent pictures repeatedly. 0 to ignore.| Total number of roll positions at which the camera will capture photos (images captures spread evenly across the limits defined by param5).| Angle limits that the camera can be rolled to left and right of center.| Fixed pitch angle that the camera will hold in oblique mode if the mount is actuated in the pitch axis.| Empty|  </summary>
        [Description("Mission command to set a Camera Auto Mount Pivoting Oblique Survey (Replaces CAM_TRIGG_DIST for this purpose). The camera is triggered each time this distance is exceeded, then the mount moves to the next position. Params 4~6 set-up the angle limits and number of positions for oblique survey, where mount-enabled vehicles automatically roll the camera between shots to emulate an oblique camera setup (providing an increased HFOV). This command can also be used to set the shutter integration time for the camera.")]
        OBLIQUE_SURVEY=260, 
        ///<summary> start running a mission |first_item: the first mission item to run| last_item:  the last mission item to run (after this item is run, the mission ends)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("start running a mission")]
        MISSION_START=300, 
        ///<summary> Actuator testing command. This is similar to MAV_CMD_DO_MOTOR_TEST but operates on the level of output functions, i.e. it is possible to test Motor1 independent from which output it is configured on. Autopilots typically refuse this command while armed. |Output value: 1 means maximum positive output, 0 to center servos or minimum motor thrust (expected to spin), -1 for maximum negative (if not supported by the motors, i.e. motor is not reversible, smaller than 0 maps to NaN). And NaN maps to disarmed (stop the motors).| Timeout after which the test command expires and the output is restored to the previous value. A timeout has to be set for safety reasons. A timeout of 0 means to restore the previous value immediately.| Reserved (default:0)| Reserved (default:0)| Actuator Output function| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Actuator testing command. This is similar to MAV_CMD_DO_MOTOR_TEST but operates on the level of output functions, i.e. it is possible to test Motor1 independent from which output it is configured on. Autopilots typically refuse this command while armed.")]
        ACTUATOR_TEST=310, 
        ///<summary> Actuator configuration command. |Actuator configuration action| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Actuator Output function| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Actuator configuration command.")]
        CONFIGURE_ACTUATOR=311, 
        ///<summary> Arms / Disarms a component |0: disarm, 1: arm| 0: arm-disarm unless prevented by safety checks (i.e. when landed), 21196: force arming/disarming (e.g. allow arming to override preflight checks and disarming in flight)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Arms / Disarms a component")]
        COMPONENT_ARM_DISARM=400, 
        ///<summary> Instructs a target system to run pre-arm checks.           This allows preflight checks to be run on demand, which may be useful on systems that normally run them at low rate, or which do not trigger checks when the armable state might have changed.           This command should return MAV_RESULT_ACCEPTED if it will run the checks.           The results of the checks are usually then reported in SYS_STATUS messages (this is system-specific).           The command should return MAV_RESULT_TEMPORARILY_REJECTED if the system is already armed.          |Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Instructs a target system to run pre-arm checks.           This allows preflight checks to be run on demand, which may be useful on systems that normally run them at low rate, or which do not trigger checks when the armable state might have changed.           This command should return MAV_RESULT_ACCEPTED if it will run the checks.           The results of the checks are usually then reported in SYS_STATUS messages (this is system-specific).           The command should return MAV_RESULT_TEMPORARILY_REJECTED if the system is already armed.         ")]
        RUN_PREARM_CHECKS=401, 
        ///<summary> Turns illuminators ON/OFF. An illuminator is a light source that is used for lighting up dark areas external to the sytstem: e.g. a torch or searchlight (as opposed to a light source for illuminating the system itself, e.g. an indicator light). |0: Illuminators OFF, 1: Illuminators ON| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Turns illuminators ON/OFF. An illuminator is a light source that is used for lighting up dark areas external to the sytstem: e.g. a torch or searchlight (as opposed to a light source for illuminating the system itself, e.g. an indicator light).")]
        ILLUMINATOR_ON_OFF=405, 
        ///<summary> Request the home position from the vehicle. 	  The vehicle will ACK the command and then emit the HOME_POSITION message. |Reserved| Reserved| Reserved| Reserved| Reserved| Reserved| Reserved|  </summary>
        [Description("Request the home position from the vehicle. 	  The vehicle will ACK the command and then emit the HOME_POSITION message.")]
        GET_HOME_POSITION=410, 
        ///<summary> Inject artificial failure for testing purposes. Note that autopilots should implement an additional protection before accepting this command such as a specific param setting. |The unit which is affected by the failure.| The type how the failure manifests itself.| Instance affected by failure (0 to signal all).| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Inject artificial failure for testing purposes. Note that autopilots should implement an additional protection before accepting this command such as a specific param setting.")]
        INJECT_FAILURE=420, 
        ///<summary> Starts receiver pairing. |0:Spektrum.| RC type.| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Starts receiver pairing.")]
        START_RX_PAIR=500, 
        ///<summary>            Request the interval between messages for a particular MAVLink message ID.           The receiver should ACK the command and then emit its response in a MESSAGE_INTERVAL message.          |The MAVLink message ID| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("           Request the interval between messages for a particular MAVLink message ID.           The receiver should ACK the command and then emit its response in a MESSAGE_INTERVAL message.         ")]
        GET_MESSAGE_INTERVAL=510, 
        ///<summary> Set the interval between messages for a particular MAVLink message ID. This interface replaces REQUEST_DATA_STREAM. |The MAVLink message ID| The interval between two messages. -1: disable. 0: request default rate (which may be zero).| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Target address of message stream (if message has target address fields). 0: Flight-stack default (recommended), 1: address of requestor, 2: broadcast.|  </summary>
        [Description("Set the interval between messages for a particular MAVLink message ID. This interface replaces REQUEST_DATA_STREAM.")]
        SET_MESSAGE_INTERVAL=511, 
        ///<summary> Request the target system(s) emit a single instance of a specified message (i.e. a 'one-shot' version of MAV_CMD_SET_MESSAGE_INTERVAL). |The MAVLink message ID of the requested message.| Use for index ID, if required. Otherwise, the use of this parameter (if any) must be defined in the requested message. By default assumed not used (0).| The use of this parameter (if any), must be defined in the requested message. By default assumed not used (0).| The use of this parameter (if any), must be defined in the requested message. By default assumed not used (0).| The use of this parameter (if any), must be defined in the requested message. By default assumed not used (0).| The use of this parameter (if any), must be defined in the requested message. By default assumed not used (0).| Target address for requested message (if message has target address fields). 0: Flight-stack default, 1: address of requestor, 2: broadcast.|  </summary>
        [Description("Request the target system(s) emit a single instance of a specified message (i.e. a 'one-shot' version of MAV_CMD_SET_MESSAGE_INTERVAL).")]
        REQUEST_MESSAGE=512, 
        ///<summary> Request MAVLink protocol version compatibility. All receivers should ACK the command and then emit their capabilities in an PROTOCOL_VERSION message |1: Request supported protocol versions by all nodes on the network| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request MAVLink protocol version compatibility. All receivers should ACK the command and then emit their capabilities in an PROTOCOL_VERSION message")]
        REQUEST_PROTOCOL_VERSION=519, 
        ///<summary> Request autopilot capabilities. The receiver should ACK the command and then emit its capabilities in an AUTOPILOT_VERSION message |1: Request autopilot version| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request autopilot capabilities. The receiver should ACK the command and then emit its capabilities in an AUTOPILOT_VERSION message")]
        REQUEST_AUTOPILOT_CAPABILITIES=520, 
        ///<summary> Request camera information (CAMERA_INFORMATION). |0: No action 1: Request camera capabilities| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request camera information (CAMERA_INFORMATION).")]
        REQUEST_CAMERA_INFORMATION=521, 
        ///<summary> Request camera settings (CAMERA_SETTINGS). |0: No Action 1: Request camera settings| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request camera settings (CAMERA_SETTINGS).")]
        REQUEST_CAMERA_SETTINGS=522, 
        ///<summary> Request storage information (STORAGE_INFORMATION). Use the command's target_component to target a specific component's storage. |Storage ID (0 for all, 1 for first, 2 for second, etc.)| 0: No Action 1: Request storage information| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request storage information (STORAGE_INFORMATION). Use the command's target_component to target a specific component's storage.")]
        REQUEST_STORAGE_INFORMATION=525, 
        ///<summary> Format a storage medium. Once format is complete, a STORAGE_INFORMATION message is sent. Use the command's target_component to target a specific component's storage. |Storage ID (1 for first, 2 for second, etc.)| Format storage (and reset image log). 0: No action 1: Format storage| Reset Image Log (without formatting storage medium). This will reset CAMERA_CAPTURE_STATUS.image_count and CAMERA_IMAGE_CAPTURED.image_index. 0: No action 1: Reset Image Log| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Format a storage medium. Once format is complete, a STORAGE_INFORMATION message is sent. Use the command's target_component to target a specific component's storage.")]
        STORAGE_FORMAT=526, 
        ///<summary> Request camera capture status (CAMERA_CAPTURE_STATUS) |0: No Action 1: Request camera capture status| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request camera capture status (CAMERA_CAPTURE_STATUS)")]
        REQUEST_CAMERA_CAPTURE_STATUS=527, 
        ///<summary> Request flight information (FLIGHT_INFORMATION) |1: Request flight information| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request flight information (FLIGHT_INFORMATION)")]
        REQUEST_FLIGHT_INFORMATION=528, 
        ///<summary> Reset all camera settings to Factory Default |0: No Action 1: Reset all settings| Reserved (all remaining params)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Reset all camera settings to Factory Default")]
        RESET_CAMERA_SETTINGS=529, 
        ///<summary> Set camera running mode. Use NaN for reserved values. GCS will send a MAV_CMD_REQUEST_VIDEO_STREAM_STATUS command after a mode change if the camera supports video streaming. |Reserved (Set to 0)| Camera mode| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:0)| Reserved (default:0)| Reserved (default:NaN)|  </summary>
        [Description("Set camera running mode. Use NaN for reserved values. GCS will send a MAV_CMD_REQUEST_VIDEO_STREAM_STATUS command after a mode change if the camera supports video streaming.")]
        SET_CAMERA_MODE=530, 
        ///<summary> Set camera zoom. Camera must respond with a CAMERA_SETTINGS message (on success). |Zoom type| Zoom value. The range of valid values depend on the zoom type.| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:0)| Reserved (default:0)| Reserved (default:NaN)|  </summary>
        [Description("Set camera zoom. Camera must respond with a CAMERA_SETTINGS message (on success).")]
        SET_CAMERA_ZOOM=531, 
        ///<summary> Set camera focus. Camera must respond with a CAMERA_SETTINGS message (on success). |Focus type| Focus value| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:0)| Reserved (default:0)| Reserved (default:NaN)|  </summary>
        [Description("Set camera focus. Camera must respond with a CAMERA_SETTINGS message (on success).")]
        SET_CAMERA_FOCUS=532, 
        ///<summary> Set that a particular storage is the preferred location for saving photos, videos, and/or other media (e.g. to set that an SD card is used for storing videos).           There can only be one preferred save location for each particular media type: setting a media usage flag will clear/reset that same flag if set on any other storage.           If no flag is set the system should use its default storage.           A target system can choose to always use default storage, in which case it should ACK the command with MAV_RESULT_UNSUPPORTED.           A target system can choose to not allow a particular storage to be set as preferred storage, in which case it should ACK the command with MAV_RESULT_DENIED. |Storage ID (1 for first, 2 for second, etc.)| Usage flags| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Set that a particular storage is the preferred location for saving photos, videos, and/or other media (e.g. to set that an SD card is used for storing videos).           There can only be one preferred save location for each particular media type: setting a media usage flag will clear/reset that same flag if set on any other storage.           If no flag is set the system should use its default storage.           A target system can choose to always use default storage, in which case it should ACK the command with MAV_RESULT_UNSUPPORTED.           A target system can choose to not allow a particular storage to be set as preferred storage, in which case it should ACK the command with MAV_RESULT_DENIED.")]
        SET_STORAGE_USAGE=533, 
        ///<summary> Tagged jump target. Can be jumped to with MAV_CMD_DO_JUMP_TAG. |Tag.| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Tagged jump target. Can be jumped to with MAV_CMD_DO_JUMP_TAG.")]
        JUMP_TAG=600, 
        ///<summary> Jump to the matching tag in the mission list. Repeat this action for the specified number of times. A mission should contain a single matching tag for each jump. If this is not the case then a jump to a missing tag should complete the mission, and a jump where there are multiple matching tags should always select the one with the lowest mission sequence number. |Target tag to jump to.| Repeat count.| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Jump to the matching tag in the mission list. Repeat this action for the specified number of times. A mission should contain a single matching tag for each jump. If this is not the case then a jump to a missing tag should complete the mission, and a jump where there are multiple matching tags should always select the one with the lowest mission sequence number.")]
        DO_JUMP_TAG=601, 
        ///<summary> Set gimbal manager pitch/yaw setpoints (low rate command). It is possible to set combinations of the values below. E.g. an angle as well as a desired angular rate can be used to get to this angle at a certain angular rate, or an angular rate only will result in continuous turning. NaN is to be used to signal unset. Note: only the gimbal manager will react to this command - it will be ignored by a gimbal device. Use GIMBAL_MANAGER_SET_PITCHYAW if you need to stream pitch/yaw setpoints at higher rate.  |Pitch angle (positive to pitch up, relative to vehicle for FOLLOW mode, relative to world horizon for LOCK mode).| Yaw angle (positive to yaw to the right, relative to vehicle for FOLLOW mode, absolute to North for LOCK mode).| Pitch rate (positive to pitch up).| Yaw rate (positive to yaw to the right).| Gimbal manager flags to use.| Reserved (default:0)| Component ID of gimbal device to address (or 1-6 for non-MAVLink gimbal), 0 for all gimbal device components. Send command multiple times for more than one gimbal (but not all gimbals).|  </summary>
        [Description("Set gimbal manager pitch/yaw setpoints (low rate command). It is possible to set combinations of the values below. E.g. an angle as well as a desired angular rate can be used to get to this angle at a certain angular rate, or an angular rate only will result in continuous turning. NaN is to be used to signal unset. Note: only the gimbal manager will react to this command - it will be ignored by a gimbal device. Use GIMBAL_MANAGER_SET_PITCHYAW if you need to stream pitch/yaw setpoints at higher rate. ")]
        DO_GIMBAL_MANAGER_PITCHYAW=1000, 
        ///<summary> Gimbal configuration to set which sysid/compid is in primary and secondary control. |Sysid for primary control (0: no one in control, -1: leave unchanged, -2: set itself in control (for missions where the own sysid is still unknown), -3: remove control if currently in control).| Compid for primary control (0: no one in control, -1: leave unchanged, -2: set itself in control (for missions where the own sysid is still unknown), -3: remove control if currently in control).| Sysid for secondary control (0: no one in control, -1: leave unchanged, -2: set itself in control (for missions where the own sysid is still unknown), -3: remove control if currently in control).| Compid for secondary control (0: no one in control, -1: leave unchanged, -2: set itself in control (for missions where the own sysid is still unknown), -3: remove control if currently in control).| Reserved (default:0)| Reserved (default:0)| Component ID of gimbal device to address (or 1-6 for non-MAVLink gimbal), 0 for all gimbal device components. Send command multiple times for more than one gimbal (but not all gimbals).|  </summary>
        [Description("Gimbal configuration to set which sysid/compid is in primary and secondary control.")]
        DO_GIMBAL_MANAGER_CONFIGURE=1001, 
        ///<summary> Start image capture sequence. Sends CAMERA_IMAGE_CAPTURED after each capture. Use NaN for reserved values. |Reserved (Set to 0)| Desired elapsed time between two consecutive pictures (in seconds). Minimum values depend on hardware (typically greater than 2 seconds).| Total number of images to capture. 0 to capture forever/until MAV_CMD_IMAGE_STOP_CAPTURE.| Capture sequence number starting from 1. This is only valid for single-capture (param3 == 1), otherwise set to 0. Increment the capture ID for each capture command to prevent double captures when a command is re-transmitted.| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)|  </summary>
        [Description("Start image capture sequence. Sends CAMERA_IMAGE_CAPTURED after each capture. Use NaN for reserved values.")]
        IMAGE_START_CAPTURE=2000, 
        ///<summary> Stop image capture sequence Use NaN for reserved values. |Reserved (Set to 0)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:0)| Reserved (default:0)| Reserved (default:NaN)|  </summary>
        [Description("Stop image capture sequence Use NaN for reserved values.")]
        IMAGE_STOP_CAPTURE=2001, 
        ///<summary> Re-request a CAMERA_IMAGE_CAPTURED message. |Sequence number for missing CAMERA_IMAGE_CAPTURED message| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:0)| Reserved (default:0)| Reserved (default:NaN)|  </summary>
        [Description("Re-request a CAMERA_IMAGE_CAPTURED message.")]
        REQUEST_CAMERA_IMAGE_CAPTURE=2002, 
        ///<summary> Enable or disable on-board camera triggering system. |Trigger enable/disable (0 for disable, 1 for start), -1 to ignore| 1 to reset the trigger sequence, -1 or 0 to ignore| 1 to pause triggering, but without switching the camera off or retracting it. -1 to ignore| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Enable or disable on-board camera triggering system.")]
        DO_TRIGGER_CONTROL=2003, 
        ///<summary> If the camera supports point visual tracking (CAMERA_CAP_FLAGS_HAS_TRACKING_POINT is set), this command allows to initiate the tracking. |Point to track x value (normalized 0..1, 0 is left, 1 is right).| Point to track y value (normalized 0..1, 0 is top, 1 is bottom).| Point radius (normalized 0..1, 0 is image left, 1 is image right).| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("If the camera supports point visual tracking (CAMERA_CAP_FLAGS_HAS_TRACKING_POINT is set), this command allows to initiate the tracking.")]
        CAMERA_TRACK_POINT=2004, 
        ///<summary> If the camera supports rectangle visual tracking (CAMERA_CAP_FLAGS_HAS_TRACKING_RECTANGLE is set), this command allows to initiate the tracking. |Top left corner of rectangle x value (normalized 0..1, 0 is left, 1 is right).| Top left corner of rectangle y value (normalized 0..1, 0 is top, 1 is bottom).| Bottom right corner of rectangle x value (normalized 0..1, 0 is left, 1 is right).| Bottom right corner of rectangle y value (normalized 0..1, 0 is top, 1 is bottom).| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("If the camera supports rectangle visual tracking (CAMERA_CAP_FLAGS_HAS_TRACKING_RECTANGLE is set), this command allows to initiate the tracking.")]
        CAMERA_TRACK_RECTANGLE=2005, 
        ///<summary> Stops ongoing tracking. |Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Stops ongoing tracking.")]
        CAMERA_STOP_TRACKING=2010, 
        ///<summary> Starts video capture (recording). |Video Stream ID (0 for all streams)| Frequency CAMERA_CAPTURE_STATUS messages should be sent while recording (0 for no messages, otherwise frequency)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)|  </summary>
        [Description("Starts video capture (recording).")]
        VIDEO_START_CAPTURE=2500, 
        ///<summary> Stop the current video capture (recording). |Video Stream ID (0 for all streams)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)|  </summary>
        [Description("Stop the current video capture (recording).")]
        VIDEO_STOP_CAPTURE=2501, 
        ///<summary> Start video streaming |Video Stream ID (0 for all streams, 1 for first, 2 for second, etc.)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Start video streaming")]
        VIDEO_START_STREAMING=2502, 
        ///<summary> Stop the given video stream |Video Stream ID (0 for all streams, 1 for first, 2 for second, etc.)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Stop the given video stream")]
        VIDEO_STOP_STREAMING=2503, 
        ///<summary> Request video stream information (VIDEO_STREAM_INFORMATION) |Video Stream ID (0 for all streams, 1 for first, 2 for second, etc.)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request video stream information (VIDEO_STREAM_INFORMATION)")]
        REQUEST_VIDEO_STREAM_INFORMATION=2504, 
        ///<summary> Request video stream status (VIDEO_STREAM_STATUS) |Video Stream ID (0 for all streams, 1 for first, 2 for second, etc.)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request video stream status (VIDEO_STREAM_STATUS)")]
        REQUEST_VIDEO_STREAM_STATUS=2505, 
        ///<summary> Request to start streaming logging data over MAVLink (see also LOGGING_DATA message) |Format: 0: ULog| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)|  </summary>
        [Description("Request to start streaming logging data over MAVLink (see also LOGGING_DATA message)")]
        LOGGING_START=2510, 
        ///<summary> Request to stop streaming log data over MAVLink |Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)|  </summary>
        [Description("Request to stop streaming log data over MAVLink")]
        LOGGING_STOP=2511, 
        ///<summary>  |Landing gear ID (default: 0, -1 for all)| Landing gear position (Down: 0, Up: 1, NaN for no change)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)| Reserved (default:NaN)|  </summary>
        [Description("")]
        AIRFRAME_CONFIGURATION=2520, 
        ///<summary> Request to start/stop transmitting over the high latency telemetry |Control transmission over high latency telemetry (0: stop, 1: start)| Empty| Empty| Empty| Empty| Empty| Empty|  </summary>
        [Description("Request to start/stop transmitting over the high latency telemetry")]
        CONTROL_HIGH_LATENCY=2600, 
        ///<summary> Create a panorama at the current position |Viewing angle horizontal of the panorama (+- 0.5 the total angle)| Viewing angle vertical of panorama.| Speed of the horizontal rotation.| Speed of the vertical rotation.| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Create a panorama at the current position")]
        PANORAMA_CREATE=2800, 
        ///<summary> Request VTOL transition |The target VTOL state. For normal transitions, only MAV_VTOL_STATE_MC and MAV_VTOL_STATE_FW can be used.| Force immediate transition to the specified MAV_VTOL_STATE. 1: Force immediate, 0: normal transition. Can be used, for example, to trigger an emergency "Quadchute". Caution: Can be dangerous/damage vehicle, depending on autopilot implementation of this command.| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request VTOL transition")]
        DO_VTOL_TRANSITION=3000, 
        ///<summary> Request authorization to arm the vehicle to a external entity, the arm authorizer is responsible to request all data that is needs from the vehicle before authorize or deny the request. 		If approved the COMMAND_ACK message progress field should be set with period of time that this authorization is valid in seconds. 		If the authorization is denied COMMAND_ACK.result_param2 should be set with one of the reasons in ARM_AUTH_DENIED_REASON.          |Vehicle system id, this way ground station can request arm authorization on behalf of any vehicle| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("Request authorization to arm the vehicle to a external entity, the arm authorizer is responsible to request all data that is needs from the vehicle before authorize or deny the request. 		If approved the COMMAND_ACK message progress field should be set with period of time that this authorization is valid in seconds. 		If the authorization is denied COMMAND_ACK.result_param2 should be set with one of the reasons in ARM_AUTH_DENIED_REASON.         ")]
        ARM_AUTHORIZATION_REQUEST=3001, 
        ///<summary> This command sets the submode to standard guided when vehicle is in guided mode. The vehicle holds position and altitude and the user can input the desired velocities along all three axes.                    |Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)| Reserved (default:0)|  </summary>
        [Description("This command sets the submode to standard guided when vehicle is in guided mode. The vehicle holds position and altitude and the user can input the desired velocities along all three axes.                   ")]
        SET_GUIDED_SUBMODE_STANDARD=4000, 
        ///<summary> This command sets submode circle when vehicle is in guided mode. Vehicle flies along a circle facing the center of the circle. The user can input the velocity along the circle and change the radius. If no input is given the vehicle will hold position.                    |Radius of desired circle in CIRCLE_MODE| User defined| User defined| User defined| Target latitude of center of circle in CIRCLE_MODE| Target longitude of center of circle in CIRCLE_MODE| Reserved (default:0)|  </summary>
        [Description("This command sets submode circle when vehicle is in guided mode. Vehicle flies along a circle facing the center of the circle. The user can input the velocity along the circle and change the radius. If no input is given the vehicle will hold position.                   ")]
        SET_GUIDED_SUBMODE_CIRCLE=4001, 
        ///<summary> Delay mission state machine until gate has been reached. |Geometry: 0: orthogonal to path between previous and next waypoint.| Altitude: 0: ignore altitude| Empty| Empty| Latitude| Longitude| Altitude|  </summary>
        [Description("Delay mission state machine until gate has been reached.")]
        CONDITION_GATE=4501, 
        ///<summary> Fence return point (there can only be one such point in a geofence definition). If rally points are supported they should be used instead. |Reserved| Reserved| Reserved| Reserved| Latitude| Longitude| Altitude|  </summary>
        [Description("Fence return point (there can only be one such point in a geofence definition). If rally points are supported they should be used instead.")]
        FENCE_RETURN_POINT=5000, 
        ///<summary> Fence vertex for an inclusion polygon (the polygon must not be self-intersecting). The vehicle must stay within this area. Minimum of 3 vertices required.          |Polygon vertex count| Vehicle must be inside ALL inclusion zones in a single group, vehicle must be inside at least one group, must be the same for all points in each polygon| Reserved| Reserved| Latitude| Longitude| Reserved|  </summary>
        [Description("Fence vertex for an inclusion polygon (the polygon must not be self-intersecting). The vehicle must stay within this area. Minimum of 3 vertices required.         ")]
        FENCE_POLYGON_VERTEX_INCLUSION=5001, 
        ///<summary> Fence vertex for an exclusion polygon (the polygon must not be self-intersecting). The vehicle must stay outside this area. Minimum of 3 vertices required.          |Polygon vertex count| Reserved| Reserved| Reserved| Latitude| Longitude| Reserved|  </summary>
        [Description("Fence vertex for an exclusion polygon (the polygon must not be self-intersecting). The vehicle must stay outside this area. Minimum of 3 vertices required.         ")]
        FENCE_POLYGON_VERTEX_EXCLUSION=5002, 
        ///<summary> Circular fence area. The vehicle must stay inside this area.          |Radius.| Vehicle must be inside ALL inclusion zones in a single group, vehicle must be inside at least one group| Reserved| Reserved| Latitude| Longitude| Reserved|  </summary>
        [Description("Circular fence area. The vehicle must stay inside this area.         ")]
        FENCE_CIRCLE_INCLUSION=5003, 
        ///<summary> Circular fence area. The vehicle must stay outside this area.          |Radius.| Reserved| Reserved| Reserved| Latitude| Longitude| Reserved|  </summary>
        [Description("Circular fence area. The vehicle must stay outside this area.         ")]
        FENCE_CIRCLE_EXCLUSION=5004, 
        ///<summary> Rally point. You can have multiple rally points defined.          |Reserved| Reserved| Reserved| Reserved| Latitude| Longitude| Altitude|  </summary>
        [Description("Rally point. You can have multiple rally points defined.         ")]
        RALLY_POINT=5100, 
        ///<summary> Commands the vehicle to respond with a sequence of messages UAVCAN_NODE_INFO, one message per every UAVCAN node that is online. Note that some of the response messages can be lost, which the receiver can detect easily by checking whether every received UAVCAN_NODE_STATUS has a matching message UAVCAN_NODE_INFO received earlier; if not, this command should be sent again in order to request re-transmission of the node information messages. |Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)|  </summary>
        [Description("Commands the vehicle to respond with a sequence of messages UAVCAN_NODE_INFO, one message per every UAVCAN node that is online. Note that some of the response messages can be lost, which the receiver can detect easily by checking whether every received UAVCAN_NODE_STATUS has a matching message UAVCAN_NODE_INFO received earlier; if not, this command should be sent again in order to request re-transmission of the node information messages.")]
        UAVCAN_GET_NODE_INFO=5200, 
        ///<summary> Trigger the start of an ADSB-out IDENT. This should only be used when requested to do so by an Air Traffic Controller in controlled airspace. This starts the IDENT which is then typically held for 18 seconds by the hardware per the Mode A, C, and S transponder spec. |Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)| Reserved (set to 0)|  </summary>
        [Description("Trigger the start of an ADSB-out IDENT. This should only be used when requested to do so by an Air Traffic Controller in controlled airspace. This starts the IDENT which is then typically held for 18 seconds by the hardware per the Mode A, C, and S transponder spec.")]
        DO_ADSB_OUT_IDENT=10001, 
        ///<summary> Deploy payload on a Lat / Lon / Alt position. This includes the navigation to reach the required release position and velocity. |Operation mode. 0: prepare single payload deploy (overwriting previous requests), but do not execute it. 1: execute payload deploy immediately (rejecting further deploy commands during execution, but allowing abort). 2: add payload deploy to existing deployment list.| Desired approach vector in compass heading. A negative value indicates the system can define the approach vector at will.| Desired ground speed at release time. This can be overridden by the airframe in case it needs to meet minimum airspeed. A negative value indicates the system can define the ground speed at will.| Minimum altitude clearance to the release position. A negative value indicates the system can define the clearance at will.| Latitude. Note, if used in MISSION_ITEM (deprecated) the units are degrees (unscaled)| Longitude. Note, if used in MISSION_ITEM (deprecated) the units are degrees (unscaled)| Altitude (MSL)|  </summary>
        [Description("Deploy payload on a Lat / Lon / Alt position. This includes the navigation to reach the required release position and velocity.")]
        PAYLOAD_PREPARE_DEPLOY=30001, 
        ///<summary> Control the payload deployment. |Operation mode. 0: Abort deployment, continue normal mission. 1: switch to payload deployment mode. 100: delete first payload deployment request. 101: delete all payload deployment requests.| Reserved| Reserved| Reserved| Reserved| Reserved| Reserved|  </summary>
        [Description("Control the payload deployment.")]
        PAYLOAD_CONTROL_DEPLOY=30002, 
        ///<summary> User defined waypoint item. Ground Station will show the Vehicle as flying through this item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined waypoint item. Ground Station will show the Vehicle as flying through this item.")]
        WAYPOINT_USER_1=31000, 
        ///<summary> User defined waypoint item. Ground Station will show the Vehicle as flying through this item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined waypoint item. Ground Station will show the Vehicle as flying through this item.")]
        WAYPOINT_USER_2=31001, 
        ///<summary> User defined waypoint item. Ground Station will show the Vehicle as flying through this item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined waypoint item. Ground Station will show the Vehicle as flying through this item.")]
        WAYPOINT_USER_3=31002, 
        ///<summary> User defined waypoint item. Ground Station will show the Vehicle as flying through this item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined waypoint item. Ground Station will show the Vehicle as flying through this item.")]
        WAYPOINT_USER_4=31003, 
        ///<summary> User defined waypoint item. Ground Station will show the Vehicle as flying through this item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined waypoint item. Ground Station will show the Vehicle as flying through this item.")]
        WAYPOINT_USER_5=31004, 
        ///<summary> User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item.")]
        SPATIAL_USER_1=31005, 
        ///<summary> User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item.")]
        SPATIAL_USER_2=31006, 
        ///<summary> User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item.")]
        SPATIAL_USER_3=31007, 
        ///<summary> User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item.")]
        SPATIAL_USER_4=31008, 
        ///<summary> User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item. |User defined| User defined| User defined| User defined| Latitude unscaled| Longitude unscaled| Altitude (MSL)|  </summary>
        [Description("User defined spatial item. Ground Station will not show the Vehicle as flying through this item. Example: ROI item.")]
        SPATIAL_USER_5=31009, 
        ///<summary> User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item. |User defined| User defined| User defined| User defined| User defined| User defined| User defined|  </summary>
        [Description("User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item.")]
        USER_1=31010, 
        ///<summary> User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item. |User defined| User defined| User defined| User defined| User defined| User defined| User defined|  </summary>
        [Description("User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item.")]
        USER_2=31011, 
        ///<summary> User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item. |User defined| User defined| User defined| User defined| User defined| User defined| User defined|  </summary>
        [Description("User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item.")]
        USER_3=31012, 
        ///<summary> User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item. |User defined| User defined| User defined| User defined| User defined| User defined| User defined|  </summary>
        [Description("User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item.")]
        USER_4=31013, 
        ///<summary> User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item. |User defined| User defined| User defined| User defined| User defined| User defined| User defined|  </summary>
        [Description("User defined command. Ground Station will not show the Vehicle as flying through this item. Example: MAV_CMD_DO_SET_PARAMETER item.")]
        USER_5=31014, 
        ///<summary> Request forwarding of CAN packets from the given CAN bus to this component. CAN Frames are sent using CAN_FRAME and CANFD_FRAME messages |Bus number (0 to disable forwarding, 1 for first bus, 2 for 2nd bus, 3 for 3rd bus).| Empty.| Empty.| Empty.| Empty.| Empty.| Empty.|  </summary>
        [Description("Request forwarding of CAN packets from the given CAN bus to this component. CAN Frames are sent using CAN_FRAME and CANFD_FRAME messages")]
        CAN_FORWARD=32000, 
        ///<summary> Magnetometer calibration based on provided known yaw. This allows for fast calibration using WMM field tables in the vehicle, given only the known yaw of the vehicle. If Latitude and longitude are both zero then use the current vehicle location. |Yaw of vehicle in earth frame.| CompassMask, 0 for all.| Latitude.| Longitude.| Empty.| Empty.| Empty.|  </summary>
        [Description("Magnetometer calibration based on provided known yaw. This allows for fast calibration using WMM field tables in the vehicle, given only the known yaw of the vehicle. If Latitude and longitude are both zero then use the current vehicle location.")]
        FIXED_MAG_CAL_YAW=42006, 
        ///<summary> Command to operate winch. |Winch instance number.| Action to perform.| Length of line to release (negative to wind).| Release rate (negative to wind).| Empty.| Empty.| Empty.|  </summary>
        [Description("Command to operate winch.")]
        DO_WINCH=42600, 
        
    };
    
    ///<summary> A data stream is not a fixed set of messages, but rather a      recommendation to the autopilot software. Individual autopilots may or may not obey      the recommended messages. </summary>
    public enum MAV_DATA_STREAM: int /*default*/
    {
        ///<summary> Enable all data streams | </summary>
        [Description("Enable all data streams")]
        ALL=0, 
        ///<summary> Enable IMU_RAW, GPS_RAW, GPS_STATUS packets. | </summary>
        [Description("Enable IMU_RAW, GPS_RAW, GPS_STATUS packets.")]
        RAW_SENSORS=1, 
        ///<summary> Enable GPS_STATUS, CONTROL_STATUS, AUX_STATUS | </summary>
        [Description("Enable GPS_STATUS, CONTROL_STATUS, AUX_STATUS")]
        EXTENDED_STATUS=2, 
        ///<summary> Enable RC_CHANNELS_SCALED, RC_CHANNELS_RAW, SERVO_OUTPUT_RAW | </summary>
        [Description("Enable RC_CHANNELS_SCALED, RC_CHANNELS_RAW, SERVO_OUTPUT_RAW")]
        RC_CHANNELS=3, 
        ///<summary> Enable ATTITUDE_CONTROLLER_OUTPUT, POSITION_CONTROLLER_OUTPUT, NAV_CONTROLLER_OUTPUT. | </summary>
        [Description("Enable ATTITUDE_CONTROLLER_OUTPUT, POSITION_CONTROLLER_OUTPUT, NAV_CONTROLLER_OUTPUT.")]
        RAW_CONTROLLER=4, 
        ///<summary> Enable LOCAL_POSITION, GLOBAL_POSITION_INT messages. | </summary>
        [Description("Enable LOCAL_POSITION, GLOBAL_POSITION_INT messages.")]
        POSITION=6, 
        ///<summary> Dependent on the autopilot | </summary>
        [Description("Dependent on the autopilot")]
        EXTRA1=10, 
        ///<summary> Dependent on the autopilot | </summary>
        [Description("Dependent on the autopilot")]
        EXTRA2=11, 
        ///<summary> Dependent on the autopilot | </summary>
        [Description("Dependent on the autopilot")]
        EXTRA3=12, 
        
    };
    
    ///<summary> The ROI (region of interest) for the vehicle. This can be                 be used by the vehicle for camera/vehicle attitude alignment (see                 MAV_CMD_NAV_ROI). </summary>
    public enum MAV_ROI: int /*default*/
    {
        ///<summary> No region of interest. | </summary>
        [Description("No region of interest.")]
        NONE=0, 
        ///<summary> Point toward next waypoint, with optional pitch/roll/yaw offset. | </summary>
        [Description("Point toward next waypoint, with optional pitch/roll/yaw offset.")]
        WPNEXT=1, 
        ///<summary> Point toward given waypoint. | </summary>
        [Description("Point toward given waypoint.")]
        WPINDEX=2, 
        ///<summary> Point toward fixed location. | </summary>
        [Description("Point toward fixed location.")]
        LOCATION=3, 
        ///<summary> Point toward of given id. | </summary>
        [Description("Point toward of given id.")]
        TARGET=4, 
        
    };
    
    ///<summary> Specifies the datatype of a MAVLink parameter. </summary>
    public enum MAV_PARAM_TYPE: byte
    {
        ///<summary> 8-bit unsigned integer | </summary>
        [Description("8-bit unsigned integer")]
        UINT8=1, 
        ///<summary> 8-bit signed integer | </summary>
        [Description("8-bit signed integer")]
        INT8=2, 
        ///<summary> 16-bit unsigned integer | </summary>
        [Description("16-bit unsigned integer")]
        UINT16=3, 
        ///<summary> 16-bit signed integer | </summary>
        [Description("16-bit signed integer")]
        INT16=4, 
        ///<summary> 32-bit unsigned integer | </summary>
        [Description("32-bit unsigned integer")]
        UINT32=5, 
        ///<summary> 32-bit signed integer | </summary>
        [Description("32-bit signed integer")]
        INT32=6, 
        ///<summary> 64-bit unsigned integer | </summary>
        [Description("64-bit unsigned integer")]
        UINT64=7, 
        ///<summary> 64-bit signed integer | </summary>
        [Description("64-bit signed integer")]
        INT64=8, 
        ///<summary> 32-bit floating-point | </summary>
        [Description("32-bit floating-point")]
        REAL32=9, 
        ///<summary> 64-bit floating-point | </summary>
        [Description("64-bit floating-point")]
        REAL64=10, 
        
    };
    
    ///<summary> Specifies the datatype of a MAVLink extended parameter. </summary>
    public enum MAV_PARAM_EXT_TYPE: int /*default*/
    {
        ///<summary> 8-bit unsigned integer | </summary>
        [Description("8-bit unsigned integer")]
        UINT8=1, 
        ///<summary> 8-bit signed integer | </summary>
        [Description("8-bit signed integer")]
        INT8=2, 
        ///<summary> 16-bit unsigned integer | </summary>
        [Description("16-bit unsigned integer")]
        UINT16=3, 
        ///<summary> 16-bit signed integer | </summary>
        [Description("16-bit signed integer")]
        INT16=4, 
        ///<summary> 32-bit unsigned integer | </summary>
        [Description("32-bit unsigned integer")]
        UINT32=5, 
        ///<summary> 32-bit signed integer | </summary>
        [Description("32-bit signed integer")]
        INT32=6, 
        ///<summary> 64-bit unsigned integer | </summary>
        [Description("64-bit unsigned integer")]
        UINT64=7, 
        ///<summary> 64-bit signed integer | </summary>
        [Description("64-bit signed integer")]
        INT64=8, 
        ///<summary> 32-bit floating-point | </summary>
        [Description("32-bit floating-point")]
        REAL32=9, 
        ///<summary> 64-bit floating-point | </summary>
        [Description("64-bit floating-point")]
        REAL64=10, 
        ///<summary> Custom Type | </summary>
        [Description("Custom Type")]
        CUSTOM=11, 
        
    };
    
    ///<summary> Result from a MAVLink command (MAV_CMD) </summary>
    public enum MAV_RESULT: byte
    {
        ///<summary> Command is valid (is supported and has valid parameters), and was executed. | </summary>
        [Description("Command is valid (is supported and has valid parameters), and was executed.")]
        ACCEPTED=0, 
        ///<summary> Command is valid, but cannot be executed at this time. This is used to indicate a problem that should be fixed just by waiting (e.g. a state machine is busy, can't arm because have not got GPS lock, etc.). Retrying later should work. | </summary>
        [Description("Command is valid, but cannot be executed at this time. This is used to indicate a problem that should be fixed just by waiting (e.g. a state machine is busy, can't arm because have not got GPS lock, etc.). Retrying later should work.")]
        TEMPORARILY_REJECTED=1, 
        ///<summary> Command is invalid (is supported but has invalid parameters). Retrying same command and parameters will not work. | </summary>
        [Description("Command is invalid (is supported but has invalid parameters). Retrying same command and parameters will not work.")]
        DENIED=2, 
        ///<summary> Command is not supported (unknown). | </summary>
        [Description("Command is not supported (unknown).")]
        UNSUPPORTED=3, 
        ///<summary> Command is valid, but execution has failed. This is used to indicate any non-temporary or unexpected problem, i.e. any problem that must be fixed before the command can succeed/be retried. For example, attempting to write a file when out of memory, attempting to arm when sensors are not calibrated, etc. | </summary>
        [Description("Command is valid, but execution has failed. This is used to indicate any non-temporary or unexpected problem, i.e. any problem that must be fixed before the command can succeed/be retried. For example, attempting to write a file when out of memory, attempting to arm when sensors are not calibrated, etc.")]
        FAILED=4, 
        ///<summary> Command is valid and is being executed. This will be followed by further progress updates, i.e. the component may send further COMMAND_ACK messages with result MAV_RESULT_IN_PROGRESS (at a rate decided by the implementation), and must terminate by sending a COMMAND_ACK message with final result of the operation. The COMMAND_ACK.progress field can be used to indicate the progress of the operation. | </summary>
        [Description("Command is valid and is being executed. This will be followed by further progress updates, i.e. the component may send further COMMAND_ACK messages with result MAV_RESULT_IN_PROGRESS (at a rate decided by the implementation), and must terminate by sending a COMMAND_ACK message with final result of the operation. The COMMAND_ACK.progress field can be used to indicate the progress of the operation.")]
        IN_PROGRESS=5, 
        ///<summary> Command has been cancelled (as a result of receiving a COMMAND_CANCEL message). | </summary>
        [Description("Command has been cancelled (as a result of receiving a COMMAND_CANCEL message).")]
        CANCELLED=6, 
        ///<summary> Command is valid, but it is only accepted when sent as a COMMAND_LONG (as it has float values for params 5 and 6). | </summary>
        [Description("Command is valid, but it is only accepted when sent as a COMMAND_LONG (as it has float values for params 5 and 6).")]
        COMMAND_LONG_ONLY=7, 
        ///<summary> Command is valid, but it is only accepted when sent as a COMMAND_INT (as it encodes a location in params 5, 6 and 7, and hence requires a reference MAV_FRAME). | </summary>
        [Description("Command is valid, but it is only accepted when sent as a COMMAND_INT (as it encodes a location in params 5, 6 and 7, and hence requires a reference MAV_FRAME).")]
        COMMAND_INT_ONLY=8, 
        
    };
    
    ///<summary> Result of mission operation (in a MISSION_ACK message). </summary>
    public enum MAV_MISSION_RESULT: byte
    {
        ///<summary> mission accepted OK | </summary>
        [Description("mission accepted OK")]
        MAV_MISSION_ACCEPTED=0, 
        ///<summary> Generic error / not accepting mission commands at all right now. | </summary>
        [Description("Generic error / not accepting mission commands at all right now.")]
        MAV_MISSION_ERROR=1, 
        ///<summary> Coordinate frame is not supported. | </summary>
        [Description("Coordinate frame is not supported.")]
        MAV_MISSION_UNSUPPORTED_FRAME=2, 
        ///<summary> Command is not supported. | </summary>
        [Description("Command is not supported.")]
        MAV_MISSION_UNSUPPORTED=3, 
        ///<summary> Mission items exceed storage space. | </summary>
        [Description("Mission items exceed storage space.")]
        MAV_MISSION_NO_SPACE=4, 
        ///<summary> One of the parameters has an invalid value. | </summary>
        [Description("One of the parameters has an invalid value.")]
        MAV_MISSION_INVALID=5, 
        ///<summary> param1 has an invalid value. | </summary>
        [Description("param1 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM1=6, 
        ///<summary> param2 has an invalid value. | </summary>
        [Description("param2 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM2=7, 
        ///<summary> param3 has an invalid value. | </summary>
        [Description("param3 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM3=8, 
        ///<summary> param4 has an invalid value. | </summary>
        [Description("param4 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM4=9, 
        ///<summary> x / param5 has an invalid value. | </summary>
        [Description("x / param5 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM5_X=10, 
        ///<summary> y / param6 has an invalid value. | </summary>
        [Description("y / param6 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM6_Y=11, 
        ///<summary> z / param7 has an invalid value. | </summary>
        [Description("z / param7 has an invalid value.")]
        MAV_MISSION_INVALID_PARAM7=12, 
        ///<summary> Mission item received out of sequence | </summary>
        [Description("Mission item received out of sequence")]
        MAV_MISSION_INVALID_SEQUENCE=13, 
        ///<summary> Not accepting any mission commands from this communication partner. | </summary>
        [Description("Not accepting any mission commands from this communication partner.")]
        MAV_MISSION_DENIED=14, 
        ///<summary> Current mission operation cancelled (e.g. mission upload, mission download). | </summary>
        [Description("Current mission operation cancelled (e.g. mission upload, mission download).")]
        MAV_MISSION_OPERATION_CANCELLED=15, 
        
    };
    
    ///<summary> Indicates the severity level, generally used for status messages to indicate their relative urgency. Based on RFC-5424 using expanded definitions at: http://www.kiwisyslog.com/kb/info:-syslog-message-levels/. </summary>
    public enum MAV_SEVERITY: byte
    {
        ///<summary> System is unusable. This is a 'panic' condition. | </summary>
        [Description("System is unusable. This is a 'panic' condition.")]
        EMERGENCY=0, 
        ///<summary> Action should be taken immediately. Indicates error in non-critical systems. | </summary>
        [Description("Action should be taken immediately. Indicates error in non-critical systems.")]
        ALERT=1, 
        ///<summary> Action must be taken immediately. Indicates failure in a primary system. | </summary>
        [Description("Action must be taken immediately. Indicates failure in a primary system.")]
        CRITICAL=2, 
        ///<summary> Indicates an error in secondary/redundant systems. | </summary>
        [Description("Indicates an error in secondary/redundant systems.")]
        ERROR=3, 
        ///<summary> Indicates about a possible future error if this is not resolved within a given timeframe. Example would be a low battery warning. | </summary>
        [Description("Indicates about a possible future error if this is not resolved within a given timeframe. Example would be a low battery warning.")]
        WARNING=4, 
        ///<summary> An unusual event has occurred, though not an error condition. This should be investigated for the root cause. | </summary>
        [Description("An unusual event has occurred, though not an error condition. This should be investigated for the root cause.")]
        NOTICE=5, 
        ///<summary> Normal operational messages. Useful for logging. No action is required for these messages. | </summary>
        [Description("Normal operational messages. Useful for logging. No action is required for these messages.")]
        INFO=6, 
        ///<summary> Useful non-operational messages that can assist in debugging. These should not occur during normal operation. | </summary>
        [Description("Useful non-operational messages that can assist in debugging. These should not occur during normal operation.")]
        DEBUG=7, 
        
    };
    
    ///<summary> Power supply status flags (bitmask) </summary>
    [Flags]
	public enum MAV_POWER_STATUS: ushort
    {
        ///<summary> main brick power supply valid | </summary>
        [Description("main brick power supply valid")]
        BRICK_VALID=1, 
        ///<summary> main servo power supply valid for FMU | </summary>
        [Description("main servo power supply valid for FMU")]
        SERVO_VALID=2, 
        ///<summary> USB power is connected | </summary>
        [Description("USB power is connected")]
        USB_CONNECTED=4, 
        ///<summary> peripheral supply is in over-current state | </summary>
        [Description("peripheral supply is in over-current state")]
        PERIPH_OVERCURRENT=8, 
        ///<summary> hi-power peripheral supply is in over-current state | </summary>
        [Description("hi-power peripheral supply is in over-current state")]
        PERIPH_HIPOWER_OVERCURRENT=16, 
        ///<summary> Power status has changed since boot | </summary>
        [Description("Power status has changed since boot")]
        CHANGED=32, 
        
    };
    
    ///<summary> SERIAL_CONTROL device types </summary>
    public enum SERIAL_CONTROL_DEV: byte
    {
        ///<summary> First telemetry port | </summary>
        [Description("First telemetry port")]
        TELEM1=0, 
        ///<summary> Second telemetry port | </summary>
        [Description("Second telemetry port")]
        TELEM2=1, 
        ///<summary> First GPS port | </summary>
        [Description("First GPS port")]
        GPS1=2, 
        ///<summary> Second GPS port | </summary>
        [Description("Second GPS port")]
        GPS2=3, 
        ///<summary> system shell | </summary>
        [Description("system shell")]
        SHELL=10, 
        ///<summary> SERIAL0 | </summary>
        [Description("SERIAL0")]
        SERIAL_CONTROL_SERIAL0=100, 
        ///<summary> SERIAL1 | </summary>
        [Description("SERIAL1")]
        SERIAL_CONTROL_SERIAL1=101, 
        ///<summary> SERIAL2 | </summary>
        [Description("SERIAL2")]
        SERIAL_CONTROL_SERIAL2=102, 
        ///<summary> SERIAL3 | </summary>
        [Description("SERIAL3")]
        SERIAL_CONTROL_SERIAL3=103, 
        ///<summary> SERIAL4 | </summary>
        [Description("SERIAL4")]
        SERIAL_CONTROL_SERIAL4=104, 
        ///<summary> SERIAL5 | </summary>
        [Description("SERIAL5")]
        SERIAL_CONTROL_SERIAL5=105, 
        ///<summary> SERIAL6 | </summary>
        [Description("SERIAL6")]
        SERIAL_CONTROL_SERIAL6=106, 
        ///<summary> SERIAL7 | </summary>
        [Description("SERIAL7")]
        SERIAL_CONTROL_SERIAL7=107, 
        ///<summary> SERIAL8 | </summary>
        [Description("SERIAL8")]
        SERIAL_CONTROL_SERIAL8=108, 
        ///<summary> SERIAL9 | </summary>
        [Description("SERIAL9")]
        SERIAL_CONTROL_SERIAL9=109, 
        
    };
    
    ///<summary> SERIAL_CONTROL flags (bitmask) </summary>
    [Flags]
	public enum SERIAL_CONTROL_FLAG: byte
    {
        ///<summary> Set if this is a reply | </summary>
        [Description("Set if this is a reply")]
        REPLY=1, 
        ///<summary> Set if the sender wants the receiver to send a response as another SERIAL_CONTROL message | </summary>
        [Description("Set if the sender wants the receiver to send a response as another SERIAL_CONTROL message")]
        RESPOND=2, 
        ///<summary> Set if access to the serial port should be removed from whatever driver is currently using it, giving exclusive access to the SERIAL_CONTROL protocol. The port can be handed back by sending a request without this flag set | </summary>
        [Description("Set if access to the serial port should be removed from whatever driver is currently using it, giving exclusive access to the SERIAL_CONTROL protocol. The port can be handed back by sending a request without this flag set")]
        EXCLUSIVE=4, 
        ///<summary> Block on writes to the serial port | </summary>
        [Description("Block on writes to the serial port")]
        BLOCKING=8, 
        ///<summary> Send multiple replies until port is drained | </summary>
        [Description("Send multiple replies until port is drained")]
        MULTI=16, 
        
    };
    
    ///<summary> Enumeration of distance sensor types </summary>
    public enum MAV_DISTANCE_SENSOR: byte
    {
        ///<summary> Laser rangefinder, e.g. LightWare SF02/F or PulsedLight units | </summary>
        [Description("Laser rangefinder, e.g. LightWare SF02/F or PulsedLight units")]
        LASER=0, 
        ///<summary> Ultrasound rangefinder, e.g. MaxBotix units | </summary>
        [Description("Ultrasound rangefinder, e.g. MaxBotix units")]
        ULTRASOUND=1, 
        ///<summary> Infrared rangefinder, e.g. Sharp units | </summary>
        [Description("Infrared rangefinder, e.g. Sharp units")]
        INFRARED=2, 
        ///<summary> Radar type, e.g. uLanding units | </summary>
        [Description("Radar type, e.g. uLanding units")]
        RADAR=3, 
        ///<summary> Broken or unknown type, e.g. analog units | </summary>
        [Description("Broken or unknown type, e.g. analog units")]
        UNKNOWN=4, 
        
    };
    
    ///<summary> Enumeration of sensor orientation, according to its rotations </summary>
    public enum MAV_SENSOR_ORIENTATION: byte
    {
        ///<summary> Roll: 0, Pitch: 0, Yaw: 0 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 0")]
        MAV_SENSOR_ROTATION_NONE=0, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 45 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 45")]
        MAV_SENSOR_ROTATION_YAW_45=1, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 90 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 90")]
        MAV_SENSOR_ROTATION_YAW_90=2, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 135 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 135")]
        MAV_SENSOR_ROTATION_YAW_135=3, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 180 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 180")]
        MAV_SENSOR_ROTATION_YAW_180=4, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 225 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 225")]
        MAV_SENSOR_ROTATION_YAW_225=5, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 270 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 270")]
        MAV_SENSOR_ROTATION_YAW_270=6, 
        ///<summary> Roll: 0, Pitch: 0, Yaw: 315 | </summary>
        [Description("Roll: 0, Pitch: 0, Yaw: 315")]
        MAV_SENSOR_ROTATION_YAW_315=7, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 0 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_180=8, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 45 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 45")]
        MAV_SENSOR_ROTATION_ROLL_180_YAW_45=9, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 90 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 90")]
        MAV_SENSOR_ROTATION_ROLL_180_YAW_90=10, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 135 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 135")]
        MAV_SENSOR_ROTATION_ROLL_180_YAW_135=11, 
        ///<summary> Roll: 0, Pitch: 180, Yaw: 0 | </summary>
        [Description("Roll: 0, Pitch: 180, Yaw: 0")]
        MAV_SENSOR_ROTATION_PITCH_180=12, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 225 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 225")]
        MAV_SENSOR_ROTATION_ROLL_180_YAW_225=13, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 270 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 270")]
        MAV_SENSOR_ROTATION_ROLL_180_YAW_270=14, 
        ///<summary> Roll: 180, Pitch: 0, Yaw: 315 | </summary>
        [Description("Roll: 180, Pitch: 0, Yaw: 315")]
        MAV_SENSOR_ROTATION_ROLL_180_YAW_315=15, 
        ///<summary> Roll: 90, Pitch: 0, Yaw: 0 | </summary>
        [Description("Roll: 90, Pitch: 0, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_90=16, 
        ///<summary> Roll: 90, Pitch: 0, Yaw: 45 | </summary>
        [Description("Roll: 90, Pitch: 0, Yaw: 45")]
        MAV_SENSOR_ROTATION_ROLL_90_YAW_45=17, 
        ///<summary> Roll: 90, Pitch: 0, Yaw: 90 | </summary>
        [Description("Roll: 90, Pitch: 0, Yaw: 90")]
        MAV_SENSOR_ROTATION_ROLL_90_YAW_90=18, 
        ///<summary> Roll: 90, Pitch: 0, Yaw: 135 | </summary>
        [Description("Roll: 90, Pitch: 0, Yaw: 135")]
        MAV_SENSOR_ROTATION_ROLL_90_YAW_135=19, 
        ///<summary> Roll: 270, Pitch: 0, Yaw: 0 | </summary>
        [Description("Roll: 270, Pitch: 0, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_270=20, 
        ///<summary> Roll: 270, Pitch: 0, Yaw: 45 | </summary>
        [Description("Roll: 270, Pitch: 0, Yaw: 45")]
        MAV_SENSOR_ROTATION_ROLL_270_YAW_45=21, 
        ///<summary> Roll: 270, Pitch: 0, Yaw: 90 | </summary>
        [Description("Roll: 270, Pitch: 0, Yaw: 90")]
        MAV_SENSOR_ROTATION_ROLL_270_YAW_90=22, 
        ///<summary> Roll: 270, Pitch: 0, Yaw: 135 | </summary>
        [Description("Roll: 270, Pitch: 0, Yaw: 135")]
        MAV_SENSOR_ROTATION_ROLL_270_YAW_135=23, 
        ///<summary> Roll: 0, Pitch: 90, Yaw: 0 | </summary>
        [Description("Roll: 0, Pitch: 90, Yaw: 0")]
        MAV_SENSOR_ROTATION_PITCH_90=24, 
        ///<summary> Roll: 0, Pitch: 270, Yaw: 0 | </summary>
        [Description("Roll: 0, Pitch: 270, Yaw: 0")]
        MAV_SENSOR_ROTATION_PITCH_270=25, 
        ///<summary> Roll: 0, Pitch: 180, Yaw: 90 | </summary>
        [Description("Roll: 0, Pitch: 180, Yaw: 90")]
        MAV_SENSOR_ROTATION_PITCH_180_YAW_90=26, 
        ///<summary> Roll: 0, Pitch: 180, Yaw: 270 | </summary>
        [Description("Roll: 0, Pitch: 180, Yaw: 270")]
        MAV_SENSOR_ROTATION_PITCH_180_YAW_270=27, 
        ///<summary> Roll: 90, Pitch: 90, Yaw: 0 | </summary>
        [Description("Roll: 90, Pitch: 90, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_90_PITCH_90=28, 
        ///<summary> Roll: 180, Pitch: 90, Yaw: 0 | </summary>
        [Description("Roll: 180, Pitch: 90, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_180_PITCH_90=29, 
        ///<summary> Roll: 270, Pitch: 90, Yaw: 0 | </summary>
        [Description("Roll: 270, Pitch: 90, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_270_PITCH_90=30, 
        ///<summary> Roll: 90, Pitch: 180, Yaw: 0 | </summary>
        [Description("Roll: 90, Pitch: 180, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_90_PITCH_180=31, 
        ///<summary> Roll: 270, Pitch: 180, Yaw: 0 | </summary>
        [Description("Roll: 270, Pitch: 180, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_270_PITCH_180=32, 
        ///<summary> Roll: 90, Pitch: 270, Yaw: 0 | </summary>
        [Description("Roll: 90, Pitch: 270, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_90_PITCH_270=33, 
        ///<summary> Roll: 180, Pitch: 270, Yaw: 0 | </summary>
        [Description("Roll: 180, Pitch: 270, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_180_PITCH_270=34, 
        ///<summary> Roll: 270, Pitch: 270, Yaw: 0 | </summary>
        [Description("Roll: 270, Pitch: 270, Yaw: 0")]
        MAV_SENSOR_ROTATION_ROLL_270_PITCH_270=35, 
        ///<summary> Roll: 90, Pitch: 180, Yaw: 90 | </summary>
        [Description("Roll: 90, Pitch: 180, Yaw: 90")]
        MAV_SENSOR_ROTATION_ROLL_90_PITCH_180_YAW_90=36, 
        ///<summary> Roll: 90, Pitch: 0, Yaw: 270 | </summary>
        [Description("Roll: 90, Pitch: 0, Yaw: 270")]
        MAV_SENSOR_ROTATION_ROLL_90_YAW_270=37, 
        ///<summary> Roll: 90, Pitch: 68, Yaw: 293 | </summary>
        [Description("Roll: 90, Pitch: 68, Yaw: 293")]
        MAV_SENSOR_ROTATION_ROLL_90_PITCH_68_YAW_293=38, 
        ///<summary> Pitch: 315 | </summary>
        [Description("Pitch: 315")]
        MAV_SENSOR_ROTATION_PITCH_315=39, 
        ///<summary> Roll: 90, Pitch: 315 | </summary>
        [Description("Roll: 90, Pitch: 315")]
        MAV_SENSOR_ROTATION_ROLL_90_PITCH_315=40, 
        ///<summary> Custom orientation | </summary>
        [Description("Custom orientation")]
        MAV_SENSOR_ROTATION_CUSTOM=100, 
        
    };
    
    ///<summary> Bitmask of (optional) autopilot capabilities (64 bit). If a bit is set, the autopilot supports this capability. </summary>
    [Flags]
	public enum MAV_PROTOCOL_CAPABILITY: ulong
    {
        ///<summary> Autopilot supports the MISSION_ITEM float message type.           Note that MISSION_ITEM is deprecated, and autopilots should use MISSION_INT instead.          | </summary>
        [Description("Autopilot supports the MISSION_ITEM float message type.           Note that MISSION_ITEM is deprecated, and autopilots should use MISSION_INT instead.         ")]
        MISSION_FLOAT=1, 
        ///<summary> Autopilot supports the new param float message type. | </summary>
        [Description("Autopilot supports the new param float message type.")]
        PARAM_FLOAT=2, 
        ///<summary> Autopilot supports MISSION_ITEM_INT scaled integer message type.           Note that this flag must always be set if missions are supported, because missions must always use MISSION_ITEM_INT (rather than MISSION_ITEM, which is deprecated).          | </summary>
        [Description("Autopilot supports MISSION_ITEM_INT scaled integer message type.           Note that this flag must always be set if missions are supported, because missions must always use MISSION_ITEM_INT (rather than MISSION_ITEM, which is deprecated).         ")]
        MISSION_INT=4, 
        ///<summary> Autopilot supports COMMAND_INT scaled integer message type. | </summary>
        [Description("Autopilot supports COMMAND_INT scaled integer message type.")]
        COMMAND_INT=8, 
        ///<summary> Parameter protocol uses byte-wise encoding of parameter values into param_value (float) fields: https://mavlink.io/en/services/parameter.html#parameter-encoding.           Note that either this flag or MAV_PROTOCOL_CAPABILITY_PARAM_ENCODE_C_CAST should be set if the parameter protocol is supported.          | </summary>
        [Description("Parameter protocol uses byte-wise encoding of parameter values into param_value (float) fields: https://mavlink.io/en/services/parameter.html#parameter-encoding.           Note that either this flag or MAV_PROTOCOL_CAPABILITY_PARAM_ENCODE_C_CAST should be set if the parameter protocol is supported.         ")]
        PARAM_ENCODE_BYTEWISE=16, 
        ///<summary> Autopilot supports the File Transfer Protocol v1: https://mavlink.io/en/services/ftp.html. | </summary>
        [Description("Autopilot supports the File Transfer Protocol v1: https://mavlink.io/en/services/ftp.html.")]
        FTP=32, 
        ///<summary> Autopilot supports commanding attitude offboard. | </summary>
        [Description("Autopilot supports commanding attitude offboard.")]
        SET_ATTITUDE_TARGET=64, 
        ///<summary> Autopilot supports commanding position and velocity targets in local NED frame. | </summary>
        [Description("Autopilot supports commanding position and velocity targets in local NED frame.")]
        SET_POSITION_TARGET_LOCAL_NED=128, 
        ///<summary> Autopilot supports commanding position and velocity targets in global scaled integers. | </summary>
        [Description("Autopilot supports commanding position and velocity targets in global scaled integers.")]
        SET_POSITION_TARGET_GLOBAL_INT=256, 
        ///<summary> Autopilot supports terrain protocol / data handling. | </summary>
        [Description("Autopilot supports terrain protocol / data handling.")]
        TERRAIN=512, 
        ///<summary> Autopilot supports direct actuator control. | </summary>
        [Description("Autopilot supports direct actuator control.")]
        SET_ACTUATOR_TARGET=1024, 
        ///<summary> Autopilot supports the MAV_CMD_DO_FLIGHTTERMINATION command (flight termination). | </summary>
        [Description("Autopilot supports the MAV_CMD_DO_FLIGHTTERMINATION command (flight termination).")]
        FLIGHT_TERMINATION=2048, 
        ///<summary> Autopilot supports onboard compass calibration. | </summary>
        [Description("Autopilot supports onboard compass calibration.")]
        COMPASS_CALIBRATION=4096, 
        ///<summary> Autopilot supports MAVLink version 2. | </summary>
        [Description("Autopilot supports MAVLink version 2.")]
        MAVLINK2=8192, 
        ///<summary> Autopilot supports mission fence protocol. | </summary>
        [Description("Autopilot supports mission fence protocol.")]
        MISSION_FENCE=16384, 
        ///<summary> Autopilot supports mission rally point protocol. | </summary>
        [Description("Autopilot supports mission rally point protocol.")]
        MISSION_RALLY=32768, 
        ///<summary> Reserved for future use. | </summary>
        [Description("Reserved for future use.")]
        RESERVED2=65536, 
        ///<summary> Parameter protocol uses C-cast of parameter values to set the param_value (float) fields: https://mavlink.io/en/services/parameter.html#parameter-encoding.           Note that either this flag or MAV_PROTOCOL_CAPABILITY_PARAM_ENCODE_BYTEWISE should be set if the parameter protocol is supported.          | </summary>
        [Description("Parameter protocol uses C-cast of parameter values to set the param_value (float) fields: https://mavlink.io/en/services/parameter.html#parameter-encoding.           Note that either this flag or MAV_PROTOCOL_CAPABILITY_PARAM_ENCODE_BYTEWISE should be set if the parameter protocol is supported.         ")]
        PARAM_ENCODE_C_CAST=131072, 
        
    };
    
    ///<summary> Type of mission items being requested/sent in mission protocol. </summary>
    public enum MAV_MISSION_TYPE: int /*default*/
    {
        ///<summary> Items are mission commands for main mission. | </summary>
        [Description("Items are mission commands for main mission.")]
        MISSION=0, 
        ///<summary> Specifies GeoFence area(s). Items are MAV_CMD_NAV_FENCE_ GeoFence items. | </summary>
        [Description("Specifies GeoFence area(s). Items are MAV_CMD_NAV_FENCE_ GeoFence items.")]
        FENCE=1, 
        ///<summary> Specifies the rally points for the vehicle. Rally points are alternative RTL points. Items are MAV_CMD_NAV_RALLY_POINT rally point items. | </summary>
        [Description("Specifies the rally points for the vehicle. Rally points are alternative RTL points. Items are MAV_CMD_NAV_RALLY_POINT rally point items.")]
        RALLY=2, 
        ///<summary> Only used in MISSION_CLEAR_ALL to clear all mission types. | </summary>
        [Description("Only used in MISSION_CLEAR_ALL to clear all mission types.")]
        ALL=255, 
        
    };
    
    ///<summary> Enumeration of estimator types </summary>
    public enum MAV_ESTIMATOR_TYPE: byte
    {
        ///<summary> Unknown type of the estimator. | </summary>
        [Description("Unknown type of the estimator.")]
        UNKNOWN=0, 
        ///<summary> This is a naive estimator without any real covariance feedback. | </summary>
        [Description("This is a naive estimator without any real covariance feedback.")]
        NAIVE=1, 
        ///<summary> Computer vision based estimate. Might be up to scale. | </summary>
        [Description("Computer vision based estimate. Might be up to scale.")]
        VISION=2, 
        ///<summary> Visual-inertial estimate. | </summary>
        [Description("Visual-inertial estimate.")]
        VIO=3, 
        ///<summary> Plain GPS estimate. | </summary>
        [Description("Plain GPS estimate.")]
        GPS=4, 
        ///<summary> Estimator integrating GPS and inertial sensing. | </summary>
        [Description("Estimator integrating GPS and inertial sensing.")]
        GPS_INS=5, 
        ///<summary> Estimate from external motion capturing system. | </summary>
        [Description("Estimate from external motion capturing system.")]
        MOCAP=6, 
        ///<summary> Estimator based on lidar sensor input. | </summary>
        [Description("Estimator based on lidar sensor input.")]
        LIDAR=7, 
        ///<summary> Estimator on autopilot. | </summary>
        [Description("Estimator on autopilot.")]
        AUTOPILOT=8, 
        
    };
    
    ///<summary> Enumeration of battery types </summary>
    public enum MAV_BATTERY_TYPE: byte
    {
        ///<summary> Not specified. | </summary>
        [Description("Not specified.")]
        UNKNOWN=0, 
        ///<summary> Lithium polymer battery | </summary>
        [Description("Lithium polymer battery")]
        LIPO=1, 
        ///<summary> Lithium-iron-phosphate battery | </summary>
        [Description("Lithium-iron-phosphate battery")]
        LIFE=2, 
        ///<summary> Lithium-ION battery | </summary>
        [Description("Lithium-ION battery")]
        LION=3, 
        ///<summary> Nickel metal hydride battery | </summary>
        [Description("Nickel metal hydride battery")]
        NIMH=4, 
        
    };
    
    ///<summary> Enumeration of battery functions </summary>
    public enum MAV_BATTERY_FUNCTION: byte
    {
        ///<summary> Battery function is unknown | </summary>
        [Description("Battery function is unknown")]
        UNKNOWN=0, 
        ///<summary> Battery supports all flight systems | </summary>
        [Description("Battery supports all flight systems")]
        ALL=1, 
        ///<summary> Battery for the propulsion system | </summary>
        [Description("Battery for the propulsion system")]
        PROPULSION=2, 
        ///<summary> Avionics battery | </summary>
        [Description("Avionics battery")]
        AVIONICS=3, 
        ///<summary> Payload battery | </summary>
        [Description("Payload battery")]
        PAYLOAD=4, 
        
    };
    
    ///<summary> Enumeration for battery charge states. </summary>
    public enum MAV_BATTERY_CHARGE_STATE: int /*default*/
    {
        ///<summary> Low battery state is not provided | </summary>
        [Description("Low battery state is not provided")]
        UNDEFINED=0, 
        ///<summary> Battery is not in low state. Normal operation. | </summary>
        [Description("Battery is not in low state. Normal operation.")]
        OK=1, 
        ///<summary> Battery state is low, warn and monitor close. | </summary>
        [Description("Battery state is low, warn and monitor close.")]
        LOW=2, 
        ///<summary> Battery state is critical, return or abort immediately. | </summary>
        [Description("Battery state is critical, return or abort immediately.")]
        CRITICAL=3, 
        ///<summary> Battery state is too low for ordinary abort sequence. Perform fastest possible emergency stop to prevent damage. | </summary>
        [Description("Battery state is too low for ordinary abort sequence. Perform fastest possible emergency stop to prevent damage.")]
        EMERGENCY=4, 
        ///<summary> Battery failed, damage unavoidable. Possible causes (faults) are listed in MAV_BATTERY_FAULT. | </summary>
        [Description("Battery failed, damage unavoidable. Possible causes (faults) are listed in MAV_BATTERY_FAULT.")]
        FAILED=5, 
        ///<summary> Battery is diagnosed to be defective or an error occurred, usage is discouraged / prohibited. Possible causes (faults) are listed in MAV_BATTERY_FAULT. | </summary>
        [Description("Battery is diagnosed to be defective or an error occurred, usage is discouraged / prohibited. Possible causes (faults) are listed in MAV_BATTERY_FAULT.")]
        UNHEALTHY=6, 
        ///<summary> Battery is charging. | </summary>
        [Description("Battery is charging.")]
        CHARGING=7, 
        
    };
    
    ///<summary> Battery mode. Note, the normal operation mode (i.e. when flying) should be reported as MAV_BATTERY_MODE_UNKNOWN to allow message trimming in normal flight. </summary>
    public enum MAV_BATTERY_MODE: int /*default*/
    {
        ///<summary> Battery mode not supported/unknown battery mode/normal operation. | </summary>
        [Description("Battery mode not supported/unknown battery mode/normal operation.")]
        UNKNOWN=0, 
        ///<summary> Battery is auto discharging (towards storage level). | </summary>
        [Description("Battery is auto discharging (towards storage level).")]
        AUTO_DISCHARGING=1, 
        ///<summary> Battery in hot-swap mode (current limited to prevent spikes that might damage sensitive electrical circuits). | </summary>
        [Description("Battery in hot-swap mode (current limited to prevent spikes that might damage sensitive electrical circuits).")]
        HOT_SWAP=2, 
        
    };
    
    ///<summary> Smart battery supply status/fault flags (bitmask) for health indication. The battery must also report either MAV_BATTERY_CHARGE_STATE_FAILED or MAV_BATTERY_CHARGE_STATE_UNHEALTHY if any of these are set. </summary>
    [Flags]
	public enum MAV_BATTERY_FAULT: int /*default*/
    {
        ///<summary> Battery has deep discharged. | </summary>
        [Description("Battery has deep discharged.")]
        DEEP_DISCHARGE=1, 
        ///<summary> Voltage spikes. | </summary>
        [Description("Voltage spikes.")]
        SPIKES=2, 
        ///<summary> One or more cells have failed. Battery should also report MAV_BATTERY_CHARGE_STATE_FAILE (and should not be used). | </summary>
        [Description("One or more cells have failed. Battery should also report MAV_BATTERY_CHARGE_STATE_FAILE (and should not be used).")]
        CELL_FAIL=4, 
        ///<summary> Over-current fault. | </summary>
        [Description("Over-current fault.")]
        OVER_CURRENT=8, 
        ///<summary> Over-temperature fault. | </summary>
        [Description("Over-temperature fault.")]
        OVER_TEMPERATURE=16, 
        ///<summary> Under-temperature fault. | </summary>
        [Description("Under-temperature fault.")]
        UNDER_TEMPERATURE=32, 
        ///<summary> Vehicle voltage is not compatible with this battery (batteries on same power rail should have similar voltage). | </summary>
        [Description("Vehicle voltage is not compatible with this battery (batteries on same power rail should have similar voltage).")]
        INCOMPATIBLE_VOLTAGE=64, 
        ///<summary> Battery firmware is not compatible with current autopilot firmware. | </summary>
        [Description("Battery firmware is not compatible with current autopilot firmware.")]
        INCOMPATIBLE_FIRMWARE=128, 
        ///<summary> Battery is not compatible due to cell configuration (e.g. 5s1p when vehicle requires 6s). | </summary>
        [Description("Battery is not compatible due to cell configuration (e.g. 5s1p when vehicle requires 6s).")]
        BATTERY_FAULT_INCOMPATIBLE_CELLS_CONFIGURATION=256, 
        
    };
    
    ///<summary> Flags to report status/failure cases for a power generator (used in GENERATOR_STATUS). Note that FAULTS are conditions that cause the generator to fail. Warnings are conditions that require attention before the next use (they indicate the system is not operating properly). </summary>
    public enum MAV_GENERATOR_STATUS_FLAG: int /*default*/
    {
        ///<summary> Generator is off. | </summary>
        [Description("Generator is off.")]
        OFF=1, 
        ///<summary> Generator is ready to start generating power. | </summary>
        [Description("Generator is ready to start generating power.")]
        READY=2, 
        ///<summary> Generator is generating power. | </summary>
        [Description("Generator is generating power.")]
        GENERATING=4, 
        ///<summary> Generator is charging the batteries (generating enough power to charge and provide the load). | </summary>
        [Description("Generator is charging the batteries (generating enough power to charge and provide the load).")]
        CHARGING=8, 
        ///<summary> Generator is operating at a reduced maximum power. | </summary>
        [Description("Generator is operating at a reduced maximum power.")]
        REDUCED_POWER=16, 
        ///<summary> Generator is providing the maximum output. | </summary>
        [Description("Generator is providing the maximum output.")]
        MAXPOWER=32, 
        ///<summary> Generator is near the maximum operating temperature, cooling is insufficient. | </summary>
        [Description("Generator is near the maximum operating temperature, cooling is insufficient.")]
        OVERTEMP_WARNING=64, 
        ///<summary> Generator hit the maximum operating temperature and shutdown. | </summary>
        [Description("Generator hit the maximum operating temperature and shutdown.")]
        OVERTEMP_FAULT=128, 
        ///<summary> Power electronics are near the maximum operating temperature, cooling is insufficient. | </summary>
        [Description("Power electronics are near the maximum operating temperature, cooling is insufficient.")]
        ELECTRONICS_OVERTEMP_WARNING=256, 
        ///<summary> Power electronics hit the maximum operating temperature and shutdown. | </summary>
        [Description("Power electronics hit the maximum operating temperature and shutdown.")]
        ELECTRONICS_OVERTEMP_FAULT=512, 
        ///<summary> Power electronics experienced a fault and shutdown. | </summary>
        [Description("Power electronics experienced a fault and shutdown.")]
        ELECTRONICS_FAULT=1024, 
        ///<summary> The power source supplying the generator failed e.g. mechanical generator stopped, tether is no longer providing power, solar cell is in shade, hydrogen reaction no longer happening. | </summary>
        [Description("The power source supplying the generator failed e.g. mechanical generator stopped, tether is no longer providing power, solar cell is in shade, hydrogen reaction no longer happening.")]
        POWERSOURCE_FAULT=2048, 
        ///<summary> Generator controller having communication problems. | </summary>
        [Description("Generator controller having communication problems.")]
        COMMUNICATION_WARNING=4096, 
        ///<summary> Power electronic or generator cooling system error. | </summary>
        [Description("Power electronic or generator cooling system error.")]
        COOLING_WARNING=8192, 
        ///<summary> Generator controller power rail experienced a fault. | </summary>
        [Description("Generator controller power rail experienced a fault.")]
        POWER_RAIL_FAULT=16384, 
        ///<summary> Generator controller exceeded the overcurrent threshold and shutdown to prevent damage. | </summary>
        [Description("Generator controller exceeded the overcurrent threshold and shutdown to prevent damage.")]
        OVERCURRENT_FAULT=32768, 
        ///<summary> Generator controller detected a high current going into the batteries and shutdown to prevent battery damage. | </summary>
        [Description("Generator controller detected a high current going into the batteries and shutdown to prevent battery damage.")]
        BATTERY_OVERCHARGE_CURRENT_FAULT=65536, 
        ///<summary> Generator controller exceeded it's overvoltage threshold and shutdown to prevent it exceeding the voltage rating. | </summary>
        [Description("Generator controller exceeded it's overvoltage threshold and shutdown to prevent it exceeding the voltage rating.")]
        OVERVOLTAGE_FAULT=131072, 
        ///<summary> Batteries are under voltage (generator will not start). | </summary>
        [Description("Batteries are under voltage (generator will not start).")]
        BATTERY_UNDERVOLT_FAULT=262144, 
        ///<summary> Generator start is inhibited by e.g. a safety switch. | </summary>
        [Description("Generator start is inhibited by e.g. a safety switch.")]
        START_INHIBITED=524288, 
        ///<summary> Generator requires maintenance. | </summary>
        [Description("Generator requires maintenance.")]
        MAINTENANCE_REQUIRED=1048576, 
        ///<summary> Generator is not ready to generate yet. | </summary>
        [Description("Generator is not ready to generate yet.")]
        WARMING_UP=2097152, 
        ///<summary> Generator is idle. | </summary>
        [Description("Generator is idle.")]
        IDLE=4194304, 
        
    };
    
    ///<summary> Enumeration of VTOL states </summary>
    public enum MAV_VTOL_STATE: byte
    {
        ///<summary> MAV is not configured as VTOL | </summary>
        [Description("MAV is not configured as VTOL")]
        UNDEFINED=0, 
        ///<summary> VTOL is in transition from multicopter to fixed-wing | </summary>
        [Description("VTOL is in transition from multicopter to fixed-wing")]
        TRANSITION_TO_FW=1, 
        ///<summary> VTOL is in transition from fixed-wing to multicopter | </summary>
        [Description("VTOL is in transition from fixed-wing to multicopter")]
        TRANSITION_TO_MC=2, 
        ///<summary> VTOL is in multicopter state | </summary>
        [Description("VTOL is in multicopter state")]
        MC=3, 
        ///<summary> VTOL is in fixed-wing state | </summary>
        [Description("VTOL is in fixed-wing state")]
        FW=4, 
        
    };
    
    ///<summary> Enumeration of landed detector states </summary>
    public enum MAV_LANDED_STATE: byte
    {
        ///<summary> MAV landed state is unknown | </summary>
        [Description("MAV landed state is unknown")]
        UNDEFINED=0, 
        ///<summary> MAV is landed (on ground) | </summary>
        [Description("MAV is landed (on ground)")]
        ON_GROUND=1, 
        ///<summary> MAV is in air | </summary>
        [Description("MAV is in air")]
        IN_AIR=2, 
        ///<summary> MAV currently taking off | </summary>
        [Description("MAV currently taking off")]
        TAKEOFF=3, 
        ///<summary> MAV currently landing | </summary>
        [Description("MAV currently landing")]
        LANDING=4, 
        
    };
    
    ///<summary> Enumeration of the ADSB altimeter types </summary>
    public enum ADSB_ALTITUDE_TYPE: byte
    {
        ///<summary> Altitude reported from a Baro source using QNH reference | </summary>
        [Description("Altitude reported from a Baro source using QNH reference")]
        PRESSURE_QNH=0, 
        ///<summary> Altitude reported from a GNSS source | </summary>
        [Description("Altitude reported from a GNSS source")]
        GEOMETRIC=1, 
        
    };
    
    ///<summary> ADSB classification for the type of vehicle emitting the transponder signal </summary>
    public enum ADSB_EMITTER_TYPE: byte
    {
        ///<summary>  | </summary>
        [Description("")]
        NO_INFO=0, 
        ///<summary>  | </summary>
        [Description("")]
        LIGHT=1, 
        ///<summary>  | </summary>
        [Description("")]
        SMALL=2, 
        ///<summary>  | </summary>
        [Description("")]
        LARGE=3, 
        ///<summary>  | </summary>
        [Description("")]
        HIGH_VORTEX_LARGE=4, 
        ///<summary>  | </summary>
        [Description("")]
        HEAVY=5, 
        ///<summary>  | </summary>
        [Description("")]
        HIGHLY_MANUV=6, 
        ///<summary>  | </summary>
        [Description("")]
        ROTOCRAFT=7, 
        ///<summary>  | </summary>
        [Description("")]
        UNASSIGNED=8, 
        ///<summary>  | </summary>
        [Description("")]
        GLIDER=9, 
        ///<summary>  | </summary>
        [Description("")]
        LIGHTER_AIR=10, 
        ///<summary>  | </summary>
        [Description("")]
        PARACHUTE=11, 
        ///<summary>  | </summary>
        [Description("")]
        ULTRA_LIGHT=12, 
        ///<summary>  | </summary>
        [Description("")]
        UNASSIGNED2=13, 
        ///<summary>  | </summary>
        [Description("")]
        UAV=14, 
        ///<summary>  | </summary>
        [Description("")]
        SPACE=15, 
        ///<summary>  | </summary>
        [Description("")]
        UNASSGINED3=16, 
        ///<summary>  | </summary>
        [Description("")]
        EMERGENCY_SURFACE=17, 
        ///<summary>  | </summary>
        [Description("")]
        SERVICE_SURFACE=18, 
        ///<summary>  | </summary>
        [Description("")]
        POINT_OBSTACLE=19, 
        
    };
    
    ///<summary> These flags indicate status such as data validity of each data source. Set = data valid </summary>
    [Flags]
	public enum ADSB_FLAGS: ushort
    {
        ///<summary>  | </summary>
        [Description("")]
        VALID_COORDS=1, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_ALTITUDE=2, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_HEADING=4, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_VELOCITY=8, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_CALLSIGN=16, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_SQUAWK=32, 
        ///<summary>  | </summary>
        [Description("")]
        SIMULATED=64, 
        ///<summary>  | </summary>
        [Description("")]
        VERTICAL_VELOCITY_VALID=128, 
        ///<summary>  | </summary>
        [Description("")]
        BARO_VALID=256, 
        ///<summary>  | </summary>
        [Description("")]
        SOURCE_UAT=32768, 
        
    };
    
    ///<summary> Bitmap of options for the MAV_CMD_DO_REPOSITION </summary>
    [Flags]
	public enum MAV_DO_REPOSITION_FLAGS: int /*default*/
    {
        ///<summary> The aircraft should immediately transition into guided. This should not be set for follow me applications | </summary>
        [Description("The aircraft should immediately transition into guided. This should not be set for follow me applications")]
        CHANGE_MODE=1, 
        
    };
    
    ///<summary> Flags in ESTIMATOR_STATUS message </summary>
    [Flags]
	public enum ESTIMATOR_STATUS_FLAGS: ushort
    {
        ///<summary> True if the attitude estimate is good | </summary>
        [Description("True if the attitude estimate is good")]
        ESTIMATOR_ATTITUDE=1, 
        ///<summary> True if the horizontal velocity estimate is good | </summary>
        [Description("True if the horizontal velocity estimate is good")]
        ESTIMATOR_VELOCITY_HORIZ=2, 
        ///<summary> True if the  vertical velocity estimate is good | </summary>
        [Description("True if the  vertical velocity estimate is good")]
        ESTIMATOR_VELOCITY_VERT=4, 
        ///<summary> True if the horizontal position (relative) estimate is good | </summary>
        [Description("True if the horizontal position (relative) estimate is good")]
        ESTIMATOR_POS_HORIZ_REL=8, 
        ///<summary> True if the horizontal position (absolute) estimate is good | </summary>
        [Description("True if the horizontal position (absolute) estimate is good")]
        ESTIMATOR_POS_HORIZ_ABS=16, 
        ///<summary> True if the vertical position (absolute) estimate is good | </summary>
        [Description("True if the vertical position (absolute) estimate is good")]
        ESTIMATOR_POS_VERT_ABS=32, 
        ///<summary> True if the vertical position (above ground) estimate is good | </summary>
        [Description("True if the vertical position (above ground) estimate is good")]
        ESTIMATOR_POS_VERT_AGL=64, 
        ///<summary> True if the EKF is in a constant position mode and is not using external measurements (eg GPS or optical flow) | </summary>
        [Description("True if the EKF is in a constant position mode and is not using external measurements (eg GPS or optical flow)")]
        ESTIMATOR_CONST_POS_MODE=128, 
        ///<summary> True if the EKF has sufficient data to enter a mode that will provide a (relative) position estimate | </summary>
        [Description("True if the EKF has sufficient data to enter a mode that will provide a (relative) position estimate")]
        ESTIMATOR_PRED_POS_HORIZ_REL=256, 
        ///<summary> True if the EKF has sufficient data to enter a mode that will provide a (absolute) position estimate | </summary>
        [Description("True if the EKF has sufficient data to enter a mode that will provide a (absolute) position estimate")]
        ESTIMATOR_PRED_POS_HORIZ_ABS=512, 
        ///<summary> True if the EKF has detected a GPS glitch | </summary>
        [Description("True if the EKF has detected a GPS glitch")]
        ESTIMATOR_GPS_GLITCH=1024, 
        ///<summary> True if the EKF has detected bad accelerometer data | </summary>
        [Description("True if the EKF has detected bad accelerometer data")]
        ESTIMATOR_ACCEL_ERROR=2048, 
        
    };
    
    ///<summary> Sequence that motors are tested when using MAV_CMD_DO_MOTOR_TEST. </summary>
    public enum MOTOR_TEST_ORDER: int /*default*/
    {
        ///<summary> Default autopilot motor test method. | </summary>
        [Description("Default autopilot motor test method.")]
        DEFAULT=0, 
        ///<summary> Motor numbers are specified as their index in a predefined vehicle-specific sequence. | </summary>
        [Description("Motor numbers are specified as their index in a predefined vehicle-specific sequence.")]
        SEQUENCE=1, 
        ///<summary> Motor numbers are specified as the output as labeled on the board. | </summary>
        [Description("Motor numbers are specified as the output as labeled on the board.")]
        BOARD=2, 
        
    };
    
    ///<summary> Defines how throttle value is represented in MAV_CMD_DO_MOTOR_TEST. </summary>
    public enum MOTOR_TEST_THROTTLE_TYPE: int /*default*/
    {
        ///<summary> Throttle as a percentage (0 ~ 100) | </summary>
        [Description("Throttle as a percentage (0 ~ 100)")]
        MOTOR_TEST_THROTTLE_PERCENT=0, 
        ///<summary> Throttle as an absolute PWM value (normally in range of 1000~2000). | </summary>
        [Description("Throttle as an absolute PWM value (normally in range of 1000~2000).")]
        MOTOR_TEST_THROTTLE_PWM=1, 
        ///<summary> Throttle pass-through from pilot's transmitter. | </summary>
        [Description("Throttle pass-through from pilot's transmitter.")]
        MOTOR_TEST_THROTTLE_PILOT=2, 
        ///<summary> Per-motor compass calibration test. | </summary>
        [Description("Per-motor compass calibration test.")]
        MOTOR_TEST_COMPASS_CAL=3, 
        
    };
    
    ///<summary>  </summary>
    [Flags]
	public enum GPS_INPUT_IGNORE_FLAGS: ushort
    {
        ///<summary> ignore altitude field | </summary>
        [Description("ignore altitude field")]
        GPS_INPUT_IGNORE_FLAG_ALT=1, 
        ///<summary> ignore hdop field | </summary>
        [Description("ignore hdop field")]
        GPS_INPUT_IGNORE_FLAG_HDOP=2, 
        ///<summary> ignore vdop field | </summary>
        [Description("ignore vdop field")]
        GPS_INPUT_IGNORE_FLAG_VDOP=4, 
        ///<summary> ignore horizontal velocity field (vn and ve) | </summary>
        [Description("ignore horizontal velocity field (vn and ve)")]
        GPS_INPUT_IGNORE_FLAG_VEL_HORIZ=8, 
        ///<summary> ignore vertical velocity field (vd) | </summary>
        [Description("ignore vertical velocity field (vd)")]
        GPS_INPUT_IGNORE_FLAG_VEL_VERT=16, 
        ///<summary> ignore speed accuracy field | </summary>
        [Description("ignore speed accuracy field")]
        GPS_INPUT_IGNORE_FLAG_SPEED_ACCURACY=32, 
        ///<summary> ignore horizontal accuracy field | </summary>
        [Description("ignore horizontal accuracy field")]
        GPS_INPUT_IGNORE_FLAG_HORIZONTAL_ACCURACY=64, 
        ///<summary> ignore vertical accuracy field | </summary>
        [Description("ignore vertical accuracy field")]
        GPS_INPUT_IGNORE_FLAG_VERTICAL_ACCURACY=128, 
        
    };
    
    ///<summary> Possible actions an aircraft can take to avoid a collision. </summary>
    public enum MAV_COLLISION_ACTION: byte
    {
        ///<summary> Ignore any potential collisions | </summary>
        [Description("Ignore any potential collisions")]
        NONE=0, 
        ///<summary> Report potential collision | </summary>
        [Description("Report potential collision")]
        REPORT=1, 
        ///<summary> Ascend or Descend to avoid threat | </summary>
        [Description("Ascend or Descend to avoid threat")]
        ASCEND_OR_DESCEND=2, 
        ///<summary> Move horizontally to avoid threat | </summary>
        [Description("Move horizontally to avoid threat")]
        MOVE_HORIZONTALLY=3, 
        ///<summary> Aircraft to move perpendicular to the collision's velocity vector | </summary>
        [Description("Aircraft to move perpendicular to the collision's velocity vector")]
        MOVE_PERPENDICULAR=4, 
        ///<summary> Aircraft to fly directly back to its launch point | </summary>
        [Description("Aircraft to fly directly back to its launch point")]
        RTL=5, 
        ///<summary> Aircraft to stop in place | </summary>
        [Description("Aircraft to stop in place")]
        HOVER=6, 
        
    };
    
    ///<summary> Aircraft-rated danger from this threat. </summary>
    public enum MAV_COLLISION_THREAT_LEVEL: byte
    {
        ///<summary> Not a threat | </summary>
        [Description("Not a threat")]
        NONE=0, 
        ///<summary> Craft is mildly concerned about this threat | </summary>
        [Description("Craft is mildly concerned about this threat")]
        LOW=1, 
        ///<summary> Craft is panicking, and may take actions to avoid threat | </summary>
        [Description("Craft is panicking, and may take actions to avoid threat")]
        HIGH=2, 
        
    };
    
    ///<summary> Source of information about this collision. </summary>
    public enum MAV_COLLISION_SRC: byte
    {
        ///<summary> ID field references ADSB_VEHICLE packets | </summary>
        [Description("ID field references ADSB_VEHICLE packets")]
        ADSB=0, 
        ///<summary> ID field references MAVLink SRC ID | </summary>
        [Description("ID field references MAVLink SRC ID")]
        MAVLINK_GPS_GLOBAL_INT=1, 
        
    };
    
    ///<summary> Type of GPS fix </summary>
    public enum GPS_FIX_TYPE: byte
    {
        ///<summary> No GPS connected | </summary>
        [Description("No GPS connected")]
        NO_GPS=0, 
        ///<summary> No position information, GPS is connected | </summary>
        [Description("No position information, GPS is connected")]
        NO_FIX=1, 
        ///<summary> 2D position | </summary>
        [Description("2D position")]
        _2D_FIX=2, 
        ///<summary> 3D position | </summary>
        [Description("3D position")]
        _3D_FIX=3, 
        ///<summary> DGPS/SBAS aided 3D position | </summary>
        [Description("DGPS/SBAS aided 3D position")]
        DGPS=4, 
        ///<summary> RTK float, 3D position | </summary>
        [Description("RTK float, 3D position")]
        RTK_FLOAT=5, 
        ///<summary> RTK Fixed, 3D position | </summary>
        [Description("RTK Fixed, 3D position")]
        RTK_FIXED=6, 
        ///<summary> Static fixed, typically used for base stations | </summary>
        [Description("Static fixed, typically used for base stations")]
        STATIC=7, 
        ///<summary> PPP, 3D position. | </summary>
        [Description("PPP, 3D position.")]
        PPP=8, 
        
    };
    
    ///<summary> RTK GPS baseline coordinate system, used for RTK corrections </summary>
    public enum RTK_BASELINE_COORDINATE_SYSTEM: byte
    {
        ///<summary> Earth-centered, Earth-fixed | </summary>
        [Description("Earth-centered, Earth-fixed")]
        ECEF=0, 
        ///<summary> RTK basestation centered, north, east, down | </summary>
        [Description("RTK basestation centered, north, east, down")]
        NED=1, 
        
    };
    
    ///<summary> Type of landing target </summary>
    public enum LANDING_TARGET_TYPE: int /*default*/
    {
        ///<summary> Landing target signaled by light beacon (ex: IR-LOCK) | </summary>
        [Description("Landing target signaled by light beacon (ex: IR-LOCK)")]
        LIGHT_BEACON=0, 
        ///<summary> Landing target signaled by radio beacon (ex: ILS, NDB) | </summary>
        [Description("Landing target signaled by radio beacon (ex: ILS, NDB)")]
        RADIO_BEACON=1, 
        ///<summary> Landing target represented by a fiducial marker (ex: ARTag) | </summary>
        [Description("Landing target represented by a fiducial marker (ex: ARTag)")]
        VISION_FIDUCIAL=2, 
        ///<summary> Landing target represented by a pre-defined visual shape/feature (ex: X-marker, H-marker, square) | </summary>
        [Description("Landing target represented by a pre-defined visual shape/feature (ex: X-marker, H-marker, square)")]
        VISION_OTHER=3, 
        
    };
    
    ///<summary> Direction of VTOL transition </summary>
    public enum VTOL_TRANSITION_HEADING: int /*default*/
    {
        ///<summary> Respect the heading configuration of the vehicle. | </summary>
        [Description("Respect the heading configuration of the vehicle.")]
        VEHICLE_DEFAULT=0, 
        ///<summary> Use the heading pointing towards the next waypoint. | </summary>
        [Description("Use the heading pointing towards the next waypoint.")]
        NEXT_WAYPOINT=1, 
        ///<summary> Use the heading on takeoff (while sitting on the ground). | </summary>
        [Description("Use the heading on takeoff (while sitting on the ground).")]
        TAKEOFF=2, 
        ///<summary> Use the specified heading in parameter 4. | </summary>
        [Description("Use the specified heading in parameter 4.")]
        SPECIFIED=3, 
        ///<summary> Use the current heading when reaching takeoff altitude (potentially facing the wind when weather-vaning is active). | </summary>
        [Description("Use the current heading when reaching takeoff altitude (potentially facing the wind when weather-vaning is active).")]
        ANY=4, 
        
    };
    
    ///<summary> Camera capability flags (Bitmap) </summary>
    [Flags]
	public enum CAMERA_CAP_FLAGS: int /*default*/
    {
        ///<summary> Camera is able to record video | </summary>
        [Description("Camera is able to record video")]
        CAPTURE_VIDEO=1, 
        ///<summary> Camera is able to capture images | </summary>
        [Description("Camera is able to capture images")]
        CAPTURE_IMAGE=2, 
        ///<summary> Camera has separate Video and Image/Photo modes (MAV_CMD_SET_CAMERA_MODE) | </summary>
        [Description("Camera has separate Video and Image/Photo modes (MAV_CMD_SET_CAMERA_MODE)")]
        HAS_MODES=4, 
        ///<summary> Camera can capture images while in video mode | </summary>
        [Description("Camera can capture images while in video mode")]
        CAN_CAPTURE_IMAGE_IN_VIDEO_MODE=8, 
        ///<summary> Camera can capture videos while in Photo/Image mode | </summary>
        [Description("Camera can capture videos while in Photo/Image mode")]
        CAN_CAPTURE_VIDEO_IN_IMAGE_MODE=16, 
        ///<summary> Camera has image survey mode (MAV_CMD_SET_CAMERA_MODE) | </summary>
        [Description("Camera has image survey mode (MAV_CMD_SET_CAMERA_MODE)")]
        HAS_IMAGE_SURVEY_MODE=32, 
        ///<summary> Camera has basic zoom control (MAV_CMD_SET_CAMERA_ZOOM) | </summary>
        [Description("Camera has basic zoom control (MAV_CMD_SET_CAMERA_ZOOM)")]
        HAS_BASIC_ZOOM=64, 
        ///<summary> Camera has basic focus control (MAV_CMD_SET_CAMERA_FOCUS) | </summary>
        [Description("Camera has basic focus control (MAV_CMD_SET_CAMERA_FOCUS)")]
        HAS_BASIC_FOCUS=128, 
        ///<summary> Camera has video streaming capabilities (request VIDEO_STREAM_INFORMATION with MAV_CMD_REQUEST_MESSAGE for video streaming info) | </summary>
        [Description("Camera has video streaming capabilities (request VIDEO_STREAM_INFORMATION with MAV_CMD_REQUEST_MESSAGE for video streaming info)")]
        HAS_VIDEO_STREAM=256, 
        ///<summary> Camera supports tracking of a point on the camera view. | </summary>
        [Description("Camera supports tracking of a point on the camera view.")]
        HAS_TRACKING_POINT=512, 
        ///<summary> Camera supports tracking of a selection rectangle on the camera view. | </summary>
        [Description("Camera supports tracking of a selection rectangle on the camera view.")]
        HAS_TRACKING_RECTANGLE=1024, 
        ///<summary> Camera supports tracking geo status (CAMERA_TRACKING_GEO_STATUS). | </summary>
        [Description("Camera supports tracking geo status (CAMERA_TRACKING_GEO_STATUS).")]
        HAS_TRACKING_GEO_STATUS=2048, 
        
    };
    
    ///<summary> Stream status flags (Bitmap) </summary>
    [Flags]
	public enum VIDEO_STREAM_STATUS_FLAGS: int /*default*/
    {
        ///<summary> Stream is active (running) | </summary>
        [Description("Stream is active (running)")]
        RUNNING=1, 
        ///<summary> Stream is thermal imaging | </summary>
        [Description("Stream is thermal imaging")]
        THERMAL=2, 
        
    };
    
    ///<summary> Video stream types </summary>
    public enum VIDEO_STREAM_TYPE: int /*default*/
    {
        ///<summary> Stream is RTSP | </summary>
        [Description("Stream is RTSP")]
        RTSP=0, 
        ///<summary> Stream is RTP UDP (URI gives the port number) | </summary>
        [Description("Stream is RTP UDP (URI gives the port number)")]
        RTPUDP=1, 
        ///<summary> Stream is MPEG on TCP | </summary>
        [Description("Stream is MPEG on TCP")]
        TCP_MPEG=2, 
        ///<summary> Stream is h.264 on MPEG TS (URI gives the port number) | </summary>
        [Description("Stream is h.264 on MPEG TS (URI gives the port number)")]
        MPEG_TS_H264=3, 
        
    };
    
    ///<summary> Camera tracking status flags </summary>
    [Flags]
	public enum CAMERA_TRACKING_STATUS_FLAGS: int /*default*/
    {
        ///<summary> Camera is not tracking | </summary>
        [Description("Camera is not tracking")]
        IDLE=0, 
        ///<summary> Camera is tracking | </summary>
        [Description("Camera is tracking")]
        ACTIVE=1, 
        ///<summary> Camera tracking in error state | </summary>
        [Description("Camera tracking in error state")]
        ERROR=2, 
        
    };
    
    ///<summary> Camera tracking modes </summary>
    public enum CAMERA_TRACKING_MODE: int /*default*/
    {
        ///<summary> Not tracking | </summary>
        [Description("Not tracking")]
        NONE=0, 
        ///<summary> Target is a point | </summary>
        [Description("Target is a point")]
        POINT=1, 
        ///<summary> Target is a rectangle | </summary>
        [Description("Target is a rectangle")]
        RECTANGLE=2, 
        
    };
    
    ///<summary> Camera tracking target data (shows where tracked target is within image) </summary>
    public enum CAMERA_TRACKING_TARGET_DATA: int /*default*/
    {
        ///<summary> No target data | </summary>
        [Description("No target data")]
        NONE=0, 
        ///<summary> Target data embedded in image data (proprietary) | </summary>
        [Description("Target data embedded in image data (proprietary)")]
        EMBEDDED=1, 
        ///<summary> Target data rendered in image | </summary>
        [Description("Target data rendered in image")]
        RENDERED=2, 
        ///<summary> Target data within status message (Point or Rectangle) | </summary>
        [Description("Target data within status message (Point or Rectangle)")]
        IN_STATUS=4, 
        
    };
    
    ///<summary> Zoom types for MAV_CMD_SET_CAMERA_ZOOM </summary>
    public enum CAMERA_ZOOM_TYPE: int /*default*/
    {
        ///<summary> Zoom one step increment (-1 for wide, 1 for tele) | </summary>
        [Description("Zoom one step increment (-1 for wide, 1 for tele)")]
        ZOOM_TYPE_STEP=0, 
        ///<summary> Continuous zoom up/down until stopped (-1 for wide, 1 for tele, 0 to stop zooming) | </summary>
        [Description("Continuous zoom up/down until stopped (-1 for wide, 1 for tele, 0 to stop zooming)")]
        ZOOM_TYPE_CONTINUOUS=1, 
        ///<summary> Zoom value as proportion of full camera range (a percentage value between 0.0 and 100.0) | </summary>
        [Description("Zoom value as proportion of full camera range (a percentage value between 0.0 and 100.0)")]
        ZOOM_TYPE_RANGE=2, 
        ///<summary> Zoom value/variable focal length in millimetres. Note that there is no message to get the valid zoom range of the camera, so this can type can only be used for cameras where the zoom range is known (implying that this cannot reliably be used in a GCS for an arbitrary camera) | </summary>
        [Description("Zoom value/variable focal length in millimetres. Note that there is no message to get the valid zoom range of the camera, so this can type can only be used for cameras where the zoom range is known (implying that this cannot reliably be used in a GCS for an arbitrary camera)")]
        ZOOM_TYPE_FOCAL_LENGTH=3, 
        ///<summary> Zoom value as horizontal field of view in degrees. | </summary>
        [Description("Zoom value as horizontal field of view in degrees.")]
        ZOOM_TYPE_HORIZONTAL_FOV=4, 
        
    };
    
    ///<summary> Focus types for MAV_CMD_SET_CAMERA_FOCUS </summary>
    public enum SET_FOCUS_TYPE: int /*default*/
    {
        ///<summary> Focus one step increment (-1 for focusing in, 1 for focusing out towards infinity). | </summary>
        [Description("Focus one step increment (-1 for focusing in, 1 for focusing out towards infinity).")]
        FOCUS_TYPE_STEP=0, 
        ///<summary> Continuous focus up/down until stopped (-1 for focusing in, 1 for focusing out towards infinity, 0 to stop focusing) | </summary>
        [Description("Continuous focus up/down until stopped (-1 for focusing in, 1 for focusing out towards infinity, 0 to stop focusing)")]
        FOCUS_TYPE_CONTINUOUS=1, 
        ///<summary> Focus value as proportion of full camera focus range (a value between 0.0 and 100.0) | </summary>
        [Description("Focus value as proportion of full camera focus range (a value between 0.0 and 100.0)")]
        FOCUS_TYPE_RANGE=2, 
        ///<summary> Focus value in metres. Note that there is no message to get the valid focus range of the camera, so this can type can only be used for cameras where the range is known (implying that this cannot reliably be used in a GCS for an arbitrary camera). | </summary>
        [Description("Focus value in metres. Note that there is no message to get the valid focus range of the camera, so this can type can only be used for cameras where the range is known (implying that this cannot reliably be used in a GCS for an arbitrary camera).")]
        FOCUS_TYPE_METERS=3, 
        ///<summary> Focus automatically. | </summary>
        [Description("Focus automatically.")]
        FOCUS_TYPE_AUTO=4, 
        ///<summary> Single auto focus. Mainly used for still pictures. Usually abbreviated as AF-S. | </summary>
        [Description("Single auto focus. Mainly used for still pictures. Usually abbreviated as AF-S.")]
        FOCUS_TYPE_AUTO_SINGLE=5, 
        ///<summary> Continuous auto focus. Mainly used for dynamic scenes. Abbreviated as AF-C. | </summary>
        [Description("Continuous auto focus. Mainly used for dynamic scenes. Abbreviated as AF-C.")]
        FOCUS_TYPE_AUTO_CONTINUOUS=6, 
        
    };
    
    ///<summary> Result from PARAM_EXT_SET message (or a PARAM_SET within a transaction). </summary>
    public enum PARAM_ACK: int /*default*/
    {
        ///<summary> Parameter value ACCEPTED and SET | </summary>
        [Description("Parameter value ACCEPTED and SET")]
        ACCEPTED=0, 
        ///<summary> Parameter value UNKNOWN/UNSUPPORTED | </summary>
        [Description("Parameter value UNKNOWN/UNSUPPORTED")]
        VALUE_UNSUPPORTED=1, 
        ///<summary> Parameter failed to set | </summary>
        [Description("Parameter failed to set")]
        FAILED=2, 
        ///<summary> Parameter value received but not yet set/accepted. A subsequent PARAM_ACK_TRANSACTION or PARAM_EXT_ACK with the final result will follow once operation is completed. This is returned immediately for parameters that take longer to set, indicating that the the parameter was received and does not need to be resent. | </summary>
        [Description("Parameter value received but not yet set/accepted. A subsequent PARAM_ACK_TRANSACTION or PARAM_EXT_ACK with the final result will follow once operation is completed. This is returned immediately for parameters that take longer to set, indicating that the the parameter was received and does not need to be resent.")]
        IN_PROGRESS=3, 
        
    };
    
    ///<summary> Camera Modes. </summary>
    public enum CAMERA_MODE: int /*default*/
    {
        ///<summary> Camera is in image/photo capture mode. | </summary>
        [Description("Camera is in image/photo capture mode.")]
        IMAGE=0, 
        ///<summary> Camera is in video capture mode. | </summary>
        [Description("Camera is in video capture mode.")]
        VIDEO=1, 
        ///<summary> Camera is in image survey capture mode. It allows for camera controller to do specific settings for surveys. | </summary>
        [Description("Camera is in image survey capture mode. It allows for camera controller to do specific settings for surveys.")]
        IMAGE_SURVEY=2, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ARM_AUTH_DENIED_REASON: int /*default*/
    {
        ///<summary> Not a specific reason | </summary>
        [Description("Not a specific reason")]
        GENERIC=0, 
        ///<summary> Authorizer will send the error as string to GCS | </summary>
        [Description("Authorizer will send the error as string to GCS")]
        NONE=1, 
        ///<summary> At least one waypoint have a invalid value | </summary>
        [Description("At least one waypoint have a invalid value")]
        INVALID_WAYPOINT=2, 
        ///<summary> Timeout in the authorizer process(in case it depends on network) | </summary>
        [Description("Timeout in the authorizer process(in case it depends on network)")]
        TIMEOUT=3, 
        ///<summary> Airspace of the mission in use by another vehicle, second result parameter can have the waypoint id that caused it to be denied. | </summary>
        [Description("Airspace of the mission in use by another vehicle, second result parameter can have the waypoint id that caused it to be denied.")]
        AIRSPACE_IN_USE=4, 
        ///<summary> Weather is not good to fly | </summary>
        [Description("Weather is not good to fly")]
        BAD_WEATHER=5, 
        
    };
    
    ///<summary> RC type </summary>
    public enum RC_TYPE: int /*default*/
    {
        ///<summary> Spektrum DSM2 | </summary>
        [Description("Spektrum DSM2")]
        SPEKTRUM_DSM2=0, 
        ///<summary> Spektrum DSMX | </summary>
        [Description("Spektrum DSMX")]
        SPEKTRUM_DSMX=1, 
        
    };
    
    ///<summary> Bitmap to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 9 is set the floats afx afy afz should be interpreted as force instead of acceleration. </summary>
    public enum POSITION_TARGET_TYPEMASK: ushort
    {
        ///<summary> Ignore position x | </summary>
        [Description("Ignore position x")]
        X_IGNORE=1, 
        ///<summary> Ignore position y | </summary>
        [Description("Ignore position y")]
        Y_IGNORE=2, 
        ///<summary> Ignore position z | </summary>
        [Description("Ignore position z")]
        Z_IGNORE=4, 
        ///<summary> Ignore velocity x | </summary>
        [Description("Ignore velocity x")]
        VX_IGNORE=8, 
        ///<summary> Ignore velocity y | </summary>
        [Description("Ignore velocity y")]
        VY_IGNORE=16, 
        ///<summary> Ignore velocity z | </summary>
        [Description("Ignore velocity z")]
        VZ_IGNORE=32, 
        ///<summary> Ignore acceleration x | </summary>
        [Description("Ignore acceleration x")]
        AX_IGNORE=64, 
        ///<summary> Ignore acceleration y | </summary>
        [Description("Ignore acceleration y")]
        AY_IGNORE=128, 
        ///<summary> Ignore acceleration z | </summary>
        [Description("Ignore acceleration z")]
        AZ_IGNORE=256, 
        ///<summary> Use force instead of acceleration | </summary>
        [Description("Use force instead of acceleration")]
        FORCE_SET=512, 
        ///<summary> Ignore yaw | </summary>
        [Description("Ignore yaw")]
        YAW_IGNORE=1024, 
        ///<summary> Ignore yaw rate | </summary>
        [Description("Ignore yaw rate")]
        YAW_RATE_IGNORE=2048, 
        
    };
    
    ///<summary> Bitmap to indicate which dimensions should be ignored by the vehicle: a value of 0b00000000 indicates that none of the setpoint dimensions should be ignored. </summary>
    public enum ATTITUDE_TARGET_TYPEMASK: byte
    {
        ///<summary> Ignore body roll rate | </summary>
        [Description("Ignore body roll rate")]
        BODY_ROLL_RATE_IGNORE=1, 
        ///<summary> Ignore body pitch rate | </summary>
        [Description("Ignore body pitch rate")]
        BODY_PITCH_RATE_IGNORE=2, 
        ///<summary> Ignore body yaw rate | </summary>
        [Description("Ignore body yaw rate")]
        BODY_YAW_RATE_IGNORE=4, 
        ///<summary> Use 3D body thrust setpoint instead of throttle | </summary>
        [Description("Use 3D body thrust setpoint instead of throttle")]
        THRUST_BODY_SET=32, 
        ///<summary> Ignore throttle | </summary>
        [Description("Ignore throttle")]
        THROTTLE_IGNORE=64, 
        ///<summary> Ignore attitude | </summary>
        [Description("Ignore attitude")]
        ATTITUDE_IGNORE=128, 
        
    };
    
    ///<summary> Airborne status of UAS. </summary>
    public enum UTM_FLIGHT_STATE: int /*default*/
    {
        ///<summary> The flight state can't be determined. | </summary>
        [Description("The flight state can't be determined.")]
        UNKNOWN=1, 
        ///<summary> UAS on ground. | </summary>
        [Description("UAS on ground.")]
        GROUND=2, 
        ///<summary> UAS airborne. | </summary>
        [Description("UAS airborne.")]
        AIRBORNE=3, 
        ///<summary> UAS is in an emergency flight state. | </summary>
        [Description("UAS is in an emergency flight state.")]
        EMERGENCY=16, 
        ///<summary> UAS has no active controls. | </summary>
        [Description("UAS has no active controls.")]
        NOCTRL=32, 
        
    };
    
    ///<summary> Flags for the global position report. </summary>
    [Flags]
	public enum UTM_DATA_AVAIL_FLAGS: int /*default*/
    {
        ///<summary> The field time contains valid data. | </summary>
        [Description("The field time contains valid data.")]
        TIME_VALID=1, 
        ///<summary> The field uas_id contains valid data. | </summary>
        [Description("The field uas_id contains valid data.")]
        UAS_ID_AVAILABLE=2, 
        ///<summary> The fields lat, lon and h_acc contain valid data. | </summary>
        [Description("The fields lat, lon and h_acc contain valid data.")]
        POSITION_AVAILABLE=4, 
        ///<summary> The fields alt and v_acc contain valid data. | </summary>
        [Description("The fields alt and v_acc contain valid data.")]
        ALTITUDE_AVAILABLE=8, 
        ///<summary> The field relative_alt contains valid data. | </summary>
        [Description("The field relative_alt contains valid data.")]
        RELATIVE_ALTITUDE_AVAILABLE=16, 
        ///<summary> The fields vx and vy contain valid data. | </summary>
        [Description("The fields vx and vy contain valid data.")]
        HORIZONTAL_VELO_AVAILABLE=32, 
        ///<summary> The field vz contains valid data. | </summary>
        [Description("The field vz contains valid data.")]
        VERTICAL_VELO_AVAILABLE=64, 
        ///<summary> The fields next_lat, next_lon and next_alt contain valid data. | </summary>
        [Description("The fields next_lat, next_lon and next_alt contain valid data.")]
        NEXT_WAYPOINT_AVAILABLE=128, 
        
    };
    
    ///<summary> These flags encode the cellular network status </summary>
    public enum CELLULAR_STATUS_FLAG: int /*default*/
    {
        ///<summary> State unknown or not reportable. | </summary>
        [Description("State unknown or not reportable.")]
        UNKNOWN=0, 
        ///<summary> Modem is unusable | </summary>
        [Description("Modem is unusable")]
        FAILED=1, 
        ///<summary> Modem is being initialized | </summary>
        [Description("Modem is being initialized")]
        INITIALIZING=2, 
        ///<summary> Modem is locked | </summary>
        [Description("Modem is locked")]
        LOCKED=3, 
        ///<summary> Modem is not enabled and is powered down | </summary>
        [Description("Modem is not enabled and is powered down")]
        DISABLED=4, 
        ///<summary> Modem is currently transitioning to the CELLULAR_STATUS_FLAG_DISABLED state | </summary>
        [Description("Modem is currently transitioning to the CELLULAR_STATUS_FLAG_DISABLED state")]
        DISABLING=5, 
        ///<summary> Modem is currently transitioning to the CELLULAR_STATUS_FLAG_ENABLED state | </summary>
        [Description("Modem is currently transitioning to the CELLULAR_STATUS_FLAG_ENABLED state")]
        ENABLING=6, 
        ///<summary> Modem is enabled and powered on but not registered with a network provider and not available for data connections | </summary>
        [Description("Modem is enabled and powered on but not registered with a network provider and not available for data connections")]
        ENABLED=7, 
        ///<summary> Modem is searching for a network provider to register | </summary>
        [Description("Modem is searching for a network provider to register")]
        SEARCHING=8, 
        ///<summary> Modem is registered with a network provider, and data connections and messaging may be available for use | </summary>
        [Description("Modem is registered with a network provider, and data connections and messaging may be available for use")]
        REGISTERED=9, 
        ///<summary> Modem is disconnecting and deactivating the last active packet data bearer. This state will not be entered if more than one packet data bearer is active and one of the active bearers is deactivated | </summary>
        [Description("Modem is disconnecting and deactivating the last active packet data bearer. This state will not be entered if more than one packet data bearer is active and one of the active bearers is deactivated")]
        DISCONNECTING=10, 
        ///<summary> Modem is activating and connecting the first packet data bearer. Subsequent bearer activations when another bearer is already active do not cause this state to be entered | </summary>
        [Description("Modem is activating and connecting the first packet data bearer. Subsequent bearer activations when another bearer is already active do not cause this state to be entered")]
        CONNECTING=11, 
        ///<summary> One or more packet data bearers is active and connected | </summary>
        [Description("One or more packet data bearers is active and connected")]
        CONNECTED=12, 
        
    };
    
    ///<summary> These flags are used to diagnose the failure state of CELLULAR_STATUS </summary>
    public enum CELLULAR_NETWORK_FAILED_REASON: int /*default*/
    {
        ///<summary> No error | </summary>
        [Description("No error")]
        NONE=0, 
        ///<summary> Error state is unknown | </summary>
        [Description("Error state is unknown")]
        UNKNOWN=1, 
        ///<summary> SIM is required for the modem but missing | </summary>
        [Description("SIM is required for the modem but missing")]
        SIM_MISSING=2, 
        ///<summary> SIM is available, but not usable for connection | </summary>
        [Description("SIM is available, but not usable for connection")]
        SIM_ERROR=3, 
        
    };
    
    ///<summary> Cellular network radio type </summary>
    public enum CELLULAR_NETWORK_RADIO_TYPE: int /*default*/
    {
        ///<summary>  | </summary>
        [Description("")]
        NONE=0, 
        ///<summary>  | </summary>
        [Description("")]
        GSM=1, 
        ///<summary>  | </summary>
        [Description("")]
        CDMA=2, 
        ///<summary>  | </summary>
        [Description("")]
        WCDMA=3, 
        ///<summary>  | </summary>
        [Description("")]
        LTE=4, 
        
    };
    
    ///<summary> Precision land modes (used in MAV_CMD_NAV_LAND). </summary>
    public enum PRECISION_LAND_MODE: int /*default*/
    {
        ///<summary> Normal (non-precision) landing. | </summary>
        [Description("Normal (non-precision) landing.")]
        DISABLED=0, 
        ///<summary> Use precision landing if beacon detected when land command accepted, otherwise land normally. | </summary>
        [Description("Use precision landing if beacon detected when land command accepted, otherwise land normally.")]
        OPPORTUNISTIC=1, 
        ///<summary> Use precision landing, searching for beacon if not found when land command accepted (land normally if beacon cannot be found). | </summary>
        [Description("Use precision landing, searching for beacon if not found when land command accepted (land normally if beacon cannot be found).")]
        REQUIRED=2, 
        
    };
    
    ///<summary> Parachute actions. Trigger release and enable/disable auto-release. </summary>
    public enum PARACHUTE_ACTION: int /*default*/
    {
        ///<summary> Disable auto-release of parachute (i.e. release triggered by crash detectors). | </summary>
        [Description("Disable auto-release of parachute (i.e. release triggered by crash detectors).")]
        PARACHUTE_DISABLE=0, 
        ///<summary> Enable auto-release of parachute. | </summary>
        [Description("Enable auto-release of parachute.")]
        PARACHUTE_ENABLE=1, 
        ///<summary> Release parachute and kill motors. | </summary>
        [Description("Release parachute and kill motors.")]
        PARACHUTE_RELEASE=2, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_TUNNEL_PAYLOAD_TYPE: int /*default*/
    {
        ///<summary> Encoding of payload unknown. | </summary>
        [Description("Encoding of payload unknown.")]
        UNKNOWN=0, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED0=200, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED1=201, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED2=202, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED3=203, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED4=204, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED5=205, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED6=206, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED7=207, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED8=208, 
        ///<summary> Registered for STorM32 gimbal controller. | </summary>
        [Description("Registered for STorM32 gimbal controller.")]
        STORM32_RESERVED9=209, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_ID_TYPE: int /*default*/
    {
        ///<summary> No type defined. | </summary>
        [Description("No type defined.")]
        NONE=0, 
        ///<summary> Manufacturer Serial Number (ANSI/CTA-2063 format). | </summary>
        [Description("Manufacturer Serial Number (ANSI/CTA-2063 format).")]
        SERIAL_NUMBER=1, 
        ///<summary> CAA (Civil Aviation Authority) registered ID. Format: [ICAO Country Code].[CAA Assigned ID]. | </summary>
        [Description("CAA (Civil Aviation Authority) registered ID. Format: [ICAO Country Code].[CAA Assigned ID].")]
        CAA_REGISTRATION_ID=2, 
        ///<summary> UTM (Unmanned Traffic Management) assigned UUID (RFC4122). | </summary>
        [Description("UTM (Unmanned Traffic Management) assigned UUID (RFC4122).")]
        UTM_ASSIGNED_UUID=3, 
        ///<summary> A 20 byte ID for a specific flight/session. The exact ID type is indicated by the first byte of uas_id and these type values are managed by ICAO. | </summary>
        [Description("A 20 byte ID for a specific flight/session. The exact ID type is indicated by the first byte of uas_id and these type values are managed by ICAO.")]
        SPECIFIC_SESSION_ID=4, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_UA_TYPE: int /*default*/
    {
        ///<summary> No UA (Unmanned Aircraft) type defined. | </summary>
        [Description("No UA (Unmanned Aircraft) type defined.")]
        NONE=0, 
        ///<summary> Aeroplane/Airplane. Fixed wing. | </summary>
        [Description("Aeroplane/Airplane. Fixed wing.")]
        AEROPLANE=1, 
        ///<summary> Helicopter or multirotor. | </summary>
        [Description("Helicopter or multirotor.")]
        HELICOPTER_OR_MULTIROTOR=2, 
        ///<summary> Gyroplane. | </summary>
        [Description("Gyroplane.")]
        GYROPLANE=3, 
        ///<summary> VTOL (Vertical Take-Off and Landing). Fixed wing aircraft that can take off vertically. | </summary>
        [Description("VTOL (Vertical Take-Off and Landing). Fixed wing aircraft that can take off vertically.")]
        HYBRID_LIFT=4, 
        ///<summary> Ornithopter. | </summary>
        [Description("Ornithopter.")]
        ORNITHOPTER=5, 
        ///<summary> Glider. | </summary>
        [Description("Glider.")]
        GLIDER=6, 
        ///<summary> Kite. | </summary>
        [Description("Kite.")]
        KITE=7, 
        ///<summary> Free Balloon. | </summary>
        [Description("Free Balloon.")]
        FREE_BALLOON=8, 
        ///<summary> Captive Balloon. | </summary>
        [Description("Captive Balloon.")]
        CAPTIVE_BALLOON=9, 
        ///<summary> Airship. E.g. a blimp. | </summary>
        [Description("Airship. E.g. a blimp.")]
        AIRSHIP=10, 
        ///<summary> Free Fall/Parachute (unpowered). | </summary>
        [Description("Free Fall/Parachute (unpowered).")]
        FREE_FALL_PARACHUTE=11, 
        ///<summary> Rocket. | </summary>
        [Description("Rocket.")]
        ROCKET=12, 
        ///<summary> Tethered powered aircraft. | </summary>
        [Description("Tethered powered aircraft.")]
        TETHERED_POWERED_AIRCRAFT=13, 
        ///<summary> Ground Obstacle. | </summary>
        [Description("Ground Obstacle.")]
        GROUND_OBSTACLE=14, 
        ///<summary> Other type of aircraft not listed earlier. | </summary>
        [Description("Other type of aircraft not listed earlier.")]
        OTHER=15, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_STATUS: int /*default*/
    {
        ///<summary> The status of the (UA) Unmanned Aircraft is undefined. | </summary>
        [Description("The status of the (UA) Unmanned Aircraft is undefined.")]
        UNDECLARED=0, 
        ///<summary> The UA is on the ground. | </summary>
        [Description("The UA is on the ground.")]
        GROUND=1, 
        ///<summary> The UA is in the air. | </summary>
        [Description("The UA is in the air.")]
        AIRBORNE=2, 
        ///<summary> The UA is having an emergency. | </summary>
        [Description("The UA is having an emergency.")]
        EMERGENCY=3, 
        ///<summary> The remote ID system is failing or unreliable in some way. | </summary>
        [Description("The remote ID system is failing or unreliable in some way.")]
        REMOTE_ID_SYSTEM_FAILURE=4, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_HEIGHT_REF: int /*default*/
    {
        ///<summary> The height field is relative to the take-off location. | </summary>
        [Description("The height field is relative to the take-off location.")]
        OVER_TAKEOFF=0, 
        ///<summary> The height field is relative to ground. | </summary>
        [Description("The height field is relative to ground.")]
        OVER_GROUND=1, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_HOR_ACC: int /*default*/
    {
        ///<summary> The horizontal accuracy is unknown. | </summary>
        [Description("The horizontal accuracy is unknown.")]
        UNKNOWN=0, 
        ///<summary> The horizontal accuracy is smaller than 10 Nautical Miles. 18.52 km. | </summary>
        [Description("The horizontal accuracy is smaller than 10 Nautical Miles. 18.52 km.")]
        _10NM=1, 
        ///<summary> The horizontal accuracy is smaller than 4 Nautical Miles. 7.408 km. | </summary>
        [Description("The horizontal accuracy is smaller than 4 Nautical Miles. 7.408 km.")]
        _4NM=2, 
        ///<summary> The horizontal accuracy is smaller than 2 Nautical Miles. 3.704 km. | </summary>
        [Description("The horizontal accuracy is smaller than 2 Nautical Miles. 3.704 km.")]
        _2NM=3, 
        ///<summary> The horizontal accuracy is smaller than 1 Nautical Miles. 1.852 km. | </summary>
        [Description("The horizontal accuracy is smaller than 1 Nautical Miles. 1.852 km.")]
        _1NM=4, 
        ///<summary> The horizontal accuracy is smaller than 0.5 Nautical Miles. 926 m. | </summary>
        [Description("The horizontal accuracy is smaller than 0.5 Nautical Miles. 926 m.")]
        _0_5NM=5, 
        ///<summary> The horizontal accuracy is smaller than 0.3 Nautical Miles. 555.6 m. | </summary>
        [Description("The horizontal accuracy is smaller than 0.3 Nautical Miles. 555.6 m.")]
        _0_3NM=6, 
        ///<summary> The horizontal accuracy is smaller than 0.1 Nautical Miles. 185.2 m. | </summary>
        [Description("The horizontal accuracy is smaller than 0.1 Nautical Miles. 185.2 m.")]
        _0_1NM=7, 
        ///<summary> The horizontal accuracy is smaller than 0.05 Nautical Miles. 92.6 m. | </summary>
        [Description("The horizontal accuracy is smaller than 0.05 Nautical Miles. 92.6 m.")]
        _0_05NM=8, 
        ///<summary> The horizontal accuracy is smaller than 30 meter. | </summary>
        [Description("The horizontal accuracy is smaller than 30 meter.")]
        _30_METER=9, 
        ///<summary> The horizontal accuracy is smaller than 10 meter. | </summary>
        [Description("The horizontal accuracy is smaller than 10 meter.")]
        _10_METER=10, 
        ///<summary> The horizontal accuracy is smaller than 3 meter. | </summary>
        [Description("The horizontal accuracy is smaller than 3 meter.")]
        _3_METER=11, 
        ///<summary> The horizontal accuracy is smaller than 1 meter. | </summary>
        [Description("The horizontal accuracy is smaller than 1 meter.")]
        _1_METER=12, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_VER_ACC: int /*default*/
    {
        ///<summary> The vertical accuracy is unknown. | </summary>
        [Description("The vertical accuracy is unknown.")]
        UNKNOWN=0, 
        ///<summary> The vertical accuracy is smaller than 150 meter. | </summary>
        [Description("The vertical accuracy is smaller than 150 meter.")]
        _150_METER=1, 
        ///<summary> The vertical accuracy is smaller than 45 meter. | </summary>
        [Description("The vertical accuracy is smaller than 45 meter.")]
        _45_METER=2, 
        ///<summary> The vertical accuracy is smaller than 25 meter. | </summary>
        [Description("The vertical accuracy is smaller than 25 meter.")]
        _25_METER=3, 
        ///<summary> The vertical accuracy is smaller than 10 meter. | </summary>
        [Description("The vertical accuracy is smaller than 10 meter.")]
        _10_METER=4, 
        ///<summary> The vertical accuracy is smaller than 3 meter. | </summary>
        [Description("The vertical accuracy is smaller than 3 meter.")]
        _3_METER=5, 
        ///<summary> The vertical accuracy is smaller than 1 meter. | </summary>
        [Description("The vertical accuracy is smaller than 1 meter.")]
        _1_METER=6, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_SPEED_ACC: int /*default*/
    {
        ///<summary> The speed accuracy is unknown. | </summary>
        [Description("The speed accuracy is unknown.")]
        UNKNOWN=0, 
        ///<summary> The speed accuracy is smaller than 10 meters per second. | </summary>
        [Description("The speed accuracy is smaller than 10 meters per second.")]
        _10_METERS_PER_SECOND=1, 
        ///<summary> The speed accuracy is smaller than 3 meters per second. | </summary>
        [Description("The speed accuracy is smaller than 3 meters per second.")]
        _3_METERS_PER_SECOND=2, 
        ///<summary> The speed accuracy is smaller than 1 meters per second. | </summary>
        [Description("The speed accuracy is smaller than 1 meters per second.")]
        _1_METERS_PER_SECOND=3, 
        ///<summary> The speed accuracy is smaller than 0.3 meters per second. | </summary>
        [Description("The speed accuracy is smaller than 0.3 meters per second.")]
        _0_3_METERS_PER_SECOND=4, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_TIME_ACC: int /*default*/
    {
        ///<summary> The timestamp accuracy is unknown. | </summary>
        [Description("The timestamp accuracy is unknown.")]
        UNKNOWN=0, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.1 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.1 second.")]
        _0_1_SECOND=1, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.2 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.2 second.")]
        _0_2_SECOND=2, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.3 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.3 second.")]
        _0_3_SECOND=3, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.4 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.4 second.")]
        _0_4_SECOND=4, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.5 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.5 second.")]
        _0_5_SECOND=5, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.6 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.6 second.")]
        _0_6_SECOND=6, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.7 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.7 second.")]
        _0_7_SECOND=7, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.8 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.8 second.")]
        _0_8_SECOND=8, 
        ///<summary> The timestamp accuracy is smaller than or equal to 0.9 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 0.9 second.")]
        _0_9_SECOND=9, 
        ///<summary> The timestamp accuracy is smaller than or equal to 1.0 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 1.0 second.")]
        _1_0_SECOND=10, 
        ///<summary> The timestamp accuracy is smaller than or equal to 1.1 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 1.1 second.")]
        _1_1_SECOND=11, 
        ///<summary> The timestamp accuracy is smaller than or equal to 1.2 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 1.2 second.")]
        _1_2_SECOND=12, 
        ///<summary> The timestamp accuracy is smaller than or equal to 1.3 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 1.3 second.")]
        _1_3_SECOND=13, 
        ///<summary> The timestamp accuracy is smaller than or equal to 1.4 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 1.4 second.")]
        _1_4_SECOND=14, 
        ///<summary> The timestamp accuracy is smaller than or equal to 1.5 second. | </summary>
        [Description("The timestamp accuracy is smaller than or equal to 1.5 second.")]
        _1_5_SECOND=15, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_AUTH_TYPE: int /*default*/
    {
        ///<summary> No authentication type is specified. | </summary>
        [Description("No authentication type is specified.")]
        NONE=0, 
        ///<summary> Signature for the UAS (Unmanned Aircraft System) ID. | </summary>
        [Description("Signature for the UAS (Unmanned Aircraft System) ID.")]
        UAS_ID_SIGNATURE=1, 
        ///<summary> Signature for the Operator ID. | </summary>
        [Description("Signature for the Operator ID.")]
        OPERATOR_ID_SIGNATURE=2, 
        ///<summary> Signature for the entire message set. | </summary>
        [Description("Signature for the entire message set.")]
        MESSAGE_SET_SIGNATURE=3, 
        ///<summary> Authentication is provided by Network Remote ID. | </summary>
        [Description("Authentication is provided by Network Remote ID.")]
        NETWORK_REMOTE_ID=4, 
        ///<summary> The exact authentication type is indicated by the first byte of authentication_data and these type values are managed by ICAO. | </summary>
        [Description("The exact authentication type is indicated by the first byte of authentication_data and these type values are managed by ICAO.")]
        SPECIFIC_AUTHENTICATION=5, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_DESC_TYPE: int /*default*/
    {
        ///<summary> Optional free-form text description of the purpose of the flight. | </summary>
        [Description("Optional free-form text description of the purpose of the flight.")]
        TEXT=0, 
        ///<summary> Optional additional clarification when status == MAV_ODID_STATUS_EMERGENCY. | </summary>
        [Description("Optional additional clarification when status == MAV_ODID_STATUS_EMERGENCY.")]
        EMERGENCY=1, 
        ///<summary> Optional additional clarification when status != MAV_ODID_STATUS_EMERGENCY. | </summary>
        [Description("Optional additional clarification when status != MAV_ODID_STATUS_EMERGENCY.")]
        EXTENDED_STATUS=2, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_OPERATOR_LOCATION_TYPE: int /*default*/
    {
        ///<summary> The location/altitude of the operator is the same as the take-off location. | </summary>
        [Description("The location/altitude of the operator is the same as the take-off location.")]
        TAKEOFF=0, 
        ///<summary> The location/altitude of the operator is dynamic. E.g. based on live GNSS data. | </summary>
        [Description("The location/altitude of the operator is dynamic. E.g. based on live GNSS data.")]
        LIVE_GNSS=1, 
        ///<summary> The location/altitude of the operator are fixed values. | </summary>
        [Description("The location/altitude of the operator are fixed values.")]
        FIXED=2, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_CLASSIFICATION_TYPE: int /*default*/
    {
        ///<summary> The classification type for the UA is undeclared. | </summary>
        [Description("The classification type for the UA is undeclared.")]
        UNDECLARED=0, 
        ///<summary> The classification type for the UA follows EU (European Union) specifications. | </summary>
        [Description("The classification type for the UA follows EU (European Union) specifications.")]
        EU=1, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_CATEGORY_EU: int /*default*/
    {
        ///<summary> The category for the UA, according to the EU specification, is undeclared. | </summary>
        [Description("The category for the UA, according to the EU specification, is undeclared.")]
        UNDECLARED=0, 
        ///<summary> The category for the UA, according to the EU specification, is the Open category. | </summary>
        [Description("The category for the UA, according to the EU specification, is the Open category.")]
        OPEN=1, 
        ///<summary> The category for the UA, according to the EU specification, is the Specific category. | </summary>
        [Description("The category for the UA, according to the EU specification, is the Specific category.")]
        SPECIFIC=2, 
        ///<summary> The category for the UA, according to the EU specification, is the Certified category. | </summary>
        [Description("The category for the UA, according to the EU specification, is the Certified category.")]
        CERTIFIED=3, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_CLASS_EU: int /*default*/
    {
        ///<summary> The class for the UA, according to the EU specification, is undeclared. | </summary>
        [Description("The class for the UA, according to the EU specification, is undeclared.")]
        UNDECLARED=0, 
        ///<summary> The class for the UA, according to the EU specification, is Class 0. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 0.")]
        CLASS_0=1, 
        ///<summary> The class for the UA, according to the EU specification, is Class 1. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 1.")]
        CLASS_1=2, 
        ///<summary> The class for the UA, according to the EU specification, is Class 2. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 2.")]
        CLASS_2=3, 
        ///<summary> The class for the UA, according to the EU specification, is Class 3. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 3.")]
        CLASS_3=4, 
        ///<summary> The class for the UA, according to the EU specification, is Class 4. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 4.")]
        CLASS_4=5, 
        ///<summary> The class for the UA, according to the EU specification, is Class 5. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 5.")]
        CLASS_5=6, 
        ///<summary> The class for the UA, according to the EU specification, is Class 6. | </summary>
        [Description("The class for the UA, according to the EU specification, is Class 6.")]
        CLASS_6=7, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_OPERATOR_ID_TYPE: int /*default*/
    {
        ///<summary> CAA (Civil Aviation Authority) registered operator ID. | </summary>
        [Description("CAA (Civil Aviation Authority) registered operator ID.")]
        CAA=0, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_ODID_ARM_STATUS: int /*default*/
    {
        ///<summary> Passing arming checks. | </summary>
        [Description("Passing arming checks.")]
        GOOD_TO_ARM=0, 
        ///<summary> Generic arming failure, see error string for details. | </summary>
        [Description("Generic arming failure, see error string for details.")]
        PRE_ARM_FAIL_GENERIC=1, 
        
    };
    
    ///<summary> Tune formats (used for vehicle buzzer/tone generation). </summary>
    public enum TUNE_FORMAT: int /*default*/
    {
        ///<summary> Format is QBasic 1.1 Play: https://www.qbasic.net/en/reference/qb11/Statement/PLAY-006.htm. | </summary>
        [Description("Format is QBasic 1.1 Play: https://www.qbasic.net/en/reference/qb11/Statement/PLAY-006.htm.")]
        QBASIC1_1=1, 
        ///<summary> Format is Modern Music Markup Language (MML): https://en.wikipedia.org/wiki/Music_Macro_Language#Modern_MML. | </summary>
        [Description("Format is Modern Music Markup Language (MML): https://en.wikipedia.org/wiki/Music_Macro_Language#Modern_MML.")]
        MML_MODERN=2, 
        
    };
    
    ///<summary> Type of AIS vessel, enum duplicated from AIS standard, https://gpsd.gitlab.io/gpsd/AIVDM.html </summary>
    public enum AIS_TYPE: int /*default*/
    {
        ///<summary> Not available (default). | </summary>
        [Description("Not available (default).")]
        UNKNOWN=0, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_1=1, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_2=2, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_3=3, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_4=4, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_5=5, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_6=6, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_7=7, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_8=8, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_9=9, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_10=10, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_11=11, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_12=12, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_13=13, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_14=14, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_15=15, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_16=16, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_17=17, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_18=18, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_19=19, 
        ///<summary> Wing In Ground effect. | </summary>
        [Description("Wing In Ground effect.")]
        WIG=20, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_HAZARDOUS_A=21, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_HAZARDOUS_B=22, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_HAZARDOUS_C=23, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_HAZARDOUS_D=24, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_RESERVED_1=25, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_RESERVED_2=26, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_RESERVED_3=27, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_RESERVED_4=28, 
        ///<summary>  | </summary>
        [Description("")]
        WIG_RESERVED_5=29, 
        ///<summary>  | </summary>
        [Description("")]
        FISHING=30, 
        ///<summary>  | </summary>
        [Description("")]
        TOWING=31, 
        ///<summary> Towing: length exceeds 200m or breadth exceeds 25m. | </summary>
        [Description("Towing: length exceeds 200m or breadth exceeds 25m.")]
        TOWING_LARGE=32, 
        ///<summary> Dredging or other underwater ops. | </summary>
        [Description("Dredging or other underwater ops.")]
        DREDGING=33, 
        ///<summary>  | </summary>
        [Description("")]
        DIVING=34, 
        ///<summary>  | </summary>
        [Description("")]
        MILITARY=35, 
        ///<summary>  | </summary>
        [Description("")]
        SAILING=36, 
        ///<summary>  | </summary>
        [Description("")]
        PLEASURE=37, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_20=38, 
        ///<summary>  | </summary>
        [Description("")]
        RESERVED_21=39, 
        ///<summary> High Speed Craft. | </summary>
        [Description("High Speed Craft.")]
        HSC=40, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_HAZARDOUS_A=41, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_HAZARDOUS_B=42, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_HAZARDOUS_C=43, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_HAZARDOUS_D=44, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_RESERVED_1=45, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_RESERVED_2=46, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_RESERVED_3=47, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_RESERVED_4=48, 
        ///<summary>  | </summary>
        [Description("")]
        HSC_UNKNOWN=49, 
        ///<summary>  | </summary>
        [Description("")]
        PILOT=50, 
        ///<summary> Search And Rescue vessel. | </summary>
        [Description("Search And Rescue vessel.")]
        SAR=51, 
        ///<summary>  | </summary>
        [Description("")]
        TUG=52, 
        ///<summary>  | </summary>
        [Description("")]
        PORT_TENDER=53, 
        ///<summary> Anti-pollution equipment. | </summary>
        [Description("Anti-pollution equipment.")]
        ANTI_POLLUTION=54, 
        ///<summary>  | </summary>
        [Description("")]
        LAW_ENFORCEMENT=55, 
        ///<summary>  | </summary>
        [Description("")]
        SPARE_LOCAL_1=56, 
        ///<summary>  | </summary>
        [Description("")]
        SPARE_LOCAL_2=57, 
        ///<summary>  | </summary>
        [Description("")]
        MEDICAL_TRANSPORT=58, 
        ///<summary> Noncombatant ship according to RR Resolution No. 18. | </summary>
        [Description("Noncombatant ship according to RR Resolution No. 18.")]
        NONECOMBATANT=59, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER=60, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_HAZARDOUS_A=61, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_HAZARDOUS_B=62, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_HAZARDOUS_C=63, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_HAZARDOUS_D=64, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_RESERVED_1=65, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_RESERVED_2=66, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_RESERVED_3=67, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_RESERVED_4=68, 
        ///<summary>  | </summary>
        [Description("")]
        PASSENGER_UNKNOWN=69, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO=70, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_HAZARDOUS_A=71, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_HAZARDOUS_B=72, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_HAZARDOUS_C=73, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_HAZARDOUS_D=74, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_RESERVED_1=75, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_RESERVED_2=76, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_RESERVED_3=77, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_RESERVED_4=78, 
        ///<summary>  | </summary>
        [Description("")]
        CARGO_UNKNOWN=79, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER=80, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_HAZARDOUS_A=81, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_HAZARDOUS_B=82, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_HAZARDOUS_C=83, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_HAZARDOUS_D=84, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_RESERVED_1=85, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_RESERVED_2=86, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_RESERVED_3=87, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_RESERVED_4=88, 
        ///<summary>  | </summary>
        [Description("")]
        TANKER_UNKNOWN=89, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER=90, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_HAZARDOUS_A=91, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_HAZARDOUS_B=92, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_HAZARDOUS_C=93, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_HAZARDOUS_D=94, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_RESERVED_1=95, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_RESERVED_2=96, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_RESERVED_3=97, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_RESERVED_4=98, 
        ///<summary>  | </summary>
        [Description("")]
        OTHER_UNKNOWN=99, 
        
    };
    
    ///<summary> Navigational status of AIS vessel, enum duplicated from AIS standard, https://gpsd.gitlab.io/gpsd/AIVDM.html </summary>
    public enum AIS_NAV_STATUS: int /*default*/
    {
        ///<summary> Under way using engine. | </summary>
        [Description("Under way using engine.")]
        UNDER_WAY=0, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_ANCHORED=1, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_UN_COMMANDED=2, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_RESTRICTED_MANOEUVERABILITY=3, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_DRAUGHT_CONSTRAINED=4, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_MOORED=5, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_AGROUND=6, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_FISHING=7, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_SAILING=8, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_RESERVED_HSC=9, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_RESERVED_WIG=10, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_RESERVED_1=11, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_RESERVED_2=12, 
        ///<summary>  | </summary>
        [Description("")]
        AIS_RESERVED_3=13, 
        ///<summary> Search And Rescue Transponder. | </summary>
        [Description("Search And Rescue Transponder.")]
        AIS_AIS_SART=14, 
        ///<summary> Not available (default). | </summary>
        [Description("Not available (default).")]
        AIS_UNKNOWN=15, 
        
    };
    
    ///<summary> These flags are used in the AIS_VESSEL.fields bitmask to indicate validity of data in the other message fields. When set, the data is valid. </summary>
    [Flags]
	public enum AIS_FLAGS: int /*default*/
    {
        ///<summary> 1 = Position accuracy less than 10m, 0 = position accuracy greater than 10m. | </summary>
        [Description("1 = Position accuracy less than 10m, 0 = position accuracy greater than 10m.")]
        POSITION_ACCURACY=1, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_COG=2, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_VELOCITY=4, 
        ///<summary> 1 = Velocity over 52.5765m/s (102.2 knots) | </summary>
        [Description("1 = Velocity over 52.5765m/s (102.2 knots)")]
        HIGH_VELOCITY=8, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_TURN_RATE=16, 
        ///<summary> Only the sign of the returned turn rate value is valid, either greater than 5deg/30s or less than -5deg/30s | </summary>
        [Description("Only the sign of the returned turn rate value is valid, either greater than 5deg/30s or less than -5deg/30s")]
        TURN_RATE_SIGN_ONLY=32, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_DIMENSIONS=64, 
        ///<summary> Distance to bow is larger than 511m | </summary>
        [Description("Distance to bow is larger than 511m")]
        LARGE_BOW_DIMENSION=128, 
        ///<summary> Distance to stern is larger than 511m | </summary>
        [Description("Distance to stern is larger than 511m")]
        LARGE_STERN_DIMENSION=256, 
        ///<summary> Distance to port side is larger than 63m | </summary>
        [Description("Distance to port side is larger than 63m")]
        LARGE_PORT_DIMENSION=512, 
        ///<summary> Distance to starboard side is larger than 63m | </summary>
        [Description("Distance to starboard side is larger than 63m")]
        LARGE_STARBOARD_DIMENSION=1024, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_CALLSIGN=2048, 
        ///<summary>  | </summary>
        [Description("")]
        VALID_NAME=4096, 
        
    };
    
    ///<summary> List of possible units where failures can be injected. </summary>
    public enum FAILURE_UNIT: int /*default*/
    {
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_GYRO=0, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_ACCEL=1, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_MAG=2, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_BARO=3, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_GPS=4, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_OPTICAL_FLOW=5, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_VIO=6, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_DISTANCE_SENSOR=7, 
        ///<summary>  | </summary>
        [Description("")]
        SENSOR_AIRSPEED=8, 
        ///<summary>  | </summary>
        [Description("")]
        SYSTEM_BATTERY=100, 
        ///<summary>  | </summary>
        [Description("")]
        SYSTEM_MOTOR=101, 
        ///<summary>  | </summary>
        [Description("")]
        SYSTEM_SERVO=102, 
        ///<summary>  | </summary>
        [Description("")]
        SYSTEM_AVOIDANCE=103, 
        ///<summary>  | </summary>
        [Description("")]
        SYSTEM_RC_SIGNAL=104, 
        ///<summary>  | </summary>
        [Description("")]
        SYSTEM_MAVLINK_SIGNAL=105, 
        
    };
    
    ///<summary> List of possible failure type to inject. </summary>
    public enum FAILURE_TYPE: int /*default*/
    {
        ///<summary> No failure injected, used to reset a previous failure. | </summary>
        [Description("No failure injected, used to reset a previous failure.")]
        OK=0, 
        ///<summary> Sets unit off, so completely non-responsive. | </summary>
        [Description("Sets unit off, so completely non-responsive.")]
        OFF=1, 
        ///<summary> Unit is stuck e.g. keeps reporting the same value. | </summary>
        [Description("Unit is stuck e.g. keeps reporting the same value.")]
        STUCK=2, 
        ///<summary> Unit is reporting complete garbage. | </summary>
        [Description("Unit is reporting complete garbage.")]
        GARBAGE=3, 
        ///<summary> Unit is consistently wrong. | </summary>
        [Description("Unit is consistently wrong.")]
        WRONG=4, 
        ///<summary> Unit is slow, so e.g. reporting at slower than expected rate. | </summary>
        [Description("Unit is slow, so e.g. reporting at slower than expected rate.")]
        SLOW=5, 
        ///<summary> Data of unit is delayed in time. | </summary>
        [Description("Data of unit is delayed in time.")]
        DELAYED=6, 
        ///<summary> Unit is sometimes working, sometimes not. | </summary>
        [Description("Unit is sometimes working, sometimes not.")]
        INTERMITTENT=7, 
        
    };
    
    ///<summary>  </summary>
    public enum NAV_VTOL_LAND_OPTIONS: int /*default*/
    {
        ///<summary> Default autopilot landing behaviour. | </summary>
        [Description("Default autopilot landing behaviour.")]
        VTOL_LAND_OPTIONS_DEFAULT=0, 
        ///<summary> Descend in fixed wing mode, transitioning to multicopter mode for vertical landing when close to the ground.           The fixed wing descent pattern is at the discretion of the vehicle (e.g. transition altitude, loiter direction, radius, and speed, etc.).          | </summary>
        [Description("Descend in fixed wing mode, transitioning to multicopter mode for vertical landing when close to the ground.           The fixed wing descent pattern is at the discretion of the vehicle (e.g. transition altitude, loiter direction, radius, and speed, etc.).         ")]
        VTOL_LAND_OPTIONS_FW_DESCENT=1, 
        ///<summary> Land in multicopter mode on reaching the landing coordinates (the whole landing is by 'hover descent'). | </summary>
        [Description("Land in multicopter mode on reaching the landing coordinates (the whole landing is by 'hover descent').")]
        VTOL_LAND_OPTIONS_HOVER_DESCENT=2, 
        
    };
    
    ///<summary> Winch status flags used in WINCH_STATUS </summary>
    public enum MAV_WINCH_STATUS_FLAG: int /*default*/
    {
        ///<summary> Winch is healthy | </summary>
        [Description("Winch is healthy")]
        MAV_WINCH_STATUS_HEALTHY=1, 
        ///<summary> Winch line is fully retracted | </summary>
        [Description("Winch line is fully retracted")]
        MAV_WINCH_STATUS_FULLY_RETRACTED=2, 
        ///<summary> Winch motor is moving | </summary>
        [Description("Winch motor is moving")]
        MAV_WINCH_STATUS_MOVING=4, 
        ///<summary> Winch clutch is engaged allowing motor to move freely. | </summary>
        [Description("Winch clutch is engaged allowing motor to move freely.")]
        MAV_WINCH_STATUS_CLUTCH_ENGAGED=8, 
        ///<summary> Winch is locked by locking mechanism. | </summary>
        [Description("Winch is locked by locking mechanism.")]
        MAV_WINCH_STATUS_LOCKED=16, 
        ///<summary> Winch is gravity dropping payload. | </summary>
        [Description("Winch is gravity dropping payload.")]
        MAV_WINCH_STATUS_DROPPING=32, 
        ///<summary> Winch is arresting payload descent. | </summary>
        [Description("Winch is arresting payload descent.")]
        MAV_WINCH_STATUS_ARRESTING=64, 
        ///<summary> Winch is using torque measurements to sense the ground. | </summary>
        [Description("Winch is using torque measurements to sense the ground.")]
        MAV_WINCH_STATUS_GROUND_SENSE=128, 
        ///<summary> Winch is returning to the fully retracted position. | </summary>
        [Description("Winch is returning to the fully retracted position.")]
        MAV_WINCH_STATUS_RETRACTING=256, 
        ///<summary> Winch is redelivering the payload. This is a failover state if the line tension goes above a threshold during RETRACTING. | </summary>
        [Description("Winch is redelivering the payload. This is a failover state if the line tension goes above a threshold during RETRACTING.")]
        MAV_WINCH_STATUS_REDELIVER=512, 
        ///<summary> Winch is abandoning the line and possibly payload. Winch unspools the entire calculated line length. This is a failover state from REDELIVER if the number of attempts exceeds a threshold. | </summary>
        [Description("Winch is abandoning the line and possibly payload. Winch unspools the entire calculated line length. This is a failover state from REDELIVER if the number of attempts exceeds a threshold.")]
        MAV_WINCH_STATUS_ABANDON_LINE=1024, 
        ///<summary> Winch is engaging the locking mechanism. | </summary>
        [Description("Winch is engaging the locking mechanism.")]
        MAV_WINCH_STATUS_LOCKING=2048, 
        ///<summary> Winch is spooling on line. | </summary>
        [Description("Winch is spooling on line.")]
        MAV_WINCH_STATUS_LOAD_LINE=4096, 
        ///<summary> Winch is loading a payload. | </summary>
        [Description("Winch is loading a payload.")]
        MAV_WINCH_STATUS_LOAD_PAYLOAD=8192, 
        
    };
    
    ///<summary>  </summary>
    public enum MAG_CAL_STATUS: byte
    {
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_NOT_STARTED=0, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_WAITING_TO_START=1, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_RUNNING_STEP_ONE=2, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_RUNNING_STEP_TWO=3, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_SUCCESS=4, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_FAILED=5, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_BAD_ORIENTATION=6, 
        ///<summary>  | </summary>
        [Description("")]
        MAG_CAL_BAD_RADIUS=7, 
        
    };
    
    ///<summary> Reason for an event error response. </summary>
    public enum MAV_EVENT_ERROR_REASON: int /*default*/
    {
        ///<summary> The requested event is not available (anymore). | </summary>
        [Description("The requested event is not available (anymore).")]
        UNAVAILABLE=0, 
        
    };
    
    ///<summary> Flags for CURRENT_EVENT_SEQUENCE. </summary>
    [Flags]
	public enum MAV_EVENT_CURRENT_SEQUENCE_FLAGS: int /*default*/
    {
        ///<summary> A sequence reset has happened (e.g. vehicle reboot). | </summary>
        [Description("A sequence reset has happened (e.g. vehicle reboot).")]
        RESET=1, 
        
    };
    
    ///<summary> Flags in the HIL_SENSOR message indicate which fields have updated since the last message </summary>
    [Flags]
	public enum HIL_SENSOR_UPDATED_FLAGS: uint
    {
        ///<summary> None of the fields in HIL_SENSOR have been updated | </summary>
        [Description("None of the fields in HIL_SENSOR have been updated")]
        HIL_SENSOR_UPDATED_NONE=0, 
        ///<summary> The value in the xacc field has been updated | </summary>
        [Description("The value in the xacc field has been updated")]
        HIL_SENSOR_UPDATED_XACC=1, 
        ///<summary> The value in the yacc field has been updated | </summary>
        [Description("The value in the yacc field has been updated")]
        HIL_SENSOR_UPDATED_YACC=2, 
        ///<summary> The value in the zacc field has been updated | </summary>
        [Description("The value in the zacc field has been updated")]
        HIL_SENSOR_UPDATED_ZACC=4, 
        ///<summary> The value in the xgyro field has been updated | </summary>
        [Description("The value in the xgyro field has been updated")]
        HIL_SENSOR_UPDATED_XGYRO=8, 
        ///<summary> The value in the ygyro field has been updated | </summary>
        [Description("The value in the ygyro field has been updated")]
        HIL_SENSOR_UPDATED_YGYRO=16, 
        ///<summary> The value in the zgyro field has been updated | </summary>
        [Description("The value in the zgyro field has been updated")]
        HIL_SENSOR_UPDATED_ZGYRO=32, 
        ///<summary> The value in the xmag field has been updated | </summary>
        [Description("The value in the xmag field has been updated")]
        HIL_SENSOR_UPDATED_XMAG=64, 
        ///<summary> The value in the ymag field has been updated | </summary>
        [Description("The value in the ymag field has been updated")]
        HIL_SENSOR_UPDATED_YMAG=128, 
        ///<summary> The value in the zmag field has been updated | </summary>
        [Description("The value in the zmag field has been updated")]
        HIL_SENSOR_UPDATED_ZMAG=256, 
        ///<summary> The value in the abs_pressure field has been updated | </summary>
        [Description("The value in the abs_pressure field has been updated")]
        HIL_SENSOR_UPDATED_ABS_PRESSURE=512, 
        ///<summary> The value in the diff_pressure field has been updated | </summary>
        [Description("The value in the diff_pressure field has been updated")]
        HIL_SENSOR_UPDATED_DIFF_PRESSURE=1024, 
        ///<summary> The value in the pressure_alt field has been updated | </summary>
        [Description("The value in the pressure_alt field has been updated")]
        HIL_SENSOR_UPDATED_PRESSURE_ALT=2048, 
        ///<summary> The value in the temperature field has been updated | </summary>
        [Description("The value in the temperature field has been updated")]
        HIL_SENSOR_UPDATED_TEMPERATURE=4096, 
        ///<summary> Full reset of attitude/position/velocities/etc was performed in sim (Bit 31). | </summary>
        [Description("Full reset of attitude/position/velocities/etc was performed in sim (Bit 31).")]
        HIL_SENSOR_UPDATED_RESET=2147483648, 
        
    };
    
    ///<summary> Flags in the HIGHRES_IMU message indicate which fields have updated since the last message </summary>
    [Flags]
	public enum HIGHRES_IMU_UPDATED_FLAGS: ushort
    {
        ///<summary> None of the fields in HIGHRES_IMU have been updated | </summary>
        [Description("None of the fields in HIGHRES_IMU have been updated")]
        HIGHRES_IMU_UPDATED_NONE=0, 
        ///<summary> The value in the xacc field has been updated | </summary>
        [Description("The value in the xacc field has been updated")]
        HIGHRES_IMU_UPDATED_XACC=1, 
        ///<summary> The value in the yacc field has been updated | </summary>
        [Description("The value in the yacc field has been updated")]
        HIGHRES_IMU_UPDATED_YACC=2, 
        ///<summary> The value in the zacc field has been updated since | </summary>
        [Description("The value in the zacc field has been updated since")]
        HIGHRES_IMU_UPDATED_ZACC=4, 
        ///<summary> The value in the xgyro field has been updated | </summary>
        [Description("The value in the xgyro field has been updated")]
        HIGHRES_IMU_UPDATED_XGYRO=8, 
        ///<summary> The value in the ygyro field has been updated | </summary>
        [Description("The value in the ygyro field has been updated")]
        HIGHRES_IMU_UPDATED_YGYRO=16, 
        ///<summary> The value in the zgyro field has been updated | </summary>
        [Description("The value in the zgyro field has been updated")]
        HIGHRES_IMU_UPDATED_ZGYRO=32, 
        ///<summary> The value in the xmag field has been updated | </summary>
        [Description("The value in the xmag field has been updated")]
        HIGHRES_IMU_UPDATED_XMAG=64, 
        ///<summary> The value in the ymag field has been updated | </summary>
        [Description("The value in the ymag field has been updated")]
        HIGHRES_IMU_UPDATED_YMAG=128, 
        ///<summary> The value in the zmag field has been updated | </summary>
        [Description("The value in the zmag field has been updated")]
        HIGHRES_IMU_UPDATED_ZMAG=256, 
        ///<summary> The value in the abs_pressure field has been updated | </summary>
        [Description("The value in the abs_pressure field has been updated")]
        HIGHRES_IMU_UPDATED_ABS_PRESSURE=512, 
        ///<summary> The value in the diff_pressure field has been updated | </summary>
        [Description("The value in the diff_pressure field has been updated")]
        HIGHRES_IMU_UPDATED_DIFF_PRESSURE=1024, 
        ///<summary> The value in the pressure_alt field has been updated | </summary>
        [Description("The value in the pressure_alt field has been updated")]
        HIGHRES_IMU_UPDATED_PRESSURE_ALT=2048, 
        ///<summary> The value in the temperature field has been updated | </summary>
        [Description("The value in the temperature field has been updated")]
        HIGHRES_IMU_UPDATED_TEMPERATURE=4096, 
        ///<summary> All fields in HIGHRES_IMU have been updated. | </summary>
        [Description("All fields in HIGHRES_IMU have been updated.")]
        HIGHRES_IMU_UPDATED_ALL=65535, 
        
    };
    
    ///<summary>  </summary>
    public enum CAN_FILTER_OP: int /*default*/
    {
        ///<summary>  | </summary>
        [Description("")]
        CAN_FILTER_REPLACE=0, 
        ///<summary>  | </summary>
        [Description("")]
        CAN_FILTER_ADD=1, 
        ///<summary>  | </summary>
        [Description("")]
        CAN_FILTER_REMOVE=2, 
        
    };
    
    ///<summary> MAV FTP error codes (https://mavlink.io/en/services/ftp.html) </summary>
    public enum MAV_FTP_ERR: int /*default*/
    {
        ///<summary> None: No error | </summary>
        [Description("None: No error")]
        NONE=0, 
        ///<summary> Fail: Unknown failure | </summary>
        [Description("Fail: Unknown failure")]
        FAIL=1, 
        ///<summary> FailErrno: Command failed, Err number sent back in PayloadHeader.data[1]. 		This is a file-system error number understood by the server operating system. | </summary>
        [Description("FailErrno: Command failed, Err number sent back in PayloadHeader.data[1]. 		This is a file-system error number understood by the server operating system.")]
        FAILERRNO=2, 
        ///<summary> InvalidDataSize: Payload size is invalid | </summary>
        [Description("InvalidDataSize: Payload size is invalid")]
        INVALIDDATASIZE=3, 
        ///<summary> InvalidSession: Session is not currently open | </summary>
        [Description("InvalidSession: Session is not currently open")]
        INVALIDSESSION=4, 
        ///<summary> NoSessionsAvailable: All available sessions are already in use | </summary>
        [Description("NoSessionsAvailable: All available sessions are already in use")]
        NOSESSIONSAVAILABLE=5, 
        ///<summary> EOF: Offset past end of file for ListDirectory and ReadFile commands | </summary>
        [Description("EOF: Offset past end of file for ListDirectory and ReadFile commands")]
        EOF=6, 
        ///<summary> UnknownCommand: Unknown command / opcode | </summary>
        [Description("UnknownCommand: Unknown command / opcode")]
        UNKNOWNCOMMAND=7, 
        ///<summary> FileExists: File/directory already exists | </summary>
        [Description("FileExists: File/directory already exists")]
        FILEEXISTS=8, 
        ///<summary> FileProtected: File/directory is write protected | </summary>
        [Description("FileProtected: File/directory is write protected")]
        FILEPROTECTED=9, 
        ///<summary> FileNotFound: File/directory not found | </summary>
        [Description("FileNotFound: File/directory not found")]
        FILENOTFOUND=10, 
        
    };
    
    ///<summary> MAV FTP opcodes: https://mavlink.io/en/services/ftp.html </summary>
    public enum MAV_FTP_OPCODE: int /*default*/
    {
        ///<summary> None. Ignored, always ACKed | </summary>
        [Description("None. Ignored, always ACKed")]
        NONE=0, 
        ///<summary> TerminateSession: Terminates open Read session | </summary>
        [Description("TerminateSession: Terminates open Read session")]
        TERMINATESESSION=1, 
        ///<summary> ResetSessions: Terminates all open read sessions | </summary>
        [Description("ResetSessions: Terminates all open read sessions")]
        RESETSESSION=2, 
        ///<summary> ListDirectory. List files and directories in path from offset | </summary>
        [Description("ListDirectory. List files and directories in path from offset")]
        LISTDIRECTORY=3, 
        ///<summary> OpenFileRO: Opens file at path for reading, returns session | </summary>
        [Description("OpenFileRO: Opens file at path for reading, returns session")]
        OPENFILERO=4, 
        ///<summary> ReadFile: Reads size bytes from offset in session | </summary>
        [Description("ReadFile: Reads size bytes from offset in session")]
        READFILE=5, 
        ///<summary> CreateFile: Creates file at path for writing, returns session | </summary>
        [Description("CreateFile: Creates file at path for writing, returns session")]
        CREATEFILE=6, 
        ///<summary> WriteFile: Writes size bytes to offset in session | </summary>
        [Description("WriteFile: Writes size bytes to offset in session")]
        WRITEFILE=7, 
        ///<summary> RemoveFile: Remove file at path | </summary>
        [Description("RemoveFile: Remove file at path")]
        REMOVEFILE=8, 
        ///<summary> CreateDirectory: Creates directory at path | </summary>
        [Description("CreateDirectory: Creates directory at path")]
        CREATEDIRECTORY=9, 
        ///<summary> RemoveDirectory: Removes directory at path. The directory must be empty. | </summary>
        [Description("RemoveDirectory: Removes directory at path. The directory must be empty.")]
        REMOVEDIRECTORY=10, 
        ///<summary> OpenFileWO: Opens file at path for writing, returns session | </summary>
        [Description("OpenFileWO: Opens file at path for writing, returns session")]
        OPENFILEWO=11, 
        ///<summary> TruncateFile: Truncate file at path to offset length | </summary>
        [Description("TruncateFile: Truncate file at path to offset length")]
        TRUNCATEFILE=12, 
        ///<summary> Rename: Rename path1 to path2 | </summary>
        [Description("Rename: Rename path1 to path2")]
        RENAME=13, 
        ///<summary> CalcFileCRC32: Calculate CRC32 for file at path | </summary>
        [Description("CalcFileCRC32: Calculate CRC32 for file at path")]
        CALCFILECRC=14, 
        ///<summary> BurstReadFile: Burst download session file | </summary>
        [Description("BurstReadFile: Burst download session file")]
        BURSTREADFILE=15, 
        ///<summary> ACK: ACK response | </summary>
        [Description("ACK: ACK response")]
        ACK=128, 
        ///<summary> NAK: NAK response | </summary>
        [Description("NAK: NAK response")]
        NAK=129, 
        
    };
    
    ///<summary>          States of the mission state machine.         Note that these states are independent of whether the mission is in a mode that can execute mission items or not (is suspended).         They may not all be relevant on all vehicles.        </summary>
    public enum MISSION_STATE: int /*default*/
    {
        ///<summary> The mission status reporting is not supported. | </summary>
        [Description("The mission status reporting is not supported.")]
        UNKNOWN=0, 
        ///<summary> No mission on the vehicle. | </summary>
        [Description("No mission on the vehicle.")]
        NO_MISSION=1, 
        ///<summary> Mission has not started. This is the case after a mission has uploaded but not yet started executing. | </summary>
        [Description("Mission has not started. This is the case after a mission has uploaded but not yet started executing.")]
        NOT_STARTED=2, 
        ///<summary> Mission is active, and will execute mission items when in auto mode. | </summary>
        [Description("Mission is active, and will execute mission items when in auto mode.")]
        ACTIVE=3, 
        ///<summary> Mission is paused when in auto mode. | </summary>
        [Description("Mission is paused when in auto mode.")]
        PAUSED=4, 
        ///<summary> Mission has executed all mission items. | </summary>
        [Description("Mission has executed all mission items.")]
        COMPLETE=5, 
        
    };
    
    
    
    ///<summary> Micro air vehicle / autopilot classes. This identifies the individual model. </summary>
    public enum MAV_AUTOPILOT: byte
    {
        ///<summary> Generic autopilot, full support for everything | </summary>
        [Description("Generic autopilot, full support for everything")]
        GENERIC=0, 
        ///<summary> Reserved for future use. | </summary>
        [Description("Reserved for future use.")]
        RESERVED=1, 
        ///<summary> SLUGS autopilot, http://slugsuav.soe.ucsc.edu | </summary>
        [Description("SLUGS autopilot, http://slugsuav.soe.ucsc.edu")]
        SLUGS=2, 
        ///<summary> ArduPilot - Plane/Copter/Rover/Sub/Tracker, https://ardupilot.org | </summary>
        [Description("ArduPilot - Plane/Copter/Rover/Sub/Tracker, https://ardupilot.org")]
        ARDUPILOTMEGA=3, 
        ///<summary> OpenPilot, http://openpilot.org | </summary>
        [Description("OpenPilot, http://openpilot.org")]
        OPENPILOT=4, 
        ///<summary> Generic autopilot only supporting simple waypoints | </summary>
        [Description("Generic autopilot only supporting simple waypoints")]
        GENERIC_WAYPOINTS_ONLY=5, 
        ///<summary> Generic autopilot supporting waypoints and other simple navigation commands | </summary>
        [Description("Generic autopilot supporting waypoints and other simple navigation commands")]
        GENERIC_WAYPOINTS_AND_SIMPLE_NAVIGATION_ONLY=6, 
        ///<summary> Generic autopilot supporting the full mission command set | </summary>
        [Description("Generic autopilot supporting the full mission command set")]
        GENERIC_MISSION_FULL=7, 
        ///<summary> No valid autopilot, e.g. a GCS or other MAVLink component | </summary>
        [Description("No valid autopilot, e.g. a GCS or other MAVLink component")]
        INVALID=8, 
        ///<summary> PPZ UAV - http://nongnu.org/paparazzi | </summary>
        [Description("PPZ UAV - http://nongnu.org/paparazzi")]
        PPZ=9, 
        ///<summary> UAV Dev Board | </summary>
        [Description("UAV Dev Board")]
        UDB=10, 
        ///<summary> FlexiPilot | </summary>
        [Description("FlexiPilot")]
        FP=11, 
        ///<summary> PX4 Autopilot - http://px4.io/ | </summary>
        [Description("PX4 Autopilot - http://px4.io/")]
        PX4=12, 
        ///<summary> SMACCMPilot - http://smaccmpilot.org | </summary>
        [Description("SMACCMPilot - http://smaccmpilot.org")]
        SMACCMPILOT=13, 
        ///<summary> AutoQuad -- http://autoquad.org | </summary>
        [Description("AutoQuad -- http://autoquad.org")]
        AUTOQUAD=14, 
        ///<summary> Armazila -- http://armazila.com | </summary>
        [Description("Armazila -- http://armazila.com")]
        ARMAZILA=15, 
        ///<summary> Aerob -- http://aerob.ru | </summary>
        [Description("Aerob -- http://aerob.ru")]
        AEROB=16, 
        ///<summary> ASLUAV autopilot -- http://www.asl.ethz.ch | </summary>
        [Description("ASLUAV autopilot -- http://www.asl.ethz.ch")]
        ASLUAV=17, 
        ///<summary> SmartAP Autopilot - http://sky-drones.com | </summary>
        [Description("SmartAP Autopilot - http://sky-drones.com")]
        SMARTAP=18, 
        ///<summary> AirRails - http://uaventure.com | </summary>
        [Description("AirRails - http://uaventure.com")]
        AIRRAILS=19, 
        ///<summary> Fusion Reflex - https://fusion.engineering | </summary>
        [Description("Fusion Reflex - https://fusion.engineering")]
        REFLEX=20, 
        
    };
    
    ///<summary> MAVLINK component type reported in HEARTBEAT message. Flight controllers must report the type of the vehicle on which they are mounted (e.g. MAV_TYPE_OCTOROTOR). All other components must report a value appropriate for their type (e.g. a camera must use MAV_TYPE_CAMERA). </summary>
    public enum MAV_TYPE: byte
    {
        ///<summary> Generic micro air vehicle | </summary>
        [Description("Generic micro air vehicle")]
        GENERIC=0, 
        ///<summary> Fixed wing aircraft. | </summary>
        [Description("Fixed wing aircraft.")]
        FIXED_WING=1, 
        ///<summary> Quadrotor | </summary>
        [Description("Quadrotor")]
        QUADROTOR=2, 
        ///<summary> Coaxial helicopter | </summary>
        [Description("Coaxial helicopter")]
        COAXIAL=3, 
        ///<summary> Normal helicopter with tail rotor. | </summary>
        [Description("Normal helicopter with tail rotor.")]
        HELICOPTER=4, 
        ///<summary> Ground installation | </summary>
        [Description("Ground installation")]
        ANTENNA_TRACKER=5, 
        ///<summary> Operator control unit / ground control station | </summary>
        [Description("Operator control unit / ground control station")]
        GCS=6, 
        ///<summary> Airship, controlled | </summary>
        [Description("Airship, controlled")]
        AIRSHIP=7, 
        ///<summary> Free balloon, uncontrolled | </summary>
        [Description("Free balloon, uncontrolled")]
        FREE_BALLOON=8, 
        ///<summary> Rocket | </summary>
        [Description("Rocket")]
        ROCKET=9, 
        ///<summary> Ground rover | </summary>
        [Description("Ground rover")]
        GROUND_ROVER=10, 
        ///<summary> Surface vessel, boat, ship | </summary>
        [Description("Surface vessel, boat, ship")]
        SURFACE_BOAT=11, 
        ///<summary> Submarine | </summary>
        [Description("Submarine")]
        SUBMARINE=12, 
        ///<summary> Hexarotor | </summary>
        [Description("Hexarotor")]
        HEXAROTOR=13, 
        ///<summary> Octorotor | </summary>
        [Description("Octorotor")]
        OCTOROTOR=14, 
        ///<summary> Tricopter | </summary>
        [Description("Tricopter")]
        TRICOPTER=15, 
        ///<summary> Flapping wing | </summary>
        [Description("Flapping wing")]
        FLAPPING_WING=16, 
        ///<summary> Kite | </summary>
        [Description("Kite")]
        KITE=17, 
        ///<summary> Onboard companion controller | </summary>
        [Description("Onboard companion controller")]
        ONBOARD_CONTROLLER=18, 
        ///<summary> Two-rotor Tailsitter VTOL that additionally uses control surfaces in vertical operation. Note, value previously named MAV_TYPE_VTOL_DUOROTOR. | </summary>
        [Description("Two-rotor Tailsitter VTOL that additionally uses control surfaces in vertical operation. Note, value previously named MAV_TYPE_VTOL_DUOROTOR.")]
        VTOL_TAILSITTER_DUOROTOR=19, 
        ///<summary> Quad-rotor Tailsitter VTOL using a V-shaped quad config in vertical operation. Note: value previously named MAV_TYPE_VTOL_QUADROTOR. | </summary>
        [Description("Quad-rotor Tailsitter VTOL using a V-shaped quad config in vertical operation. Note: value previously named MAV_TYPE_VTOL_QUADROTOR.")]
        VTOL_TAILSITTER_QUADROTOR=20, 
        ///<summary> Tiltrotor VTOL. Fuselage and wings stay (nominally) horizontal in all flight phases. It able to tilt (some) rotors to provide thrust in cruise flight. | </summary>
        [Description("Tiltrotor VTOL. Fuselage and wings stay (nominally) horizontal in all flight phases. It able to tilt (some) rotors to provide thrust in cruise flight.")]
        VTOL_TILTROTOR=21, 
        ///<summary> VTOL with separate fixed rotors for hover and cruise flight. Fuselage and wings stay (nominally) horizontal in all flight phases. | </summary>
        [Description("VTOL with separate fixed rotors for hover and cruise flight. Fuselage and wings stay (nominally) horizontal in all flight phases.")]
        VTOL_FIXEDROTOR=22, 
        ///<summary> Tailsitter VTOL. Fuselage and wings orientation changes depending on flight phase: vertical for hover, horizontal for cruise. Use more specific VTOL MAV_TYPE_VTOL_DUOROTOR or MAV_TYPE_VTOL_QUADROTOR if appropriate. | </summary>
        [Description("Tailsitter VTOL. Fuselage and wings orientation changes depending on flight phase: vertical for hover, horizontal for cruise. Use more specific VTOL MAV_TYPE_VTOL_DUOROTOR or MAV_TYPE_VTOL_QUADROTOR if appropriate.")]
        VTOL_TAILSITTER=23, 
        ///<summary> Tiltwing VTOL. Fuselage stays horizontal in all flight phases. The whole wing, along with any attached engine, can tilt between vertical and horizontal mode. | </summary>
        [Description("Tiltwing VTOL. Fuselage stays horizontal in all flight phases. The whole wing, along with any attached engine, can tilt between vertical and horizontal mode.")]
        VTOL_TILTWING=24, 
        ///<summary> VTOL reserved 5 | </summary>
        [Description("VTOL reserved 5")]
        VTOL_RESERVED5=25, 
        ///<summary> Gimbal | </summary>
        [Description("Gimbal")]
        GIMBAL=26, 
        ///<summary> ADSB system | </summary>
        [Description("ADSB system")]
        ADSB=27, 
        ///<summary> Steerable, nonrigid airfoil | </summary>
        [Description("Steerable, nonrigid airfoil")]
        PARAFOIL=28, 
        ///<summary> Dodecarotor | </summary>
        [Description("Dodecarotor")]
        DODECAROTOR=29, 
        ///<summary> Camera | </summary>
        [Description("Camera")]
        CAMERA=30, 
        ///<summary> Charging station | </summary>
        [Description("Charging station")]
        CHARGING_STATION=31, 
        ///<summary> FLARM collision avoidance system | </summary>
        [Description("FLARM collision avoidance system")]
        FLARM=32, 
        ///<summary> Servo | </summary>
        [Description("Servo")]
        SERVO=33, 
        ///<summary> Open Drone ID. See https://mavlink.io/en/services/opendroneid.html. | </summary>
        [Description("Open Drone ID. See https://mavlink.io/en/services/opendroneid.html.")]
        ODID=34, 
        ///<summary> Decarotor | </summary>
        [Description("Decarotor")]
        DECAROTOR=35, 
        ///<summary> Battery | </summary>
        [Description("Battery")]
        BATTERY=36, 
        ///<summary> Parachute | </summary>
        [Description("Parachute")]
        PARACHUTE=37, 
        ///<summary> Log | </summary>
        [Description("Log")]
        LOG=38, 
        ///<summary> OSD | </summary>
        [Description("OSD")]
        OSD=39, 
        ///<summary> IMU | </summary>
        [Description("IMU")]
        IMU=40, 
        ///<summary> GPS | </summary>
        [Description("GPS")]
        GPS=41, 
        ///<summary> Winch | </summary>
        [Description("Winch")]
        WINCH=42, 
        
    };
    
    ///<summary> These flags encode the MAV mode. </summary>
    public enum MAV_MODE_FLAG: byte
    {
        ///<summary> 0b00000001 Reserved for future use. | </summary>
        [Description("0b00000001 Reserved for future use.")]
        CUSTOM_MODE_ENABLED=1, 
        ///<summary> 0b00000010 system has a test mode enabled. This flag is intended for temporary system tests and should not be used for stable implementations. | </summary>
        [Description("0b00000010 system has a test mode enabled. This flag is intended for temporary system tests and should not be used for stable implementations.")]
        TEST_ENABLED=2, 
        ///<summary> 0b00000100 autonomous mode enabled, system finds its own goal positions. Guided flag can be set or not, depends on the actual implementation. | </summary>
        [Description("0b00000100 autonomous mode enabled, system finds its own goal positions. Guided flag can be set or not, depends on the actual implementation.")]
        AUTO_ENABLED=4, 
        ///<summary> 0b00001000 guided mode enabled, system flies waypoints / mission items. | </summary>
        [Description("0b00001000 guided mode enabled, system flies waypoints / mission items.")]
        GUIDED_ENABLED=8, 
        ///<summary> 0b00010000 system stabilizes electronically its attitude (and optionally position). It needs however further control inputs to move around. | </summary>
        [Description("0b00010000 system stabilizes electronically its attitude (and optionally position). It needs however further control inputs to move around.")]
        STABILIZE_ENABLED=16, 
        ///<summary> 0b00100000 hardware in the loop simulation. All motors / actuators are blocked, but internal software is full operational. | </summary>
        [Description("0b00100000 hardware in the loop simulation. All motors / actuators are blocked, but internal software is full operational.")]
        HIL_ENABLED=32, 
        ///<summary> 0b01000000 remote control input is enabled. | </summary>
        [Description("0b01000000 remote control input is enabled.")]
        MANUAL_INPUT_ENABLED=64, 
        ///<summary> 0b10000000 MAV safety set to armed. Motors are enabled / running / can start. Ready to fly. Additional note: this flag is to be ignore when sent in the command MAV_CMD_DO_SET_MODE and MAV_CMD_COMPONENT_ARM_DISARM shall be used instead. The flag can still be used to report the armed state. | </summary>
        [Description("0b10000000 MAV safety set to armed. Motors are enabled / running / can start. Ready to fly. Additional note: this flag is to be ignore when sent in the command MAV_CMD_DO_SET_MODE and MAV_CMD_COMPONENT_ARM_DISARM shall be used instead. The flag can still be used to report the armed state.")]
        SAFETY_ARMED=128, 
        
    };
    
    ///<summary> These values encode the bit positions of the decode position. These values can be used to read the value of a flag bit by combining the base_mode variable with AND with the flag position value. The result will be either 0 or 1, depending on if the flag is set or not. </summary>
    public enum MAV_MODE_FLAG_DECODE_POSITION: int /*default*/
    {
        ///<summary> Eighth bit: 00000001 | </summary>
        [Description("Eighth bit: 00000001")]
        CUSTOM_MODE=1, 
        ///<summary> Seventh bit: 00000010 | </summary>
        [Description("Seventh bit: 00000010")]
        TEST=2, 
        ///<summary> Sixth bit:   00000100 | </summary>
        [Description("Sixth bit:   00000100")]
        AUTO=4, 
        ///<summary> Fifth bit:  00001000 | </summary>
        [Description("Fifth bit:  00001000")]
        GUIDED=8, 
        ///<summary> Fourth bit: 00010000 | </summary>
        [Description("Fourth bit: 00010000")]
        STABILIZE=16, 
        ///<summary> Third bit:  00100000 | </summary>
        [Description("Third bit:  00100000")]
        HIL=32, 
        ///<summary> Second bit: 01000000 | </summary>
        [Description("Second bit: 01000000")]
        MANUAL=64, 
        ///<summary> First bit:  10000000 | </summary>
        [Description("First bit:  10000000")]
        SAFETY=128, 
        
    };
    
    ///<summary>  </summary>
    public enum MAV_STATE: byte
    {
        ///<summary> Uninitialized system, state is unknown. | </summary>
        [Description("Uninitialized system, state is unknown.")]
        UNINIT=0, 
        ///<summary> System is booting up. | </summary>
        [Description("System is booting up.")]
        BOOT=1, 
        ///<summary> System is calibrating and not flight-ready. | </summary>
        [Description("System is calibrating and not flight-ready.")]
        CALIBRATING=2, 
        ///<summary> System is grounded and on standby. It can be launched any time. | </summary>
        [Description("System is grounded and on standby. It can be launched any time.")]
        STANDBY=3, 
        ///<summary> System is active and might be already airborne. Motors are engaged. | </summary>
        [Description("System is active and might be already airborne. Motors are engaged.")]
        ACTIVE=4, 
        ///<summary> System is in a non-normal flight mode. It can however still navigate. | </summary>
        [Description("System is in a non-normal flight mode. It can however still navigate.")]
        CRITICAL=5, 
        ///<summary> System is in a non-normal flight mode. It lost control over parts or over the whole airframe. It is in mayday and going down. | </summary>
        [Description("System is in a non-normal flight mode. It lost control over parts or over the whole airframe. It is in mayday and going down.")]
        EMERGENCY=6, 
        ///<summary> System just initialized its power-down sequence, will shut down now. | </summary>
        [Description("System just initialized its power-down sequence, will shut down now.")]
        POWEROFF=7, 
        ///<summary> System is terminating itself. | </summary>
        [Description("System is terminating itself.")]
        FLIGHT_TERMINATION=8, 
        
    };
    
    ///<summary> Component ids (values) for the different types and instances of onboard hardware/software that might make up a MAVLink system (autopilot, cameras, servos, GPS systems, avoidance systems etc.).       Components must use the appropriate ID in their source address when sending messages. Components can also use IDs to determine if they are the intended recipient of an incoming message. The MAV_COMP_ID_ALL value is used to indicate messages that must be processed by all components.       When creating new entries, components that can have multiple instances (e.g. cameras, servos etc.) should be allocated sequential values. An appropriate number of values should be left free after these components to allow the number of instances to be expanded. </summary>
    public enum MAV_COMPONENT: int /*default*/
    {
        ///<summary> Target id (target_component) used to broadcast messages to all components of the receiving system. Components should attempt to process messages with this component ID and forward to components on any other interfaces. Note: This is not a valid *source* component id for a message. | </summary>
        [Description("Target id (target_component) used to broadcast messages to all components of the receiving system. Components should attempt to process messages with this component ID and forward to components on any other interfaces. Note: This is not a valid *source* component id for a message.")]
        MAV_COMP_ID_ALL=0, 
        ///<summary> System flight controller component ('autopilot'). Only one autopilot is expected in a particular system. | </summary>
        [Description("System flight controller component ('autopilot'). Only one autopilot is expected in a particular system.")]
        MAV_COMP_ID_AUTOPILOT1=1, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER1=25, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER2=26, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER3=27, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER4=28, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER5=29, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER6=30, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER7=31, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER8=32, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER9=33, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER10=34, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER11=35, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER12=36, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER13=37, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER14=38, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER15=39, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER16=40, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER17=41, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER18=42, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER19=43, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER20=44, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER21=45, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER22=46, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER23=47, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER24=48, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER25=49, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER26=50, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER27=51, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER28=52, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER29=53, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER30=54, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER31=55, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER32=56, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER33=57, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER34=58, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER35=59, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER36=60, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER37=61, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER38=62, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER39=63, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER40=64, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER41=65, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER42=66, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER43=67, 
        ///<summary> Telemetry radio (e.g. SiK radio, or other component that emits RADIO_STATUS messages). | </summary>
        [Description("Telemetry radio (e.g. SiK radio, or other component that emits RADIO_STATUS messages).")]
        MAV_COMP_ID_TELEMETRY_RADIO=68, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER45=69, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER46=70, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER47=71, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER48=72, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER49=73, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER50=74, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER51=75, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER52=76, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER53=77, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER54=78, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER55=79, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER56=80, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER57=81, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER58=82, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER59=83, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER60=84, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER61=85, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER62=86, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER63=87, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER64=88, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER65=89, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER66=90, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER67=91, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER68=92, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER69=93, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER70=94, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER71=95, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER72=96, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER73=97, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER74=98, 
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER75=99, 
        ///<summary> Camera #1. | </summary>
        [Description("Camera #1.")]
        MAV_COMP_ID_CAMERA=100, 
        ///<summary> Camera #2. | </summary>
        [Description("Camera #2.")]
        MAV_COMP_ID_CAMERA2=101, 
        ///<summary> Camera #3. | </summary>
        [Description("Camera #3.")]
        MAV_COMP_ID_CAMERA3=102, 
        ///<summary> Camera #4. | </summary>
        [Description("Camera #4.")]
        MAV_COMP_ID_CAMERA4=103, 
        ///<summary> Camera #5. | </summary>
        [Description("Camera #5.")]
        MAV_COMP_ID_CAMERA5=104, 
        ///<summary> Camera #6. | </summary>
        [Description("Camera #6.")]
        MAV_COMP_ID_CAMERA6=105, 
        ///<summary> Servo #1. | </summary>
        [Description("Servo #1.")]
        MAV_COMP_ID_SERVO1=140, 
        ///<summary> Servo #2. | </summary>
        [Description("Servo #2.")]
        MAV_COMP_ID_SERVO2=141, 
        ///<summary> Servo #3. | </summary>
        [Description("Servo #3.")]
        MAV_COMP_ID_SERVO3=142, 
        ///<summary> Servo #4. | </summary>
        [Description("Servo #4.")]
        MAV_COMP_ID_SERVO4=143, 
        ///<summary> Servo #5. | </summary>
        [Description("Servo #5.")]
        MAV_COMP_ID_SERVO5=144, 
        ///<summary> Servo #6. | </summary>
        [Description("Servo #6.")]
        MAV_COMP_ID_SERVO6=145, 
        ///<summary> Servo #7. | </summary>
        [Description("Servo #7.")]
        MAV_COMP_ID_SERVO7=146, 
        ///<summary> Servo #8. | </summary>
        [Description("Servo #8.")]
        MAV_COMP_ID_SERVO8=147, 
        ///<summary> Servo #9. | </summary>
        [Description("Servo #9.")]
        MAV_COMP_ID_SERVO9=148, 
        ///<summary> Servo #10. | </summary>
        [Description("Servo #10.")]
        MAV_COMP_ID_SERVO10=149, 
        ///<summary> Servo #11. | </summary>
        [Description("Servo #11.")]
        MAV_COMP_ID_SERVO11=150, 
        ///<summary> Servo #12. | </summary>
        [Description("Servo #12.")]
        MAV_COMP_ID_SERVO12=151, 
        ///<summary> Servo #13. | </summary>
        [Description("Servo #13.")]
        MAV_COMP_ID_SERVO13=152, 
        ///<summary> Servo #14. | </summary>
        [Description("Servo #14.")]
        MAV_COMP_ID_SERVO14=153, 
        ///<summary> Gimbal #1. | </summary>
        [Description("Gimbal #1.")]
        MAV_COMP_ID_GIMBAL=154, 
        ///<summary> Logging component. | </summary>
        [Description("Logging component.")]
        MAV_COMP_ID_LOG=155, 
        ///<summary> Automatic Dependent Surveillance-Broadcast (ADS-B) component. | </summary>
        [Description("Automatic Dependent Surveillance-Broadcast (ADS-B) component.")]
        MAV_COMP_ID_ADSB=156, 
        ///<summary> On Screen Display (OSD) devices for video links. | </summary>
        [Description("On Screen Display (OSD) devices for video links.")]
        MAV_COMP_ID_OSD=157, 
        ///<summary> Generic autopilot peripheral component ID. Meant for devices that do not implement the parameter microservice. | </summary>
        [Description("Generic autopilot peripheral component ID. Meant for devices that do not implement the parameter microservice.")]
        MAV_COMP_ID_PERIPHERAL=158, 
        ///<summary> Gimbal ID for QX1. | </summary>
        [Description("Gimbal ID for QX1.")]
        MAV_COMP_ID_QX1_GIMBAL=159, 
        ///<summary> FLARM collision alert component. | </summary>
        [Description("FLARM collision alert component.")]
        MAV_COMP_ID_FLARM=160, 
        ///<summary> Parachute component. | </summary>
        [Description("Parachute component.")]
        MAV_COMP_ID_PARACHUTE=161, 
        ///<summary> Winch component. | </summary>
        [Description("Winch component.")]
        MAV_COMP_ID_WINCH=169, 
        ///<summary> Gimbal #2. | </summary>
        [Description("Gimbal #2.")]
        MAV_COMP_ID_GIMBAL2=171, 
        ///<summary> Gimbal #3. | </summary>
        [Description("Gimbal #3.")]
        MAV_COMP_ID_GIMBAL3=172, 
        ///<summary> Gimbal #4 | </summary>
        [Description("Gimbal #4")]
        MAV_COMP_ID_GIMBAL4=173, 
        ///<summary> Gimbal #5. | </summary>
        [Description("Gimbal #5.")]
        MAV_COMP_ID_GIMBAL5=174, 
        ///<summary> Gimbal #6. | </summary>
        [Description("Gimbal #6.")]
        MAV_COMP_ID_GIMBAL6=175, 
        ///<summary> Battery #1. | </summary>
        [Description("Battery #1.")]
        MAV_COMP_ID_BATTERY=180, 
        ///<summary> Battery #2. | </summary>
        [Description("Battery #2.")]
        MAV_COMP_ID_BATTERY2=181, 
        ///<summary> CAN over MAVLink client. | </summary>
        [Description("CAN over MAVLink client.")]
        MAV_COMP_ID_MAVCAN=189, 
        ///<summary> Component that can generate/supply a mission flight plan (e.g. GCS or developer API). | </summary>
        [Description("Component that can generate/supply a mission flight plan (e.g. GCS or developer API).")]
        MAV_COMP_ID_MISSIONPLANNER=190, 
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER=191, 
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER2=192, 
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER3=193, 
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER4=194, 
        ///<summary> Component that finds an optimal path between points based on a certain constraint (e.g. minimum snap, shortest path, cost, etc.). | </summary>
        [Description("Component that finds an optimal path between points based on a certain constraint (e.g. minimum snap, shortest path, cost, etc.).")]
        MAV_COMP_ID_PATHPLANNER=195, 
        ///<summary> Component that plans a collision free path between two points. | </summary>
        [Description("Component that plans a collision free path between two points.")]
        MAV_COMP_ID_OBSTACLE_AVOIDANCE=196, 
        ///<summary> Component that provides position estimates using VIO techniques. | </summary>
        [Description("Component that provides position estimates using VIO techniques.")]
        MAV_COMP_ID_VISUAL_INERTIAL_ODOMETRY=197, 
        ///<summary> Component that manages pairing of vehicle and GCS. | </summary>
        [Description("Component that manages pairing of vehicle and GCS.")]
        MAV_COMP_ID_PAIRING_MANAGER=198, 
        ///<summary> Inertial Measurement Unit (IMU) #1. | </summary>
        [Description("Inertial Measurement Unit (IMU) #1.")]
        MAV_COMP_ID_IMU=200, 
        ///<summary> Inertial Measurement Unit (IMU) #2. | </summary>
        [Description("Inertial Measurement Unit (IMU) #2.")]
        MAV_COMP_ID_IMU_2=201, 
        ///<summary> Inertial Measurement Unit (IMU) #3. | </summary>
        [Description("Inertial Measurement Unit (IMU) #3.")]
        MAV_COMP_ID_IMU_3=202, 
        ///<summary> GPS #1. | </summary>
        [Description("GPS #1.")]
        MAV_COMP_ID_GPS=220, 
        ///<summary> GPS #2. | </summary>
        [Description("GPS #2.")]
        MAV_COMP_ID_GPS2=221, 
        ///<summary> Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet). | </summary>
        [Description("Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet).")]
        MAV_COMP_ID_ODID_TXRX_1=236, 
        ///<summary> Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet). | </summary>
        [Description("Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet).")]
        MAV_COMP_ID_ODID_TXRX_2=237, 
        ///<summary> Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet). | </summary>
        [Description("Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet).")]
        MAV_COMP_ID_ODID_TXRX_3=238, 
        ///<summary> Component to bridge MAVLink to UDP (i.e. from a UART). | </summary>
        [Description("Component to bridge MAVLink to UDP (i.e. from a UART).")]
        MAV_COMP_ID_UDP_BRIDGE=240, 
        ///<summary> Component to bridge to UART (i.e. from UDP). | </summary>
        [Description("Component to bridge to UART (i.e. from UDP).")]
        MAV_COMP_ID_UART_BRIDGE=241, 
        ///<summary> Component handling TUNNEL messages (e.g. vendor specific GUI of a component). | </summary>
        [Description("Component handling TUNNEL messages (e.g. vendor specific GUI of a component).")]
        MAV_COMP_ID_TUNNEL_NODE=242, 
        ///<summary> Deprecated, don't use. Component for handling system messages (e.g. to ARM, takeoff, etc.). | </summary>
        [Description("Deprecated, don't use. Component for handling system messages (e.g. to ARM, takeoff, etc.).")]
        MAV_COMP_ID_SYSTEM_CONTROL=250, 
        
    };
    
    
    /// extensions_start 13
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=31)]
    ///<summary> The general system state. If the system is following the MAVLink standard, the system state is mainly defined by three orthogonal states/modes: The system mode, which is either LOCKED (motors shut down and locked), MANUAL (system under RC control), GUIDED (system with autonomous position control, position setpoint controlled manually) or AUTO (system guided by path/waypoint planner). The NAV_MODE defined the current flight state: LIFTOFF (often an open-loop maneuver), LANDING, WAYPOINTS or VECTOR. This represents the internal navigation state machine. The system status shows whether the system is currently active or not and if an emergency occurred. During the CRITICAL and EMERGENCY states the MAV is still considered to be active, but should start emergency procedures autonomously. After a failure occurred it should first move from active to critical to allow manual intervention and then move to emergency after a certain timeout. </summary>
    public struct mavlink_sys_status_t
    {
        public mavlink_sys_status_t(/*MAV_SYS_STATUS_SENSOR*/uint onboard_control_sensors_present,/*MAV_SYS_STATUS_SENSOR*/uint onboard_control_sensors_enabled,/*MAV_SYS_STATUS_SENSOR*/uint onboard_control_sensors_health,ushort load,ushort voltage_battery,short current_battery,ushort drop_rate_comm,ushort errors_comm,ushort errors_count1,ushort errors_count2,ushort errors_count3,ushort errors_count4,sbyte battery_remaining) 
        {
              this.onboard_control_sensors_present = onboard_control_sensors_present;
              this.onboard_control_sensors_enabled = onboard_control_sensors_enabled;
              this.onboard_control_sensors_health = onboard_control_sensors_health;
              this.load = load;
              this.voltage_battery = voltage_battery;
              this.current_battery = current_battery;
              this.drop_rate_comm = drop_rate_comm;
              this.errors_comm = errors_comm;
              this.errors_count1 = errors_count1;
              this.errors_count2 = errors_count2;
              this.errors_count3 = errors_count3;
              this.errors_count4 = errors_count4;
              this.battery_remaining = battery_remaining;
            
        }
        /// <summary>Bitmap showing which onboard controllers and sensors are present. Value of 0: not present. Value of 1: present. MAV_SYS_STATUS_SENSOR  bitmask</summary>
        [Units("")]
        [Description("Bitmap showing which onboard controllers and sensors are present. Value of 0: not present. Value of 1: present.")]
        public  /*MAV_SYS_STATUS_SENSOR*/uint onboard_control_sensors_present;
            /// <summary>Bitmap showing which onboard controllers and sensors are enabled:  Value of 0: not enabled. Value of 1: enabled. MAV_SYS_STATUS_SENSOR  bitmask</summary>
        [Units("")]
        [Description("Bitmap showing which onboard controllers and sensors are enabled:  Value of 0: not enabled. Value of 1: enabled.")]
        public  /*MAV_SYS_STATUS_SENSOR*/uint onboard_control_sensors_enabled;
            /// <summary>Bitmap showing which onboard controllers and sensors have an error (or are operational). Value of 0: error. Value of 1: healthy. MAV_SYS_STATUS_SENSOR  bitmask</summary>
        [Units("")]
        [Description("Bitmap showing which onboard controllers and sensors have an error (or are operational). Value of 0: error. Value of 1: healthy.")]
        public  /*MAV_SYS_STATUS_SENSOR*/uint onboard_control_sensors_health;
            /// <summary>Maximum usage in percent of the mainloop time. Values: [0-1000] - should always be below 1000  [d%] </summary>
        [Units("[d%]")]
        [Description("Maximum usage in percent of the mainloop time. Values: [0-1000] - should always be below 1000")]
        public  ushort load;
            /// <summary>Battery voltage, UINT16_MAX: Voltage not sent by autopilot  [mV] </summary>
        [Units("[mV]")]
        [Description("Battery voltage, UINT16_MAX: Voltage not sent by autopilot")]
        public  ushort voltage_battery;
            /// <summary>Battery current, -1: Current not sent by autopilot  [cA] </summary>
        [Units("[cA]")]
        [Description("Battery current, -1: Current not sent by autopilot")]
        public  short current_battery;
            /// <summary>Communication drop rate, (UART, I2C, SPI, CAN), dropped packets on all links (packets that were corrupted on reception on the MAV)  [c%] </summary>
        [Units("[c%]")]
        [Description("Communication drop rate, (UART, I2C, SPI, CAN), dropped packets on all links (packets that were corrupted on reception on the MAV)")]
        public  ushort drop_rate_comm;
            /// <summary>Communication errors (UART, I2C, SPI, CAN), dropped packets on all links (packets that were corrupted on reception on the MAV)   </summary>
        [Units("")]
        [Description("Communication errors (UART, I2C, SPI, CAN), dropped packets on all links (packets that were corrupted on reception on the MAV)")]
        public  ushort errors_comm;
            /// <summary>Autopilot-specific errors   </summary>
        [Units("")]
        [Description("Autopilot-specific errors")]
        public  ushort errors_count1;
            /// <summary>Autopilot-specific errors   </summary>
        [Units("")]
        [Description("Autopilot-specific errors")]
        public  ushort errors_count2;
            /// <summary>Autopilot-specific errors   </summary>
        [Units("")]
        [Description("Autopilot-specific errors")]
        public  ushort errors_count3;
            /// <summary>Autopilot-specific errors   </summary>
        [Units("")]
        [Description("Autopilot-specific errors")]
        public  ushort errors_count4;
            /// <summary>Battery energy remaining, -1: Battery remaining energy not sent by autopilot  [%] </summary>
        [Units("[%]")]
        [Description("Battery energy remaining, -1: Battery remaining energy not sent by autopilot")]
        public  sbyte battery_remaining;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=12)]
    ///<summary> The system time is the time of the master clock, typically the computer clock of the main onboard computer. </summary>
    public struct mavlink_system_time_t
    {
        public mavlink_system_time_t(ulong time_unix_usec,uint time_boot_ms) 
        {
              this.time_unix_usec = time_unix_usec;
              this.time_boot_ms = time_boot_ms;
            
        }
        /// <summary>Timestamp (UNIX epoch time).  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX epoch time).")]
        public  ulong time_unix_usec;
            /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    ///<summary> A ping message either requesting or responding to a ping. This allows to measure the system latencies, including serial port, radio modem and UDP connections. The ping microservice is documented at https://mavlink.io/en/services/ping.html </summary>
    public struct mavlink_ping_t
    {
        public mavlink_ping_t(ulong time_usec,uint seq,byte target_system,byte target_component) 
        {
              this.time_usec = time_usec;
              this.seq = seq;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>PING sequence   </summary>
        [Units("")]
        [Description("PING sequence")]
        public  uint seq;
            /// <summary>0: request ping from all receiving systems. If greater than 0: message is a ping response and number is the system id of the requesting system   </summary>
        [Units("")]
        [Description("0: request ping from all receiving systems. If greater than 0: message is a ping response and number is the system id of the requesting system")]
        public  byte target_system;
            /// <summary>0: request ping from all receiving components. If greater than 0: message is a ping response and number is the component id of the requesting component.   </summary>
        [Units("")]
        [Description("0: request ping from all receiving components. If greater than 0: message is a ping response and number is the component id of the requesting component.")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=28)]
    ///<summary> Request to control this MAV </summary>
    public struct mavlink_change_operator_control_t
    {
        public mavlink_change_operator_control_t(byte target_system,byte control_request,byte version,byte[] passkey) 
        {
              this.target_system = target_system;
              this.control_request = control_request;
              this.version = version;
              this.passkey = passkey;
            
        }
        /// <summary>System the GCS requests control for   </summary>
        [Units("")]
        [Description("System the GCS requests control for")]
        public  byte target_system;
            /// <summary>0: request control of this MAV, 1: Release control of this MAV   </summary>
        [Units("")]
        [Description("0: request control of this MAV, 1: Release control of this MAV")]
        public  byte control_request;
            /// <summary>0: key as plaintext, 1-255: future, different hashing/encryption variants. The GCS should in general use the safest mode possible initially and then gradually move down the encryption level if it gets a NACK message indicating an encryption mismatch.  [rad] </summary>
        [Units("[rad]")]
        [Description("0: key as plaintext, 1-255: future, different hashing/encryption variants. The GCS should in general use the safest mode possible initially and then gradually move down the encryption level if it gets a NACK message indicating an encryption mismatch.")]
        public  byte version;
            /// <summary>Password / Key, depending on version plaintext or encrypted. 25 or less characters, NULL terminated. The characters may involve A-Z, a-z, 0-9, and '!?,.-'   </summary>
        [Units("")]
        [Description("Password / Key, depending on version plaintext or encrypted. 25 or less characters, NULL terminated. The characters may involve A-Z, a-z, 0-9, and '!?,.-'")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=25)]
		public byte[] passkey;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=3)]
    ///<summary> Accept / deny control of this MAV </summary>
    public struct mavlink_change_operator_control_ack_t
    {
        public mavlink_change_operator_control_ack_t(byte gcs_system_id,byte control_request,byte ack) 
        {
              this.gcs_system_id = gcs_system_id;
              this.control_request = control_request;
              this.ack = ack;
            
        }
        /// <summary>ID of the GCS this message    </summary>
        [Units("")]
        [Description("ID of the GCS this message ")]
        public  byte gcs_system_id;
            /// <summary>0: request control of this MAV, 1: Release control of this MAV   </summary>
        [Units("")]
        [Description("0: request control of this MAV, 1: Release control of this MAV")]
        public  byte control_request;
            /// <summary>0: ACK, 1: NACK: Wrong passkey, 2: NACK: Unsupported passkey encryption method, 3: NACK: Already under control   </summary>
        [Units("")]
        [Description("0: ACK, 1: NACK: Wrong passkey, 2: NACK: Unsupported passkey encryption method, 3: NACK: Already under control")]
        public  byte ack;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> Emit an encrypted signature / key identifying this system. PLEASE NOTE: This protocol has been kept simple, so transmitting the key requires an encrypted channel for true safety. </summary>
    public struct mavlink_auth_key_t
    {
        public mavlink_auth_key_t(byte[] key) 
        {
              this.key = key;
            
        }
        /// <summary>key   </summary>
        [Units("")]
        [Description("key")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=32)]
		public byte[] key;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    ///<summary> Status generated in each node in the communication chain and injected into MAVLink stream. </summary>
    public struct mavlink_link_node_status_t
    {
        public mavlink_link_node_status_t(ulong timestamp,uint tx_rate,uint rx_rate,uint messages_sent,uint messages_received,uint messages_lost,ushort rx_parse_err,ushort tx_overflows,ushort rx_overflows,byte tx_buf,byte rx_buf) 
        {
              this.timestamp = timestamp;
              this.tx_rate = tx_rate;
              this.rx_rate = rx_rate;
              this.messages_sent = messages_sent;
              this.messages_received = messages_received;
              this.messages_lost = messages_lost;
              this.rx_parse_err = rx_parse_err;
              this.tx_overflows = tx_overflows;
              this.rx_overflows = rx_overflows;
              this.tx_buf = tx_buf;
              this.rx_buf = rx_buf;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  ulong timestamp;
            /// <summary>Transmit rate  [bytes/s] </summary>
        [Units("[bytes/s]")]
        [Description("Transmit rate")]
        public  uint tx_rate;
            /// <summary>Receive rate  [bytes/s] </summary>
        [Units("[bytes/s]")]
        [Description("Receive rate")]
        public  uint rx_rate;
            /// <summary>Messages sent   </summary>
        [Units("")]
        [Description("Messages sent")]
        public  uint messages_sent;
            /// <summary>Messages received (estimated from counting seq)   </summary>
        [Units("")]
        [Description("Messages received (estimated from counting seq)")]
        public  uint messages_received;
            /// <summary>Messages lost (estimated from counting seq)   </summary>
        [Units("")]
        [Description("Messages lost (estimated from counting seq)")]
        public  uint messages_lost;
            /// <summary>Number of bytes that could not be parsed correctly.  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Number of bytes that could not be parsed correctly.")]
        public  ushort rx_parse_err;
            /// <summary>Transmit buffer overflows. This number wraps around as it reaches UINT16_MAX  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Transmit buffer overflows. This number wraps around as it reaches UINT16_MAX")]
        public  ushort tx_overflows;
            /// <summary>Receive buffer overflows. This number wraps around as it reaches UINT16_MAX  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Receive buffer overflows. This number wraps around as it reaches UINT16_MAX")]
        public  ushort rx_overflows;
            /// <summary>Remaining free transmit buffer space  [%] </summary>
        [Units("[%]")]
        [Description("Remaining free transmit buffer space")]
        public  byte tx_buf;
            /// <summary>Remaining free receive buffer space  [%] </summary>
        [Units("[%]")]
        [Description("Remaining free receive buffer space")]
        public  byte rx_buf;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary> Set the system mode, as defined by enum MAV_MODE. There is no target component id as the mode is by definition for the overall aircraft, not only for one component. </summary>
    public struct mavlink_set_mode_t
    {
        public mavlink_set_mode_t(uint custom_mode,byte target_system,/*MAV_MODE*/byte base_mode) 
        {
              this.custom_mode = custom_mode;
              this.target_system = target_system;
              this.base_mode = base_mode;
            
        }
        /// <summary>The new autopilot-specific mode. This field can be ignored by an autopilot.   </summary>
        [Units("")]
        [Description("The new autopilot-specific mode. This field can be ignored by an autopilot.")]
        public  uint custom_mode;
            /// <summary>The system setting the mode   </summary>
        [Units("")]
        [Description("The system setting the mode")]
        public  byte target_system;
            /// <summary>The new base mode. MAV_MODE  </summary>
        [Units("")]
        [Description("The new base mode.")]
        public  /*MAV_MODE*/byte base_mode;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=20)]
    ///<summary> Request to read the onboard parameter with the param_id string id. Onboard parameters are stored as key[const char*] -> value[float]. This allows to send a parameter to any other component (such as the GCS) without the need of previous knowledge of possible parameter names. Thus the same GCS can store different parameters for different autopilots. See also https://mavlink.io/en/services/parameter.html for a full documentation of QGroundControl and IMU code. </summary>
    public struct mavlink_param_request_read_t
    {
        public mavlink_param_request_read_t(short param_index,byte target_system,byte target_component,byte[] param_id) 
        {
              this.param_index = param_index;
              this.target_system = target_system;
              this.target_component = target_component;
              this.param_id = param_id;
            
        }
        /// <summary>Parameter index. Send -1 to use the param ID field as identifier (else the param id will be ignored)   </summary>
        [Units("")]
        [Description("Parameter index. Send -1 to use the param ID field as identifier (else the param id will be ignored)")]
        public  short param_index;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string   </summary>
        [Units("")]
        [Description("Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=16)]
		public byte[] param_id;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> Request all parameters of this component. After this request, all parameters are emitted. The parameter microservice is documented at https://mavlink.io/en/services/parameter.html </summary>
    public struct mavlink_param_request_list_t
    {
        public mavlink_param_request_list_t(byte target_system,byte target_component) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=25)]
    ///<summary> Emit the value of a onboard parameter. The inclusion of param_count and param_index in the message allows the recipient to keep track of received parameters and allows him to re-request missing parameters after a loss or timeout. The parameter microservice is documented at https://mavlink.io/en/services/parameter.html </summary>
    public struct mavlink_param_value_t
    {
        public mavlink_param_value_t(float param_value,ushort param_count,ushort param_index,byte[] param_id,/*MAV_PARAM_TYPE*/byte param_type) 
        {
              this.param_value = param_value;
              this.param_count = param_count;
              this.param_index = param_index;
              this.param_id = param_id;
              this.param_type = param_type;
            
        }
        /// <summary>Onboard parameter value   </summary>
        [Units("")]
        [Description("Onboard parameter value")]
        public  float param_value;
            /// <summary>Total number of onboard parameters   </summary>
        [Units("")]
        [Description("Total number of onboard parameters")]
        public  ushort param_count;
            /// <summary>Index of this onboard parameter   </summary>
        [Units("")]
        [Description("Index of this onboard parameter")]
        public  ushort param_index;
            /// <summary>Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string   </summary>
        [Units("")]
        [Description("Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=16)]
		public byte[] param_id;
            /// <summary>Onboard parameter type. MAV_PARAM_TYPE  </summary>
        [Units("")]
        [Description("Onboard parameter type.")]
        public  /*MAV_PARAM_TYPE*/byte param_type;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=23)]
    ///<summary> Set a parameter value (write new value to permanent storage).         The receiving component should acknowledge the new parameter value by broadcasting a PARAM_VALUE message (broadcasting ensures that multiple GCS all have an up-to-date list of all parameters). If the sending GCS did not receive a PARAM_VALUE within its timeout time, it should re-send the PARAM_SET message. The parameter microservice is documented at https://mavlink.io/en/services/parameter.html.         PARAM_SET may also be called within the context of a transaction (started with MAV_CMD_PARAM_TRANSACTION). Within a transaction the receiving component should respond with PARAM_ACK_TRANSACTION to the setter component (instead of broadcasting PARAM_VALUE), and PARAM_SET should be re-sent if this is ACK not received. </summary>
    public struct mavlink_param_set_t
    {
        public mavlink_param_set_t(float param_value,byte target_system,byte target_component,byte[] param_id,/*MAV_PARAM_TYPE*/byte param_type) 
        {
              this.param_value = param_value;
              this.target_system = target_system;
              this.target_component = target_component;
              this.param_id = param_id;
              this.param_type = param_type;
            
        }
        /// <summary>Onboard parameter value   </summary>
        [Units("")]
        [Description("Onboard parameter value")]
        public  float param_value;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string   </summary>
        [Units("")]
        [Description("Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=16)]
		public byte[] param_id;
            /// <summary>Onboard parameter type. MAV_PARAM_TYPE  </summary>
        [Units("")]
        [Description("Onboard parameter type.")]
        public  /*MAV_PARAM_TYPE*/byte param_type;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=30)]
    ///<summary> The global position, as returned by the Global Positioning System (GPS). This is                 NOT the global position estimate of the system, but rather a RAW sensor value. See message GLOBAL_POSITION_INT for the global position estimate. </summary>
    public struct mavlink_gps_raw_int_t
    {
        public mavlink_gps_raw_int_t(ulong time_usec,int lat,int lon,int alt,ushort eph,ushort epv,ushort vel,ushort cog,/*GPS_FIX_TYPE*/byte fix_type,byte satellites_visible) 
        {
              this.time_usec = time_usec;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.eph = eph;
              this.epv = epv;
              this.vel = vel;
              this.cog = cog;
              this.fix_type = fix_type;
              this.satellites_visible = satellites_visible;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Latitude (WGS84, EGM96 ellipsoid)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84, EGM96 ellipsoid)")]
        public  int lat;
            /// <summary>Longitude (WGS84, EGM96 ellipsoid)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84, EGM96 ellipsoid)")]
        public  int lon;
            /// <summary>Altitude (MSL). Positive for up. Note that virtually all GPS modules provide the MSL altitude in addition to the WGS84 altitude.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up. Note that virtually all GPS modules provide the MSL altitude in addition to the WGS84 altitude.")]
        public  int alt;
            /// <summary>GPS HDOP horizontal dilution of position (unitless * 100). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS HDOP horizontal dilution of position (unitless * 100). If unknown, set to: UINT16_MAX")]
        public  ushort eph;
            /// <summary>GPS VDOP vertical dilution of position (unitless * 100). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS VDOP vertical dilution of position (unitless * 100). If unknown, set to: UINT16_MAX")]
        public  ushort epv;
            /// <summary>GPS ground speed. If unknown, set to: UINT16_MAX  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("GPS ground speed. If unknown, set to: UINT16_MAX")]
        public  ushort vel;
            /// <summary>Course over ground (NOT heading, but direction of movement) in degrees * 100, 0.0..359.99 degrees. If unknown, set to: UINT16_MAX  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("Course over ground (NOT heading, but direction of movement) in degrees * 100, 0.0..359.99 degrees. If unknown, set to: UINT16_MAX")]
        public  ushort cog;
            /// <summary>GPS fix type. GPS_FIX_TYPE  </summary>
        [Units("")]
        [Description("GPS fix type.")]
        public  /*GPS_FIX_TYPE*/byte fix_type;
            /// <summary>Number of satellites visible. If unknown, set to UINT8_MAX   </summary>
        [Units("")]
        [Description("Number of satellites visible. If unknown, set to UINT8_MAX")]
        public  byte satellites_visible;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=101)]
    ///<summary> The positioning status, as reported by GPS. This message is intended to display status information about each satellite visible to the receiver. See message GLOBAL_POSITION_INT for the global position estimate. This message can contain information for up to 20 satellites. </summary>
    public struct mavlink_gps_status_t
    {
        public mavlink_gps_status_t(byte satellites_visible,byte[] satellite_prn,byte[] satellite_used,byte[] satellite_elevation,byte[] satellite_azimuth,byte[] satellite_snr) 
        {
              this.satellites_visible = satellites_visible;
              this.satellite_prn = satellite_prn;
              this.satellite_used = satellite_used;
              this.satellite_elevation = satellite_elevation;
              this.satellite_azimuth = satellite_azimuth;
              this.satellite_snr = satellite_snr;
            
        }
        /// <summary>Number of satellites visible   </summary>
        [Units("")]
        [Description("Number of satellites visible")]
        public  byte satellites_visible;
            /// <summary>Global satellite ID   </summary>
        [Units("")]
        [Description("Global satellite ID")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_prn;
            /// <summary>0: Satellite not used, 1: used for localization   </summary>
        [Units("")]
        [Description("0: Satellite not used, 1: used for localization")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_used;
            /// <summary>Elevation (0: right on top of receiver, 90: on the horizon) of satellite  [deg] </summary>
        [Units("[deg]")]
        [Description("Elevation (0: right on top of receiver, 90: on the horizon) of satellite")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_elevation;
            /// <summary>Direction of satellite, 0: 0 deg, 255: 360 deg.  [deg] </summary>
        [Units("[deg]")]
        [Description("Direction of satellite, 0: 0 deg, 255: 360 deg.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_azimuth;
            /// <summary>Signal to noise ratio of satellite  [dB] </summary>
        [Units("[dB]")]
        [Description("Signal to noise ratio of satellite")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_snr;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> The RAW IMU readings for the usual 9DOF sensor setup. This message should contain the scaled values to the described units </summary>
    public struct mavlink_scaled_imu_t
    {
        public mavlink_scaled_imu_t(uint time_boot_ms,short xacc,short yacc,short zacc,short xgyro,short ygyro,short zgyro,short xmag,short ymag,short zmag) 
        {
              this.time_boot_ms = time_boot_ms;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.xmag = xmag;
              this.ymag = ymag;
              this.zmag = zmag;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("X acceleration")]
        public  short xacc;
            /// <summary>Y acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Y acceleration")]
        public  short yacc;
            /// <summary>Z acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Z acceleration")]
        public  short zacc;
            /// <summary>Angular speed around X axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around X axis")]
        public  short xgyro;
            /// <summary>Angular speed around Y axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around Y axis")]
        public  short ygyro;
            /// <summary>Angular speed around Z axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around Z axis")]
        public  short zgyro;
            /// <summary>X Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("X Magnetic field")]
        public  short xmag;
            /// <summary>Y Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("Y Magnetic field")]
        public  short ymag;
            /// <summary>Z Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("Z Magnetic field")]
        public  short zmag;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=26)]
    ///<summary> The RAW IMU readings for a 9DOF sensor, which is identified by the id (default IMU1). This message should always contain the true raw values without any scaling to allow data capture and system debugging. </summary>
    public struct mavlink_raw_imu_t
    {
        public mavlink_raw_imu_t(ulong time_usec,short xacc,short yacc,short zacc,short xgyro,short ygyro,short zgyro,short xmag,short ymag,short zmag) 
        {
              this.time_usec = time_usec;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.xmag = xmag;
              this.ymag = ymag;
              this.zmag = zmag;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>X acceleration (raw)   </summary>
        [Units("")]
        [Description("X acceleration (raw)")]
        public  short xacc;
            /// <summary>Y acceleration (raw)   </summary>
        [Units("")]
        [Description("Y acceleration (raw)")]
        public  short yacc;
            /// <summary>Z acceleration (raw)   </summary>
        [Units("")]
        [Description("Z acceleration (raw)")]
        public  short zacc;
            /// <summary>Angular speed around X axis (raw)   </summary>
        [Units("")]
        [Description("Angular speed around X axis (raw)")]
        public  short xgyro;
            /// <summary>Angular speed around Y axis (raw)   </summary>
        [Units("")]
        [Description("Angular speed around Y axis (raw)")]
        public  short ygyro;
            /// <summary>Angular speed around Z axis (raw)   </summary>
        [Units("")]
        [Description("Angular speed around Z axis (raw)")]
        public  short zgyro;
            /// <summary>X Magnetic field (raw)   </summary>
        [Units("")]
        [Description("X Magnetic field (raw)")]
        public  short xmag;
            /// <summary>Y Magnetic field (raw)   </summary>
        [Units("")]
        [Description("Y Magnetic field (raw)")]
        public  short ymag;
            /// <summary>Z Magnetic field (raw)   </summary>
        [Units("")]
        [Description("Z Magnetic field (raw)")]
        public  short zmag;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=16)]
    ///<summary> The RAW pressure readings for the typical setup of one absolute pressure and one differential pressure sensor. The sensor values should be the raw, UNSCALED ADC values. </summary>
    public struct mavlink_raw_pressure_t
    {
        public mavlink_raw_pressure_t(ulong time_usec,short press_abs,short press_diff1,short press_diff2,short temperature) 
        {
              this.time_usec = time_usec;
              this.press_abs = press_abs;
              this.press_diff1 = press_diff1;
              this.press_diff2 = press_diff2;
              this.temperature = temperature;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Absolute pressure (raw)   </summary>
        [Units("")]
        [Description("Absolute pressure (raw)")]
        public  short press_abs;
            /// <summary>Differential pressure 1 (raw, 0 if nonexistent)   </summary>
        [Units("")]
        [Description("Differential pressure 1 (raw, 0 if nonexistent)")]
        public  short press_diff1;
            /// <summary>Differential pressure 2 (raw, 0 if nonexistent)   </summary>
        [Units("")]
        [Description("Differential pressure 2 (raw, 0 if nonexistent)")]
        public  short press_diff2;
            /// <summary>Raw Temperature measurement (raw)   </summary>
        [Units("")]
        [Description("Raw Temperature measurement (raw)")]
        public  short temperature;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    ///<summary> The pressure readings for the typical setup of one absolute and differential pressure sensor. The units are as specified in each field. </summary>
    public struct mavlink_scaled_pressure_t
    {
        public mavlink_scaled_pressure_t(uint time_boot_ms,float press_abs,float press_diff,short temperature) 
        {
              this.time_boot_ms = time_boot_ms;
              this.press_abs = press_abs;
              this.press_diff = press_diff;
              this.temperature = temperature;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Absolute pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Absolute pressure")]
        public  float press_abs;
            /// <summary>Differential pressure 1  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Differential pressure 1")]
        public  float press_diff;
            /// <summary>Absolute pressure temperature  [cdegC] </summary>
        [Units("[cdegC]")]
        [Description("Absolute pressure temperature")]
        public  short temperature;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=28)]
    ///<summary> The attitude in the aeronautical frame (right-handed, Z-down, Y-right, X-front, ZYX, intrinsic). </summary>
    public struct mavlink_attitude_t
    {
        public mavlink_attitude_t(uint time_boot_ms,float roll,float pitch,float yaw,float rollspeed,float pitchspeed,float yawspeed) 
        {
              this.time_boot_ms = time_boot_ms;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
              this.rollspeed = rollspeed;
              this.pitchspeed = pitchspeed;
              this.yawspeed = yawspeed;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Roll angle (-pi..+pi)  [rad] </summary>
        [Units("[rad]")]
        [Description("Roll angle (-pi..+pi)")]
        public  float roll;
            /// <summary>Pitch angle (-pi..+pi)  [rad] </summary>
        [Units("[rad]")]
        [Description("Pitch angle (-pi..+pi)")]
        public  float pitch;
            /// <summary>Yaw angle (-pi..+pi)  [rad] </summary>
        [Units("[rad]")]
        [Description("Yaw angle (-pi..+pi)")]
        public  float yaw;
            /// <summary>Roll angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Roll angular speed")]
        public  float rollspeed;
            /// <summary>Pitch angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Pitch angular speed")]
        public  float pitchspeed;
            /// <summary>Yaw angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Yaw angular speed")]
        public  float yawspeed;
    
    };

    
    /// extensions_start 8
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> The attitude in the aeronautical frame (right-handed, Z-down, X-front, Y-right), expressed as quaternion. Quaternion order is w, x, y, z and a zero rotation would be expressed as (1 0 0 0). </summary>
    public struct mavlink_attitude_quaternion_t
    {
        public mavlink_attitude_quaternion_t(uint time_boot_ms,float q1,float q2,float q3,float q4,float rollspeed,float pitchspeed,float yawspeed) 
        {
              this.time_boot_ms = time_boot_ms;
              this.q1 = q1;
              this.q2 = q2;
              this.q3 = q3;
              this.q4 = q4;
              this.rollspeed = rollspeed;
              this.pitchspeed = pitchspeed;
              this.yawspeed = yawspeed;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Quaternion component 1, w (1 in null-rotation)   </summary>
        [Units("")]
        [Description("Quaternion component 1, w (1 in null-rotation)")]
        public  float q1;
            /// <summary>Quaternion component 2, x (0 in null-rotation)   </summary>
        [Units("")]
        [Description("Quaternion component 2, x (0 in null-rotation)")]
        public  float q2;
            /// <summary>Quaternion component 3, y (0 in null-rotation)   </summary>
        [Units("")]
        [Description("Quaternion component 3, y (0 in null-rotation)")]
        public  float q3;
            /// <summary>Quaternion component 4, z (0 in null-rotation)   </summary>
        [Units("")]
        [Description("Quaternion component 4, z (0 in null-rotation)")]
        public  float q4;
            /// <summary>Roll angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Roll angular speed")]
        public  float rollspeed;
            /// <summary>Pitch angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Pitch angular speed")]
        public  float pitchspeed;
            /// <summary>Yaw angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Yaw angular speed")]
        public  float yawspeed;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=28)]
    ///<summary> The filtered local position (e.g. fused computer vision and accelerometers). Coordinate frame is right-handed, Z-axis down (aeronautical frame, NED / north-east-down convention) </summary>
    public struct mavlink_local_position_ned_t
    {
        public mavlink_local_position_ned_t(uint time_boot_ms,float x,float y,float z,float vx,float vy,float vz) 
        {
              this.time_boot_ms = time_boot_ms;
              this.x = x;
              this.y = y;
              this.z = z;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X Position  [m] </summary>
        [Units("[m]")]
        [Description("X Position")]
        public  float x;
            /// <summary>Y Position  [m] </summary>
        [Units("[m]")]
        [Description("Y Position")]
        public  float y;
            /// <summary>Z Position  [m] </summary>
        [Units("[m]")]
        [Description("Z Position")]
        public  float z;
            /// <summary>X Speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X Speed")]
        public  float vx;
            /// <summary>Y Speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y Speed")]
        public  float vy;
            /// <summary>Z Speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z Speed")]
        public  float vz;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=28)]
    ///<summary> The filtered global position (e.g. fused GPS and accelerometers). The position is in GPS-frame (right-handed, Z-up). It                is designed as scaled integer message since the resolution of float is not sufficient. </summary>
    public struct mavlink_global_position_int_t
    {
        public mavlink_global_position_int_t(uint time_boot_ms,int lat,int lon,int alt,int relative_alt,short vx,short vy,short vz,ushort hdg) 
        {
              this.time_boot_ms = time_boot_ms;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.relative_alt = relative_alt;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.hdg = hdg;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Latitude, expressed  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude, expressed")]
        public  int lat;
            /// <summary>Longitude, expressed  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude, expressed")]
        public  int lon;
            /// <summary>Altitude (MSL). Note that virtually all GPS modules provide both WGS84 and MSL.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Note that virtually all GPS modules provide both WGS84 and MSL.")]
        public  int alt;
            /// <summary>Altitude above ground  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude above ground")]
        public  int relative_alt;
            /// <summary>Ground X Speed (Latitude, positive north)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground X Speed (Latitude, positive north)")]
        public  short vx;
            /// <summary>Ground Y Speed (Longitude, positive east)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground Y Speed (Longitude, positive east)")]
        public  short vy;
            /// <summary>Ground Z Speed (Altitude, positive down)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground Z Speed (Altitude, positive down)")]
        public  short vz;
            /// <summary>Vehicle heading (yaw angle), 0.0..359.99 degrees. If unknown, set to: UINT16_MAX  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("Vehicle heading (yaw angle), 0.0..359.99 degrees. If unknown, set to: UINT16_MAX")]
        public  ushort hdg;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> The scaled values of the RC channels received: (-100%) -10000, (0%) 0, (100%) 10000. Channels that are inactive should be set to UINT16_MAX. </summary>
    public struct mavlink_rc_channels_scaled_t
    {
        public mavlink_rc_channels_scaled_t(uint time_boot_ms,short chan1_scaled,short chan2_scaled,short chan3_scaled,short chan4_scaled,short chan5_scaled,short chan6_scaled,short chan7_scaled,short chan8_scaled,byte port,byte rssi) 
        {
              this.time_boot_ms = time_boot_ms;
              this.chan1_scaled = chan1_scaled;
              this.chan2_scaled = chan2_scaled;
              this.chan3_scaled = chan3_scaled;
              this.chan4_scaled = chan4_scaled;
              this.chan5_scaled = chan5_scaled;
              this.chan6_scaled = chan6_scaled;
              this.chan7_scaled = chan7_scaled;
              this.chan8_scaled = chan8_scaled;
              this.port = port;
              this.rssi = rssi;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>RC channel 1 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 1 value scaled.")]
        public  short chan1_scaled;
            /// <summary>RC channel 2 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 2 value scaled.")]
        public  short chan2_scaled;
            /// <summary>RC channel 3 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 3 value scaled.")]
        public  short chan3_scaled;
            /// <summary>RC channel 4 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 4 value scaled.")]
        public  short chan4_scaled;
            /// <summary>RC channel 5 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 5 value scaled.")]
        public  short chan5_scaled;
            /// <summary>RC channel 6 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 6 value scaled.")]
        public  short chan6_scaled;
            /// <summary>RC channel 7 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 7 value scaled.")]
        public  short chan7_scaled;
            /// <summary>RC channel 8 value scaled.   </summary>
        [Units("")]
        [Description("RC channel 8 value scaled.")]
        public  short chan8_scaled;
            /// <summary>Servo output port (set of 8 outputs = 1 port). Flight stacks running on Pixhawk should use: 0 = MAIN, 1 = AUX.   </summary>
        [Units("")]
        [Description("Servo output port (set of 8 outputs = 1 port). Flight stacks running on Pixhawk should use: 0 = MAIN, 1 = AUX.")]
        public  byte port;
            /// <summary>Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte rssi;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> The RAW values of the RC channels received. The standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microseconds: 100%. A value of UINT16_MAX implies the channel is unused. Individual receivers/transmitters might violate this specification. </summary>
    public struct mavlink_rc_channels_raw_t
    {
        public mavlink_rc_channels_raw_t(uint time_boot_ms,ushort chan1_raw,ushort chan2_raw,ushort chan3_raw,ushort chan4_raw,ushort chan5_raw,ushort chan6_raw,ushort chan7_raw,ushort chan8_raw,byte port,byte rssi) 
        {
              this.time_boot_ms = time_boot_ms;
              this.chan1_raw = chan1_raw;
              this.chan2_raw = chan2_raw;
              this.chan3_raw = chan3_raw;
              this.chan4_raw = chan4_raw;
              this.chan5_raw = chan5_raw;
              this.chan6_raw = chan6_raw;
              this.chan7_raw = chan7_raw;
              this.chan8_raw = chan8_raw;
              this.port = port;
              this.rssi = rssi;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>RC channel 1 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 1 value.")]
        public  ushort chan1_raw;
            /// <summary>RC channel 2 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 2 value.")]
        public  ushort chan2_raw;
            /// <summary>RC channel 3 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 3 value.")]
        public  ushort chan3_raw;
            /// <summary>RC channel 4 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 4 value.")]
        public  ushort chan4_raw;
            /// <summary>RC channel 5 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 5 value.")]
        public  ushort chan5_raw;
            /// <summary>RC channel 6 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 6 value.")]
        public  ushort chan6_raw;
            /// <summary>RC channel 7 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 7 value.")]
        public  ushort chan7_raw;
            /// <summary>RC channel 8 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 8 value.")]
        public  ushort chan8_raw;
            /// <summary>Servo output port (set of 8 outputs = 1 port). Flight stacks running on Pixhawk should use: 0 = MAIN, 1 = AUX.   </summary>
        [Units("")]
        [Description("Servo output port (set of 8 outputs = 1 port). Flight stacks running on Pixhawk should use: 0 = MAIN, 1 = AUX.")]
        public  byte port;
            /// <summary>Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte rssi;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=21)]
    ///<summary> Superseded by ACTUATOR_OUTPUT_STATUS. The RAW values of the servo outputs (for RC input from the remote, use the RC_CHANNELS messages). The standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microseconds: 100%. </summary>
    public struct mavlink_servo_output_raw_t
    {
        public mavlink_servo_output_raw_t(uint time_usec,ushort servo1_raw,ushort servo2_raw,ushort servo3_raw,ushort servo4_raw,ushort servo5_raw,ushort servo6_raw,ushort servo7_raw,ushort servo8_raw,byte port) 
        {
              this.time_usec = time_usec;
              this.servo1_raw = servo1_raw;
              this.servo2_raw = servo2_raw;
              this.servo3_raw = servo3_raw;
              this.servo4_raw = servo4_raw;
              this.servo5_raw = servo5_raw;
              this.servo6_raw = servo6_raw;
              this.servo7_raw = servo7_raw;
              this.servo8_raw = servo8_raw;
              this.port = port;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  uint time_usec;
            /// <summary>Servo output 1 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 1 value")]
        public  ushort servo1_raw;
            /// <summary>Servo output 2 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 2 value")]
        public  ushort servo2_raw;
            /// <summary>Servo output 3 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 3 value")]
        public  ushort servo3_raw;
            /// <summary>Servo output 4 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 4 value")]
        public  ushort servo4_raw;
            /// <summary>Servo output 5 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 5 value")]
        public  ushort servo5_raw;
            /// <summary>Servo output 6 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 6 value")]
        public  ushort servo6_raw;
            /// <summary>Servo output 7 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 7 value")]
        public  ushort servo7_raw;
            /// <summary>Servo output 8 value  [us] </summary>
        [Units("[us]")]
        [Description("Servo output 8 value")]
        public  ushort servo8_raw;
            /// <summary>Servo output port (set of 8 outputs = 1 port). Flight stacks running on Pixhawk should use: 0 = MAIN, 1 = AUX.   </summary>
        [Units("")]
        [Description("Servo output port (set of 8 outputs = 1 port). Flight stacks running on Pixhawk should use: 0 = MAIN, 1 = AUX.")]
        public  byte port;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary> Request a partial list of mission items from the system/component. https://mavlink.io/en/services/mission.html. If start and end index are the same, just send one waypoint. </summary>
    public struct mavlink_mission_request_partial_list_t
    {
        public mavlink_mission_request_partial_list_t(short start_index,short end_index,byte target_system,byte target_component) 
        {
              this.start_index = start_index;
              this.end_index = end_index;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Start index   </summary>
        [Units("")]
        [Description("Start index")]
        public  short start_index;
            /// <summary>End index, -1 by default (-1: send list to end). Else a valid index of the list   </summary>
        [Units("")]
        [Description("End index, -1 by default (-1: send list to end). Else a valid index of the list")]
        public  short end_index;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary> This message is sent to the MAV to write a partial list. If start index == end index, only one item will be transmitted / updated. If the start index is NOT 0 and above the current list size, this request should be REJECTED! </summary>
    public struct mavlink_mission_write_partial_list_t
    {
        public mavlink_mission_write_partial_list_t(short start_index,short end_index,byte target_system,byte target_component) 
        {
              this.start_index = start_index;
              this.end_index = end_index;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Start index. Must be smaller / equal to the largest index of the current onboard list.   </summary>
        [Units("")]
        [Description("Start index. Must be smaller / equal to the largest index of the current onboard list.")]
        public  short start_index;
            /// <summary>End index, equal or greater than start index.   </summary>
        [Units("")]
        [Description("End index, equal or greater than start index.")]
        public  short end_index;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 14
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=37)]
    ///<summary> Message encoding a mission item. This message is emitted to announce                 the presence of a mission item and to set a mission item on the system. The mission item can be either in x, y, z meters (type: LOCAL) or x:lat, y:lon, z:altitude. Local frame is Z-down, right handed (NED), global frame is Z-up, right handed (ENU). NaN may be used to indicate an optional/default value (e.g. to use the system's current latitude or yaw rather than a specific value). See also https://mavlink.io/en/services/mission.html. </summary>
    public struct mavlink_mission_item_t
    {
        public mavlink_mission_item_t(float param1,float param2,float param3,float param4,float x,float y,float z,ushort seq,/*MAV_CMD*/ushort command,byte target_system,byte target_component,/*MAV_FRAME*/byte frame,byte current,byte autocontinue) 
        {
              this.param1 = param1;
              this.param2 = param2;
              this.param3 = param3;
              this.param4 = param4;
              this.x = x;
              this.y = y;
              this.z = z;
              this.seq = seq;
              this.command = command;
              this.target_system = target_system;
              this.target_component = target_component;
              this.frame = frame;
              this.current = current;
              this.autocontinue = autocontinue;
            
        }
        /// <summary>PARAM1, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM1, see MAV_CMD enum")]
        public  float param1;
            /// <summary>PARAM2, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM2, see MAV_CMD enum")]
        public  float param2;
            /// <summary>PARAM3, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM3, see MAV_CMD enum")]
        public  float param3;
            /// <summary>PARAM4, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM4, see MAV_CMD enum")]
        public  float param4;
            /// <summary>PARAM5 / local: X coordinate, global: latitude   </summary>
        [Units("")]
        [Description("PARAM5 / local: X coordinate, global: latitude")]
        public  float x;
            /// <summary>PARAM6 / local: Y coordinate, global: longitude   </summary>
        [Units("")]
        [Description("PARAM6 / local: Y coordinate, global: longitude")]
        public  float y;
            /// <summary>PARAM7 / local: Z coordinate, global: altitude (relative or absolute, depending on frame).   </summary>
        [Units("")]
        [Description("PARAM7 / local: Z coordinate, global: altitude (relative or absolute, depending on frame).")]
        public  float z;
            /// <summary>Sequence   </summary>
        [Units("")]
        [Description("Sequence")]
        public  ushort seq;
            /// <summary>The scheduled action for the waypoint. MAV_CMD  </summary>
        [Units("")]
        [Description("The scheduled action for the waypoint.")]
        public  /*MAV_CMD*/ushort command;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>The coordinate system of the waypoint. MAV_FRAME  </summary>
        [Units("")]
        [Description("The coordinate system of the waypoint.")]
        public  /*MAV_FRAME*/byte frame;
            /// <summary>false:0, true:1   </summary>
        [Units("")]
        [Description("false:0, true:1")]
        public  byte current;
            /// <summary>Autocontinue to next waypoint. 0: false, 1: true. Set false to pause mission after the item completes.   </summary>
        [Units("")]
        [Description("Autocontinue to next waypoint. 0: false, 1: true. Set false to pause mission after the item completes.")]
        public  byte autocontinue;
    
    };

    
    /// extensions_start 3
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    ///<summary> Request the information of the mission item with the sequence number seq. The response of the system to this message should be a MISSION_ITEM message. https://mavlink.io/en/services/mission.html </summary>
    public struct mavlink_mission_request_t
    {
        public mavlink_mission_request_t(ushort seq,byte target_system,byte target_component) 
        {
              this.seq = seq;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Sequence   </summary>
        [Units("")]
        [Description("Sequence")]
        public  ushort seq;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    ///<summary>          Set the mission item with sequence number seq as the current item and emit MISSION_CURRENT (whether or not the mission number changed).         If a mission is currently being executed, the system will continue to this new mission item on the shortest path, skipping any intermediate mission items.         Note that mission jump repeat counters are not reset (see MAV_CMD_DO_JUMP param2).          This message may trigger a mission state-machine change on some systems: for example from MISSION_STATE_NOT_STARTED or MISSION_STATE_PAUSED to MISSION_STATE_ACTIVE.         If the system is in mission mode, on those systems this command might therefore start, restart or resume the mission.         If the system is not in mission mode this message must not trigger a switch to mission mode.        </summary>
    public struct mavlink_mission_set_current_t
    {
        public mavlink_mission_set_current_t(ushort seq,byte target_system,byte target_component) 
        {
              this.seq = seq;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Sequence   </summary>
        [Units("")]
        [Description("Sequence")]
        public  ushort seq;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 1
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary>          Message that announces the sequence number of the current target mission item (that the system will fly towards/execute when the mission is running).         This message should be streamed all the time (nominally at 1Hz).         This message should be emitted following a call to MAV_CMD_DO_SET_MISSION_CURRENT or SET_MISSION_CURRENT.        </summary>
    public struct mavlink_mission_current_t
    {
        public mavlink_mission_current_t(ushort seq) 
        {
              this.seq = seq;
            
        }
        /// <summary>Sequence   </summary>
        [Units("")]
        [Description("Sequence")]
        public  ushort seq;
    
    };

    
    /// extensions_start 2
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> Request the overall list of mission items from the system/component. </summary>
    public struct mavlink_mission_request_list_t
    {
        public mavlink_mission_request_list_t(byte target_system,byte target_component) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 3
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    ///<summary> This message is emitted as response to MISSION_REQUEST_LIST by the MAV and to initiate a write transaction. The GCS can then request the individual mission item based on the knowledge of the total number of waypoints. </summary>
    public struct mavlink_mission_count_t
    {
        public mavlink_mission_count_t(ushort count,byte target_system,byte target_component) 
        {
              this.count = count;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Number of mission items in the sequence   </summary>
        [Units("")]
        [Description("Number of mission items in the sequence")]
        public  ushort count;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 2
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> Delete all mission items at once. </summary>
    public struct mavlink_mission_clear_all_t
    {
        public mavlink_mission_clear_all_t(byte target_system,byte target_component) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> A certain mission item has been reached. The system will either hold this position (or circle on the orbit) or (if the autocontinue on the WP was set) continue to the next waypoint. </summary>
    public struct mavlink_mission_item_reached_t
    {
        public mavlink_mission_item_reached_t(ushort seq) 
        {
              this.seq = seq;
            
        }
        /// <summary>Sequence   </summary>
        [Units("")]
        [Description("Sequence")]
        public  ushort seq;
    
    };

    
    /// extensions_start 3
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=3)]
    ///<summary> Acknowledgment message during waypoint handling. The type field states if this message is a positive ack (type=0) or if an error happened (type=non-zero). </summary>
    public struct mavlink_mission_ack_t
    {
        public mavlink_mission_ack_t(byte target_system,byte target_component,/*MAV_MISSION_RESULT*/byte type) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
              this.type = type;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Mission result. MAV_MISSION_RESULT  </summary>
        [Units("")]
        [Description("Mission result.")]
        public  /*MAV_MISSION_RESULT*/byte type;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=13)]
    ///<summary> Sets the GPS coordinates of the vehicle local origin (0,0,0) position. Vehicle should emit GPS_GLOBAL_ORIGIN irrespective of whether the origin is changed. This enables transform between the local coordinate frame and the global (GPS) coordinate frame, which may be necessary when (for example) indoor and outdoor settings are connected and the MAV should move from in- to outdoor. </summary>
    public struct mavlink_set_gps_global_origin_t
    {
        public mavlink_set_gps_global_origin_t(int latitude,int longitude,int altitude,byte target_system) 
        {
              this.latitude = latitude;
              this.longitude = longitude;
              this.altitude = altitude;
              this.target_system = target_system;
            
        }
        /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int latitude;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int longitude;
            /// <summary>Altitude (MSL). Positive for up.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  int altitude;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
    
    };

    
    /// extensions_start 3
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=12)]
    ///<summary> Publishes the GPS coordinates of the vehicle local origin (0,0,0) position. Emitted whenever a new GPS-Local position mapping is requested or set - e.g. following SET_GPS_GLOBAL_ORIGIN message. </summary>
    public struct mavlink_gps_global_origin_t
    {
        public mavlink_gps_global_origin_t(int latitude,int longitude,int altitude) 
        {
              this.latitude = latitude;
              this.longitude = longitude;
              this.altitude = altitude;
            
        }
        /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int latitude;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int longitude;
            /// <summary>Altitude (MSL). Positive for up.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  int altitude;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=37)]
    ///<summary> Bind a RC channel to a parameter. The parameter should change according to the RC channel value. </summary>
    public struct mavlink_param_map_rc_t
    {
        public mavlink_param_map_rc_t(float param_value0,float scale,float param_value_min,float param_value_max,short param_index,byte target_system,byte target_component,byte[] param_id,byte parameter_rc_channel_index) 
        {
              this.param_value0 = param_value0;
              this.scale = scale;
              this.param_value_min = param_value_min;
              this.param_value_max = param_value_max;
              this.param_index = param_index;
              this.target_system = target_system;
              this.target_component = target_component;
              this.param_id = param_id;
              this.parameter_rc_channel_index = parameter_rc_channel_index;
            
        }
        /// <summary>Initial parameter value   </summary>
        [Units("")]
        [Description("Initial parameter value")]
        public  float param_value0;
            /// <summary>Scale, maps the RC range [-1, 1] to a parameter value   </summary>
        [Units("")]
        [Description("Scale, maps the RC range [-1, 1] to a parameter value")]
        public  float scale;
            /// <summary>Minimum param value. The protocol does not define if this overwrites an onboard minimum value. (Depends on implementation)   </summary>
        [Units("")]
        [Description("Minimum param value. The protocol does not define if this overwrites an onboard minimum value. (Depends on implementation)")]
        public  float param_value_min;
            /// <summary>Maximum param value. The protocol does not define if this overwrites an onboard maximum value. (Depends on implementation)   </summary>
        [Units("")]
        [Description("Maximum param value. The protocol does not define if this overwrites an onboard maximum value. (Depends on implementation)")]
        public  float param_value_max;
            /// <summary>Parameter index. Send -1 to use the param ID field as identifier (else the param id will be ignored), send -2 to disable any existing map for this rc_channel_index.   </summary>
        [Units("")]
        [Description("Parameter index. Send -1 to use the param ID field as identifier (else the param id will be ignored), send -2 to disable any existing map for this rc_channel_index.")]
        public  short param_index;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string   </summary>
        [Units("")]
        [Description("Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=16)]
		public byte[] param_id;
            /// <summary>Index of parameter RC channel. Not equal to the RC channel id. Typically corresponds to a potentiometer-knob on the RC.   </summary>
        [Units("")]
        [Description("Index of parameter RC channel. Not equal to the RC channel id. Typically corresponds to a potentiometer-knob on the RC.")]
        public  byte parameter_rc_channel_index;
    
    };

    
    /// extensions_start 3
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    ///<summary> Request the information of the mission item with the sequence number seq. The response of the system to this message should be a MISSION_ITEM_INT message. https://mavlink.io/en/services/mission.html </summary>
    public struct mavlink_mission_request_int_t
    {
        public mavlink_mission_request_int_t(ushort seq,byte target_system,byte target_component) 
        {
              this.seq = seq;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Sequence   </summary>
        [Units("")]
        [Description("Sequence")]
        public  ushort seq;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=27)]
    ///<summary> Set a safety zone (volume), which is defined by two corners of a cube. This message can be used to tell the MAV which setpoints/waypoints to accept and which to reject. Safety areas are often enforced by national or competition regulations. </summary>
    public struct mavlink_safety_set_allowed_area_t
    {
        public mavlink_safety_set_allowed_area_t(float p1x,float p1y,float p1z,float p2x,float p2y,float p2z,byte target_system,byte target_component,/*MAV_FRAME*/byte frame) 
        {
              this.p1x = p1x;
              this.p1y = p1y;
              this.p1z = p1z;
              this.p2x = p2x;
              this.p2y = p2y;
              this.p2z = p2z;
              this.target_system = target_system;
              this.target_component = target_component;
              this.frame = frame;
            
        }
        /// <summary>x position 1 / Latitude 1  [m] </summary>
        [Units("[m]")]
        [Description("x position 1 / Latitude 1")]
        public  float p1x;
            /// <summary>y position 1 / Longitude 1  [m] </summary>
        [Units("[m]")]
        [Description("y position 1 / Longitude 1")]
        public  float p1y;
            /// <summary>z position 1 / Altitude 1  [m] </summary>
        [Units("[m]")]
        [Description("z position 1 / Altitude 1")]
        public  float p1z;
            /// <summary>x position 2 / Latitude 2  [m] </summary>
        [Units("[m]")]
        [Description("x position 2 / Latitude 2")]
        public  float p2x;
            /// <summary>y position 2 / Longitude 2  [m] </summary>
        [Units("[m]")]
        [Description("y position 2 / Longitude 2")]
        public  float p2y;
            /// <summary>z position 2 / Altitude 2  [m] </summary>
        [Units("[m]")]
        [Description("z position 2 / Altitude 2")]
        public  float p2z;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Coordinate frame. Can be either global, GPS, right-handed with Z axis up or local, right handed, Z axis down. MAV_FRAME  </summary>
        [Units("")]
        [Description("Coordinate frame. Can be either global, GPS, right-handed with Z axis up or local, right handed, Z axis down.")]
        public  /*MAV_FRAME*/byte frame;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=25)]
    ///<summary> Read out the safety zone the MAV currently assumes. </summary>
    public struct mavlink_safety_allowed_area_t
    {
        public mavlink_safety_allowed_area_t(float p1x,float p1y,float p1z,float p2x,float p2y,float p2z,/*MAV_FRAME*/byte frame) 
        {
              this.p1x = p1x;
              this.p1y = p1y;
              this.p1z = p1z;
              this.p2x = p2x;
              this.p2y = p2y;
              this.p2z = p2z;
              this.frame = frame;
            
        }
        /// <summary>x position 1 / Latitude 1  [m] </summary>
        [Units("[m]")]
        [Description("x position 1 / Latitude 1")]
        public  float p1x;
            /// <summary>y position 1 / Longitude 1  [m] </summary>
        [Units("[m]")]
        [Description("y position 1 / Longitude 1")]
        public  float p1y;
            /// <summary>z position 1 / Altitude 1  [m] </summary>
        [Units("[m]")]
        [Description("z position 1 / Altitude 1")]
        public  float p1z;
            /// <summary>x position 2 / Latitude 2  [m] </summary>
        [Units("[m]")]
        [Description("x position 2 / Latitude 2")]
        public  float p2x;
            /// <summary>y position 2 / Longitude 2  [m] </summary>
        [Units("[m]")]
        [Description("y position 2 / Longitude 2")]
        public  float p2y;
            /// <summary>z position 2 / Altitude 2  [m] </summary>
        [Units("[m]")]
        [Description("z position 2 / Altitude 2")]
        public  float p2z;
            /// <summary>Coordinate frame. Can be either global, GPS, right-handed with Z axis up or local, right handed, Z axis down. MAV_FRAME  </summary>
        [Units("")]
        [Description("Coordinate frame. Can be either global, GPS, right-handed with Z axis up or local, right handed, Z axis down.")]
        public  /*MAV_FRAME*/byte frame;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=72)]
    ///<summary> The attitude in the aeronautical frame (right-handed, Z-down, X-front, Y-right), expressed as quaternion. Quaternion order is w, x, y, z and a zero rotation would be expressed as (1 0 0 0). </summary>
    public struct mavlink_attitude_quaternion_cov_t
    {
        public mavlink_attitude_quaternion_cov_t(ulong time_usec,float[] q,float rollspeed,float pitchspeed,float yawspeed,float[] covariance) 
        {
              this.time_usec = time_usec;
              this.q = q;
              this.rollspeed = rollspeed;
              this.pitchspeed = pitchspeed;
              this.yawspeed = yawspeed;
              this.covariance = covariance;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Quaternion components, w, x, y, z (1 0 0 0 is the null-rotation)   </summary>
        [Units("")]
        [Description("Quaternion components, w, x, y, z (1 0 0 0 is the null-rotation)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>Roll angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Roll angular speed")]
        public  float rollspeed;
            /// <summary>Pitch angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Pitch angular speed")]
        public  float pitchspeed;
            /// <summary>Yaw angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Yaw angular speed")]
        public  float yawspeed;
            /// <summary>Row-major representation of a 3x3 attitude covariance matrix (states: roll, pitch, yaw; first three entries are the first ROW, next three entries are the second row, etc.). If unknown, assign NaN value to first element in the array.   </summary>
        [Units("")]
        [Description("Row-major representation of a 3x3 attitude covariance matrix (states: roll, pitch, yaw; first three entries are the first ROW, next three entries are the second row, etc.). If unknown, assign NaN value to first element in the array.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=9)]
		public float[] covariance;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=26)]
    ///<summary> The state of the navigation and position controller. </summary>
    public struct mavlink_nav_controller_output_t
    {
        public mavlink_nav_controller_output_t(float nav_roll,float nav_pitch,float alt_error,float aspd_error,float xtrack_error,short nav_bearing,short target_bearing,ushort wp_dist) 
        {
              this.nav_roll = nav_roll;
              this.nav_pitch = nav_pitch;
              this.alt_error = alt_error;
              this.aspd_error = aspd_error;
              this.xtrack_error = xtrack_error;
              this.nav_bearing = nav_bearing;
              this.target_bearing = target_bearing;
              this.wp_dist = wp_dist;
            
        }
        /// <summary>Current desired roll  [deg] </summary>
        [Units("[deg]")]
        [Description("Current desired roll")]
        public  float nav_roll;
            /// <summary>Current desired pitch  [deg] </summary>
        [Units("[deg]")]
        [Description("Current desired pitch")]
        public  float nav_pitch;
            /// <summary>Current altitude error  [m] </summary>
        [Units("[m]")]
        [Description("Current altitude error")]
        public  float alt_error;
            /// <summary>Current airspeed error  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Current airspeed error")]
        public  float aspd_error;
            /// <summary>Current crosstrack error on x-y plane  [m] </summary>
        [Units("[m]")]
        [Description("Current crosstrack error on x-y plane")]
        public  float xtrack_error;
            /// <summary>Current desired heading  [deg] </summary>
        [Units("[deg]")]
        [Description("Current desired heading")]
        public  short nav_bearing;
            /// <summary>Bearing to current waypoint/target  [deg] </summary>
        [Units("[deg]")]
        [Description("Bearing to current waypoint/target")]
        public  short target_bearing;
            /// <summary>Distance to active waypoint  [m] </summary>
        [Units("[m]")]
        [Description("Distance to active waypoint")]
        public  ushort wp_dist;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=181)]
    ///<summary> The filtered global position (e.g. fused GPS and accelerometers). The position is in GPS-frame (right-handed, Z-up). It  is designed as scaled integer message since the resolution of float is not sufficient. NOTE: This message is intended for onboard networks / companion computers and higher-bandwidth links and optimized for accuracy and completeness. Please use the GLOBAL_POSITION_INT message for a minimal subset. </summary>
    public struct mavlink_global_position_int_cov_t
    {
        public mavlink_global_position_int_cov_t(ulong time_usec,int lat,int lon,int alt,int relative_alt,float vx,float vy,float vz,float[] covariance,/*MAV_ESTIMATOR_TYPE*/byte estimator_type) 
        {
              this.time_usec = time_usec;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.relative_alt = relative_alt;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.covariance = covariance;
              this.estimator_type = estimator_type;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int lat;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int lon;
            /// <summary>Altitude in meters above MSL  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude in meters above MSL")]
        public  int alt;
            /// <summary>Altitude above ground  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude above ground")]
        public  int relative_alt;
            /// <summary>Ground X Speed (Latitude)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Ground X Speed (Latitude)")]
        public  float vx;
            /// <summary>Ground Y Speed (Longitude)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Ground Y Speed (Longitude)")]
        public  float vy;
            /// <summary>Ground Z Speed (Altitude)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Ground Z Speed (Altitude)")]
        public  float vz;
            /// <summary>Row-major representation of a 6x6 position and velocity 6x6 cross-covariance matrix (states: lat, lon, alt, vx, vy, vz; first six entries are the first ROW, next six entries are the second row, etc.). If unknown, assign NaN value to first element in the array.   </summary>
        [Units("")]
        [Description("Row-major representation of a 6x6 position and velocity 6x6 cross-covariance matrix (states: lat, lon, alt, vx, vy, vz; first six entries are the first ROW, next six entries are the second row, etc.). If unknown, assign NaN value to first element in the array.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=36)]
		public float[] covariance;
            /// <summary>Class id of the estimator this estimate originated from. MAV_ESTIMATOR_TYPE  </summary>
        [Units("")]
        [Description("Class id of the estimator this estimate originated from.")]
        public  /*MAV_ESTIMATOR_TYPE*/byte estimator_type;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=225)]
    ///<summary> The filtered local position (e.g. fused computer vision and accelerometers). Coordinate frame is right-handed, Z-axis down (aeronautical frame, NED / north-east-down convention) </summary>
    public struct mavlink_local_position_ned_cov_t
    {
        public mavlink_local_position_ned_cov_t(ulong time_usec,float x,float y,float z,float vx,float vy,float vz,float ax,float ay,float az,float[] covariance,/*MAV_ESTIMATOR_TYPE*/byte estimator_type) 
        {
              this.time_usec = time_usec;
              this.x = x;
              this.y = y;
              this.z = z;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.ax = ax;
              this.ay = ay;
              this.az = az;
              this.covariance = covariance;
              this.estimator_type = estimator_type;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>X Position  [m] </summary>
        [Units("[m]")]
        [Description("X Position")]
        public  float x;
            /// <summary>Y Position  [m] </summary>
        [Units("[m]")]
        [Description("Y Position")]
        public  float y;
            /// <summary>Z Position  [m] </summary>
        [Units("[m]")]
        [Description("Z Position")]
        public  float z;
            /// <summary>X Speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X Speed")]
        public  float vx;
            /// <summary>Y Speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y Speed")]
        public  float vy;
            /// <summary>Z Speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z Speed")]
        public  float vz;
            /// <summary>X Acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X Acceleration")]
        public  float ax;
            /// <summary>Y Acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y Acceleration")]
        public  float ay;
            /// <summary>Z Acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z Acceleration")]
        public  float az;
            /// <summary>Row-major representation of position, velocity and acceleration 9x9 cross-covariance matrix upper right triangle (states: x, y, z, vx, vy, vz, ax, ay, az; first nine entries are the first ROW, next eight entries are the second row, etc.). If unknown, assign NaN value to first element in the array.   </summary>
        [Units("")]
        [Description("Row-major representation of position, velocity and acceleration 9x9 cross-covariance matrix upper right triangle (states: x, y, z, vx, vy, vz, ax, ay, az; first nine entries are the first ROW, next eight entries are the second row, etc.). If unknown, assign NaN value to first element in the array.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=45)]
		public float[] covariance;
            /// <summary>Class id of the estimator this estimate originated from. MAV_ESTIMATOR_TYPE  </summary>
        [Units("")]
        [Description("Class id of the estimator this estimate originated from.")]
        public  /*MAV_ESTIMATOR_TYPE*/byte estimator_type;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=42)]
    ///<summary> The PPM values of the RC channels received. The standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microseconds: 100%.  A value of UINT16_MAX implies the channel is unused. Individual receivers/transmitters might violate this specification. </summary>
    public struct mavlink_rc_channels_t
    {
        public mavlink_rc_channels_t(uint time_boot_ms,ushort chan1_raw,ushort chan2_raw,ushort chan3_raw,ushort chan4_raw,ushort chan5_raw,ushort chan6_raw,ushort chan7_raw,ushort chan8_raw,ushort chan9_raw,ushort chan10_raw,ushort chan11_raw,ushort chan12_raw,ushort chan13_raw,ushort chan14_raw,ushort chan15_raw,ushort chan16_raw,ushort chan17_raw,ushort chan18_raw,byte chancount,byte rssi) 
        {
              this.time_boot_ms = time_boot_ms;
              this.chan1_raw = chan1_raw;
              this.chan2_raw = chan2_raw;
              this.chan3_raw = chan3_raw;
              this.chan4_raw = chan4_raw;
              this.chan5_raw = chan5_raw;
              this.chan6_raw = chan6_raw;
              this.chan7_raw = chan7_raw;
              this.chan8_raw = chan8_raw;
              this.chan9_raw = chan9_raw;
              this.chan10_raw = chan10_raw;
              this.chan11_raw = chan11_raw;
              this.chan12_raw = chan12_raw;
              this.chan13_raw = chan13_raw;
              this.chan14_raw = chan14_raw;
              this.chan15_raw = chan15_raw;
              this.chan16_raw = chan16_raw;
              this.chan17_raw = chan17_raw;
              this.chan18_raw = chan18_raw;
              this.chancount = chancount;
              this.rssi = rssi;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>RC channel 1 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 1 value.")]
        public  ushort chan1_raw;
            /// <summary>RC channel 2 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 2 value.")]
        public  ushort chan2_raw;
            /// <summary>RC channel 3 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 3 value.")]
        public  ushort chan3_raw;
            /// <summary>RC channel 4 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 4 value.")]
        public  ushort chan4_raw;
            /// <summary>RC channel 5 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 5 value.")]
        public  ushort chan5_raw;
            /// <summary>RC channel 6 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 6 value.")]
        public  ushort chan6_raw;
            /// <summary>RC channel 7 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 7 value.")]
        public  ushort chan7_raw;
            /// <summary>RC channel 8 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 8 value.")]
        public  ushort chan8_raw;
            /// <summary>RC channel 9 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 9 value.")]
        public  ushort chan9_raw;
            /// <summary>RC channel 10 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 10 value.")]
        public  ushort chan10_raw;
            /// <summary>RC channel 11 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 11 value.")]
        public  ushort chan11_raw;
            /// <summary>RC channel 12 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 12 value.")]
        public  ushort chan12_raw;
            /// <summary>RC channel 13 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 13 value.")]
        public  ushort chan13_raw;
            /// <summary>RC channel 14 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 14 value.")]
        public  ushort chan14_raw;
            /// <summary>RC channel 15 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 15 value.")]
        public  ushort chan15_raw;
            /// <summary>RC channel 16 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 16 value.")]
        public  ushort chan16_raw;
            /// <summary>RC channel 17 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 17 value.")]
        public  ushort chan17_raw;
            /// <summary>RC channel 18 value.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 18 value.")]
        public  ushort chan18_raw;
            /// <summary>Total number of RC channels being received. This can be larger than 18, indicating that more channels are available but not given in this message. This value should be 0 when no RC channels are available.   </summary>
        [Units("")]
        [Description("Total number of RC channels being received. This can be larger than 18, indicating that more channels are available but not given in this message. This value should be 0 when no RC channels are available.")]
        public  byte chancount;
            /// <summary>Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte rssi;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary> Request a data stream. </summary>
    public struct mavlink_request_data_stream_t
    {
        public mavlink_request_data_stream_t(ushort req_message_rate,byte target_system,byte target_component,byte req_stream_id,byte start_stop) 
        {
              this.req_message_rate = req_message_rate;
              this.target_system = target_system;
              this.target_component = target_component;
              this.req_stream_id = req_stream_id;
              this.start_stop = start_stop;
            
        }
        /// <summary>The requested message rate  [Hz] </summary>
        [Units("[Hz]")]
        [Description("The requested message rate")]
        public  ushort req_message_rate;
            /// <summary>The target requested to send the message stream.   </summary>
        [Units("")]
        [Description("The target requested to send the message stream.")]
        public  byte target_system;
            /// <summary>The target requested to send the message stream.   </summary>
        [Units("")]
        [Description("The target requested to send the message stream.")]
        public  byte target_component;
            /// <summary>The ID of the requested data stream   </summary>
        [Units("")]
        [Description("The ID of the requested data stream")]
        public  byte req_stream_id;
            /// <summary>1 to start sending, 0 to stop sending.   </summary>
        [Units("")]
        [Description("1 to start sending, 0 to stop sending.")]
        public  byte start_stop;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    ///<summary> Data stream status information. </summary>
    public struct mavlink_data_stream_t
    {
        public mavlink_data_stream_t(ushort message_rate,byte stream_id,byte on_off) 
        {
              this.message_rate = message_rate;
              this.stream_id = stream_id;
              this.on_off = on_off;
            
        }
        /// <summary>The message rate  [Hz] </summary>
        [Units("[Hz]")]
        [Description("The message rate")]
        public  ushort message_rate;
            /// <summary>The ID of the requested data stream   </summary>
        [Units("")]
        [Description("The ID of the requested data stream")]
        public  byte stream_id;
            /// <summary>1 stream is enabled, 0 stream is stopped.   </summary>
        [Units("")]
        [Description("1 stream is enabled, 0 stream is stopped.")]
        public  byte on_off;
    
    };

    
    /// extensions_start 6
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=11)]
    ///<summary> This message provides an API for manually controlling the vehicle using standard joystick axes nomenclature, along with a joystick-like input device. Unused axes can be disabled and buttons states are transmitted as individual on/off bits of a bitmask </summary>
    public struct mavlink_manual_control_t
    {
        public mavlink_manual_control_t(short x,short y,short z,short r,ushort buttons,byte target) 
        {
              this.x = x;
              this.y = y;
              this.z = z;
              this.r = r;
              this.buttons = buttons;
              this.target = target;
            
        }
        /// <summary>X-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to forward(1000)-backward(-1000) movement on a joystick and the pitch of a vehicle.   </summary>
        [Units("")]
        [Description("X-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to forward(1000)-backward(-1000) movement on a joystick and the pitch of a vehicle.")]
        public  short x;
            /// <summary>Y-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to left(-1000)-right(1000) movement on a joystick and the roll of a vehicle.   </summary>
        [Units("")]
        [Description("Y-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to left(-1000)-right(1000) movement on a joystick and the roll of a vehicle.")]
        public  short y;
            /// <summary>Z-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to a separate slider movement with maximum being 1000 and minimum being -1000 on a joystick and the thrust of a vehicle. Positive values are positive thrust, negative values are negative thrust.   </summary>
        [Units("")]
        [Description("Z-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to a separate slider movement with maximum being 1000 and minimum being -1000 on a joystick and the thrust of a vehicle. Positive values are positive thrust, negative values are negative thrust.")]
        public  short z;
            /// <summary>R-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to a twisting of the joystick, with counter-clockwise being 1000 and clockwise being -1000, and the yaw of a vehicle.   </summary>
        [Units("")]
        [Description("R-axis, normalized to the range [-1000,1000]. A value of INT16_MAX indicates that this axis is invalid. Generally corresponds to a twisting of the joystick, with counter-clockwise being 1000 and clockwise being -1000, and the yaw of a vehicle.")]
        public  short r;
            /// <summary>A bitfield corresponding to the joystick buttons' 0-15 current state, 1 for pressed, 0 for released. The lowest bit corresponds to Button 1.   </summary>
        [Units("")]
        [Description("A bitfield corresponding to the joystick buttons' 0-15 current state, 1 for pressed, 0 for released. The lowest bit corresponds to Button 1.")]
        public  ushort buttons;
            /// <summary>The system to be controlled.   </summary>
        [Units("")]
        [Description("The system to be controlled.")]
        public  byte target;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=18)]
    ///<summary> The RAW values of the RC channels sent to the MAV to override info received from the RC radio. The standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microseconds: 100%. Individual receivers/transmitters might violate this specification.  Note carefully the semantic differences between the first 8 channels and the subsequent channels </summary>
    public struct mavlink_rc_channels_override_t
    {
        public mavlink_rc_channels_override_t(ushort chan1_raw,ushort chan2_raw,ushort chan3_raw,ushort chan4_raw,ushort chan5_raw,ushort chan6_raw,ushort chan7_raw,ushort chan8_raw,byte target_system,byte target_component) 
        {
              this.chan1_raw = chan1_raw;
              this.chan2_raw = chan2_raw;
              this.chan3_raw = chan3_raw;
              this.chan4_raw = chan4_raw;
              this.chan5_raw = chan5_raw;
              this.chan6_raw = chan6_raw;
              this.chan7_raw = chan7_raw;
              this.chan8_raw = chan8_raw;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>RC channel 1 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 1 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan1_raw;
            /// <summary>RC channel 2 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 2 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan2_raw;
            /// <summary>RC channel 3 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 3 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan3_raw;
            /// <summary>RC channel 4 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 4 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan4_raw;
            /// <summary>RC channel 5 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 5 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan5_raw;
            /// <summary>RC channel 6 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 6 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan6_raw;
            /// <summary>RC channel 7 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 7 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan7_raw;
            /// <summary>RC channel 8 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 8 value. A value of UINT16_MAX means to ignore this field. A value of 0 means to release this channel back to the RC radio.")]
        public  ushort chan8_raw;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 14
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=37)]
    ///<summary> Message encoding a mission item. This message is emitted to announce                 the presence of a mission item and to set a mission item on the system. The mission item can be either in x, y, z meters (type: LOCAL) or x:lat, y:lon, z:altitude. Local frame is Z-down, right handed (NED), global frame is Z-up, right handed (ENU). NaN or INT32_MAX may be used in float/integer params (respectively) to indicate optional/default values (e.g. to use the component's current latitude, yaw rather than a specific value). See also https://mavlink.io/en/services/mission.html. </summary>
    public struct mavlink_mission_item_int_t
    {
        public mavlink_mission_item_int_t(float param1,float param2,float param3,float param4,int x,int y,float z,ushort seq,/*MAV_CMD*/ushort command,byte target_system,byte target_component,/*MAV_FRAME*/byte frame,byte current,byte autocontinue) 
        {
              this.param1 = param1;
              this.param2 = param2;
              this.param3 = param3;
              this.param4 = param4;
              this.x = x;
              this.y = y;
              this.z = z;
              this.seq = seq;
              this.command = command;
              this.target_system = target_system;
              this.target_component = target_component;
              this.frame = frame;
              this.current = current;
              this.autocontinue = autocontinue;
            
        }
        /// <summary>PARAM1, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM1, see MAV_CMD enum")]
        public  float param1;
            /// <summary>PARAM2, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM2, see MAV_CMD enum")]
        public  float param2;
            /// <summary>PARAM3, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM3, see MAV_CMD enum")]
        public  float param3;
            /// <summary>PARAM4, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM4, see MAV_CMD enum")]
        public  float param4;
            /// <summary>PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7   </summary>
        [Units("")]
        [Description("PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7")]
        public  int x;
            /// <summary>PARAM6 / y position: local: x position in meters * 1e4, global: longitude in degrees *10^7   </summary>
        [Units("")]
        [Description("PARAM6 / y position: local: x position in meters * 1e4, global: longitude in degrees *10^7")]
        public  int y;
            /// <summary>PARAM7 / z position: global: altitude in meters (relative or absolute, depending on frame.   </summary>
        [Units("")]
        [Description("PARAM7 / z position: global: altitude in meters (relative or absolute, depending on frame.")]
        public  float z;
            /// <summary>Waypoint ID (sequence number). Starts at zero. Increases monotonically for each waypoint, no gaps in the sequence (0,1,2,3,4).   </summary>
        [Units("")]
        [Description("Waypoint ID (sequence number). Starts at zero. Increases monotonically for each waypoint, no gaps in the sequence (0,1,2,3,4).")]
        public  ushort seq;
            /// <summary>The scheduled action for the waypoint. MAV_CMD  </summary>
        [Units("")]
        [Description("The scheduled action for the waypoint.")]
        public  /*MAV_CMD*/ushort command;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>The coordinate system of the waypoint. MAV_FRAME  </summary>
        [Units("")]
        [Description("The coordinate system of the waypoint.")]
        public  /*MAV_FRAME*/byte frame;
            /// <summary>false:0, true:1   </summary>
        [Units("")]
        [Description("false:0, true:1")]
        public  byte current;
            /// <summary>Autocontinue to next waypoint. 0: false, 1: true. Set false to pause mission after the item completes.   </summary>
        [Units("")]
        [Description("Autocontinue to next waypoint. 0: false, 1: true. Set false to pause mission after the item completes.")]
        public  byte autocontinue;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=20)]
    ///<summary> Metrics typically displayed on a HUD for fixed wing aircraft. </summary>
    public struct mavlink_vfr_hud_t
    {
        public mavlink_vfr_hud_t(float airspeed,float groundspeed,float alt,float climb,short heading,ushort throttle) 
        {
              this.airspeed = airspeed;
              this.groundspeed = groundspeed;
              this.alt = alt;
              this.climb = climb;
              this.heading = heading;
              this.throttle = throttle;
            
        }
        /// <summary>Vehicle speed in form appropriate for vehicle type. For standard aircraft this is typically calibrated airspeed (CAS) or indicated airspeed (IAS) - either of which can be used by a pilot to estimate stall speed.  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Vehicle speed in form appropriate for vehicle type. For standard aircraft this is typically calibrated airspeed (CAS) or indicated airspeed (IAS) - either of which can be used by a pilot to estimate stall speed.")]
        public  float airspeed;
            /// <summary>Current ground speed.  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Current ground speed.")]
        public  float groundspeed;
            /// <summary>Current altitude (MSL).  [m] </summary>
        [Units("[m]")]
        [Description("Current altitude (MSL).")]
        public  float alt;
            /// <summary>Current climb rate.  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Current climb rate.")]
        public  float climb;
            /// <summary>Current heading in compass units (0-360, 0=north).  [deg] </summary>
        [Units("[deg]")]
        [Description("Current heading in compass units (0-360, 0=north).")]
        public  short heading;
            /// <summary>Current throttle setting (0 to 100).  [%] </summary>
        [Units("[%]")]
        [Description("Current throttle setting (0 to 100).")]
        public  ushort throttle;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=35)]
    ///<summary> Send a command with up to seven parameters to the MAV, where params 5 and 6 are integers and the other values are floats. This is preferred over COMMAND_LONG as it allows the MAV_FRAME to be specified for interpreting positional information, such as altitude. COMMAND_INT is also preferred when sending latitude and longitude data in params 5 and 6, as it allows for greater precision. Param 5 and 6 encode positional data as scaled integers, where the scaling depends on the actual command value. NaN or INT32_MAX may be used in float/integer params (respectively) to indicate optional/default values (e.g. to use the component's current latitude, yaw rather than a specific value). The command microservice is documented at https://mavlink.io/en/services/command.html </summary>
    public struct mavlink_command_int_t
    {
        public mavlink_command_int_t(float param1,float param2,float param3,float param4,int x,int y,float z,/*MAV_CMD*/ushort command,byte target_system,byte target_component,/*MAV_FRAME*/byte frame,byte current,byte autocontinue) 
        {
              this.param1 = param1;
              this.param2 = param2;
              this.param3 = param3;
              this.param4 = param4;
              this.x = x;
              this.y = y;
              this.z = z;
              this.command = command;
              this.target_system = target_system;
              this.target_component = target_component;
              this.frame = frame;
              this.current = current;
              this.autocontinue = autocontinue;
            
        }
        /// <summary>PARAM1, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM1, see MAV_CMD enum")]
        public  float param1;
            /// <summary>PARAM2, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM2, see MAV_CMD enum")]
        public  float param2;
            /// <summary>PARAM3, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM3, see MAV_CMD enum")]
        public  float param3;
            /// <summary>PARAM4, see MAV_CMD enum   </summary>
        [Units("")]
        [Description("PARAM4, see MAV_CMD enum")]
        public  float param4;
            /// <summary>PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7   </summary>
        [Units("")]
        [Description("PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7")]
        public  int x;
            /// <summary>PARAM6 / local: y position in meters * 1e4, global: longitude in degrees * 10^7   </summary>
        [Units("")]
        [Description("PARAM6 / local: y position in meters * 1e4, global: longitude in degrees * 10^7")]
        public  int y;
            /// <summary>PARAM7 / z position: global: altitude in meters (relative or absolute, depending on frame).   </summary>
        [Units("")]
        [Description("PARAM7 / z position: global: altitude in meters (relative or absolute, depending on frame).")]
        public  float z;
            /// <summary>The scheduled action for the mission item. MAV_CMD  </summary>
        [Units("")]
        [Description("The scheduled action for the mission item.")]
        public  /*MAV_CMD*/ushort command;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>The coordinate system of the COMMAND. MAV_FRAME  </summary>
        [Units("")]
        [Description("The coordinate system of the COMMAND.")]
        public  /*MAV_FRAME*/byte frame;
            /// <summary>Not used.   </summary>
        [Units("")]
        [Description("Not used.")]
        public  byte current;
            /// <summary>Not used (set 0).   </summary>
        [Units("")]
        [Description("Not used (set 0).")]
        public  byte autocontinue;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=33)]
    ///<summary> Send a command with up to seven parameters to the MAV. COMMAND_INT is generally preferred when sending MAV_CMD commands that include positional information; it offers higher precision and allows the MAV_FRAME to be specified (which may otherwise be ambiguous, particularly for altitude). The command microservice is documented at https://mavlink.io/en/services/command.html </summary>
    public struct mavlink_command_long_t
    {
        public mavlink_command_long_t(float param1,float param2,float param3,float param4,float param5,float param6,float param7,/*MAV_CMD*/ushort command,byte target_system,byte target_component,byte confirmation) 
        {
              this.param1 = param1;
              this.param2 = param2;
              this.param3 = param3;
              this.param4 = param4;
              this.param5 = param5;
              this.param6 = param6;
              this.param7 = param7;
              this.command = command;
              this.target_system = target_system;
              this.target_component = target_component;
              this.confirmation = confirmation;
            
        }
        /// <summary>Parameter 1 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 1 (for the specific command).")]
        public  float param1;
            /// <summary>Parameter 2 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 2 (for the specific command).")]
        public  float param2;
            /// <summary>Parameter 3 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 3 (for the specific command).")]
        public  float param3;
            /// <summary>Parameter 4 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 4 (for the specific command).")]
        public  float param4;
            /// <summary>Parameter 5 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 5 (for the specific command).")]
        public  float param5;
            /// <summary>Parameter 6 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 6 (for the specific command).")]
        public  float param6;
            /// <summary>Parameter 7 (for the specific command).   </summary>
        [Units("")]
        [Description("Parameter 7 (for the specific command).")]
        public  float param7;
            /// <summary>Command ID (of command to send). MAV_CMD  </summary>
        [Units("")]
        [Description("Command ID (of command to send).")]
        public  /*MAV_CMD*/ushort command;
            /// <summary>System which should execute the command   </summary>
        [Units("")]
        [Description("System which should execute the command")]
        public  byte target_system;
            /// <summary>Component which should execute the command, 0 for all components   </summary>
        [Units("")]
        [Description("Component which should execute the command, 0 for all components")]
        public  byte target_component;
            /// <summary>0: First transmission of this command. 1-255: Confirmation transmissions (e.g. for kill command)   </summary>
        [Units("")]
        [Description("0: First transmission of this command. 1-255: Confirmation transmissions (e.g. for kill command)")]
        public  byte confirmation;
    
    };

    
    /// extensions_start 2
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=3)]
    ///<summary> Report status of a command. Includes feedback whether the command was executed. The command microservice is documented at https://mavlink.io/en/services/command.html </summary>
    public struct mavlink_command_ack_t
    {
        public mavlink_command_ack_t(/*MAV_CMD*/ushort command,/*MAV_RESULT*/byte result) 
        {
              this.command = command;
              this.result = result;
            
        }
        /// <summary>Command ID (of acknowledged command). MAV_CMD  </summary>
        [Units("")]
        [Description("Command ID (of acknowledged command).")]
        public  /*MAV_CMD*/ushort command;
            /// <summary>Result of command. MAV_RESULT  </summary>
        [Units("")]
        [Description("Result of command.")]
        public  /*MAV_RESULT*/byte result;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    ///<summary> Cancel a long running command. The target system should respond with a COMMAND_ACK to the original command with result=MAV_RESULT_CANCELLED if the long running process was cancelled. If it has already completed, the cancel action can be ignored. The cancel action can be retried until some sort of acknowledgement to the original command has been received. The command microservice is documented at https://mavlink.io/en/services/command.html </summary>
    public struct mavlink_command_cancel_t
    {
        public mavlink_command_cancel_t(/*MAV_CMD*/ushort command,byte target_system,byte target_component) 
        {
              this.command = command;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Command ID (of command to cancel). MAV_CMD  </summary>
        [Units("")]
        [Description("Command ID (of command to cancel).")]
        public  /*MAV_CMD*/ushort command;
            /// <summary>System executing long running command. Should not be broadcast (0).   </summary>
        [Units("")]
        [Description("System executing long running command. Should not be broadcast (0).")]
        public  byte target_system;
            /// <summary>Component executing long running command.   </summary>
        [Units("")]
        [Description("Component executing long running command.")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> Setpoint in roll, pitch, yaw and thrust from the operator </summary>
    public struct mavlink_manual_setpoint_t
    {
        public mavlink_manual_setpoint_t(uint time_boot_ms,float roll,float pitch,float yaw,float thrust,byte mode_switch,byte manual_override_switch) 
        {
              this.time_boot_ms = time_boot_ms;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
              this.thrust = thrust;
              this.mode_switch = mode_switch;
              this.manual_override_switch = manual_override_switch;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Desired roll rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Desired roll rate")]
        public  float roll;
            /// <summary>Desired pitch rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Desired pitch rate")]
        public  float pitch;
            /// <summary>Desired yaw rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Desired yaw rate")]
        public  float yaw;
            /// <summary>Collective thrust, normalized to 0 .. 1   </summary>
        [Units("")]
        [Description("Collective thrust, normalized to 0 .. 1")]
        public  float thrust;
            /// <summary>Flight mode switch position, 0.. 255   </summary>
        [Units("")]
        [Description("Flight mode switch position, 0.. 255")]
        public  byte mode_switch;
            /// <summary>Override mode switch position, 0.. 255   </summary>
        [Units("")]
        [Description("Override mode switch position, 0.. 255")]
        public  byte manual_override_switch;
    
    };

    
    /// extensions_start 9
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=39)]
    ///<summary> Sets a desired vehicle attitude. Used by an external controller to command the vehicle (manual controller or other system). </summary>
    public struct mavlink_set_attitude_target_t
    {
        public mavlink_set_attitude_target_t(uint time_boot_ms,float[] q,float body_roll_rate,float body_pitch_rate,float body_yaw_rate,float thrust,byte target_system,byte target_component,/*ATTITUDE_TARGET_TYPEMASK*/byte type_mask) 
        {
              this.time_boot_ms = time_boot_ms;
              this.q = q;
              this.body_roll_rate = body_roll_rate;
              this.body_pitch_rate = body_pitch_rate;
              this.body_yaw_rate = body_yaw_rate;
              this.thrust = thrust;
              this.target_system = target_system;
              this.target_component = target_component;
              this.type_mask = type_mask;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)   </summary>
        [Units("")]
        [Description("Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>Body roll rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body roll rate")]
        public  float body_roll_rate;
            /// <summary>Body pitch rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body pitch rate")]
        public  float body_pitch_rate;
            /// <summary>Body yaw rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body yaw rate")]
        public  float body_yaw_rate;
            /// <summary>Collective thrust, normalized to 0 .. 1 (-1 .. 1 for vehicles capable of reverse trust)   </summary>
        [Units("")]
        [Description("Collective thrust, normalized to 0 .. 1 (-1 .. 1 for vehicles capable of reverse trust)")]
        public  float thrust;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Bitmap to indicate which dimensions should be ignored by the vehicle. ATTITUDE_TARGET_TYPEMASK  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate which dimensions should be ignored by the vehicle.")]
        public  /*ATTITUDE_TARGET_TYPEMASK*/byte type_mask;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=37)]
    ///<summary> Reports the current commanded attitude of the vehicle as specified by the autopilot. This should match the commands sent in a SET_ATTITUDE_TARGET message if the vehicle is being controlled this way. </summary>
    public struct mavlink_attitude_target_t
    {
        public mavlink_attitude_target_t(uint time_boot_ms,float[] q,float body_roll_rate,float body_pitch_rate,float body_yaw_rate,float thrust,/*ATTITUDE_TARGET_TYPEMASK*/byte type_mask) 
        {
              this.time_boot_ms = time_boot_ms;
              this.q = q;
              this.body_roll_rate = body_roll_rate;
              this.body_pitch_rate = body_pitch_rate;
              this.body_yaw_rate = body_yaw_rate;
              this.thrust = thrust;
              this.type_mask = type_mask;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)   </summary>
        [Units("")]
        [Description("Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>Body roll rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body roll rate")]
        public  float body_roll_rate;
            /// <summary>Body pitch rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body pitch rate")]
        public  float body_pitch_rate;
            /// <summary>Body yaw rate  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body yaw rate")]
        public  float body_yaw_rate;
            /// <summary>Collective thrust, normalized to 0 .. 1 (-1 .. 1 for vehicles capable of reverse trust)   </summary>
        [Units("")]
        [Description("Collective thrust, normalized to 0 .. 1 (-1 .. 1 for vehicles capable of reverse trust)")]
        public  float thrust;
            /// <summary>Bitmap to indicate which dimensions should be ignored by the vehicle. ATTITUDE_TARGET_TYPEMASK  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate which dimensions should be ignored by the vehicle.")]
        public  /*ATTITUDE_TARGET_TYPEMASK*/byte type_mask;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=53)]
    ///<summary> Sets a desired vehicle position in a local north-east-down coordinate frame. Used by an external controller to command the vehicle (manual controller or other system). </summary>
    public struct mavlink_set_position_target_local_ned_t
    {
        public mavlink_set_position_target_local_ned_t(uint time_boot_ms,float x,float y,float z,float vx,float vy,float vz,float afx,float afy,float afz,float yaw,float yaw_rate,/*POSITION_TARGET_TYPEMASK*/ushort type_mask,byte target_system,byte target_component,/*MAV_FRAME*/byte coordinate_frame) 
        {
              this.time_boot_ms = time_boot_ms;
              this.x = x;
              this.y = y;
              this.z = z;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.afx = afx;
              this.afy = afy;
              this.afz = afz;
              this.yaw = yaw;
              this.yaw_rate = yaw_rate;
              this.type_mask = type_mask;
              this.target_system = target_system;
              this.target_component = target_component;
              this.coordinate_frame = coordinate_frame;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X Position in NED frame  [m] </summary>
        [Units("[m]")]
        [Description("X Position in NED frame")]
        public  float x;
            /// <summary>Y Position in NED frame  [m] </summary>
        [Units("[m]")]
        [Description("Y Position in NED frame")]
        public  float y;
            /// <summary>Z Position in NED frame (note, altitude is negative in NED)  [m] </summary>
        [Units("[m]")]
        [Description("Z Position in NED frame (note, altitude is negative in NED)")]
        public  float z;
            /// <summary>X velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X velocity in NED frame")]
        public  float vx;
            /// <summary>Y velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y velocity in NED frame")]
        public  float vy;
            /// <summary>Z velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z velocity in NED frame")]
        public  float vz;
            /// <summary>X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afx;
            /// <summary>Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afy;
            /// <summary>Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afz;
            /// <summary>yaw setpoint  [rad] </summary>
        [Units("[rad]")]
        [Description("yaw setpoint")]
        public  float yaw;
            /// <summary>yaw rate setpoint  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("yaw rate setpoint")]
        public  float yaw_rate;
            /// <summary>Bitmap to indicate which dimensions should be ignored by the vehicle. POSITION_TARGET_TYPEMASK  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate which dimensions should be ignored by the vehicle.")]
        public  /*POSITION_TARGET_TYPEMASK*/ushort type_mask;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_FRAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9 MAV_FRAME  </summary>
        [Units("")]
        [Description("Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_FRAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9")]
        public  /*MAV_FRAME*/byte coordinate_frame;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=51)]
    ///<summary> Reports the current commanded vehicle position, velocity, and acceleration as specified by the autopilot. This should match the commands sent in SET_POSITION_TARGET_LOCAL_NED if the vehicle is being controlled this way. </summary>
    public struct mavlink_position_target_local_ned_t
    {
        public mavlink_position_target_local_ned_t(uint time_boot_ms,float x,float y,float z,float vx,float vy,float vz,float afx,float afy,float afz,float yaw,float yaw_rate,/*POSITION_TARGET_TYPEMASK*/ushort type_mask,/*MAV_FRAME*/byte coordinate_frame) 
        {
              this.time_boot_ms = time_boot_ms;
              this.x = x;
              this.y = y;
              this.z = z;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.afx = afx;
              this.afy = afy;
              this.afz = afz;
              this.yaw = yaw;
              this.yaw_rate = yaw_rate;
              this.type_mask = type_mask;
              this.coordinate_frame = coordinate_frame;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X Position in NED frame  [m] </summary>
        [Units("[m]")]
        [Description("X Position in NED frame")]
        public  float x;
            /// <summary>Y Position in NED frame  [m] </summary>
        [Units("[m]")]
        [Description("Y Position in NED frame")]
        public  float y;
            /// <summary>Z Position in NED frame (note, altitude is negative in NED)  [m] </summary>
        [Units("[m]")]
        [Description("Z Position in NED frame (note, altitude is negative in NED)")]
        public  float z;
            /// <summary>X velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X velocity in NED frame")]
        public  float vx;
            /// <summary>Y velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y velocity in NED frame")]
        public  float vy;
            /// <summary>Z velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z velocity in NED frame")]
        public  float vz;
            /// <summary>X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afx;
            /// <summary>Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afy;
            /// <summary>Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afz;
            /// <summary>yaw setpoint  [rad] </summary>
        [Units("[rad]")]
        [Description("yaw setpoint")]
        public  float yaw;
            /// <summary>yaw rate setpoint  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("yaw rate setpoint")]
        public  float yaw_rate;
            /// <summary>Bitmap to indicate which dimensions should be ignored by the vehicle. POSITION_TARGET_TYPEMASK  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate which dimensions should be ignored by the vehicle.")]
        public  /*POSITION_TARGET_TYPEMASK*/ushort type_mask;
            /// <summary>Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_FRAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9 MAV_FRAME  </summary>
        [Units("")]
        [Description("Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_FRAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9")]
        public  /*MAV_FRAME*/byte coordinate_frame;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=53)]
    ///<summary> Sets a desired vehicle position, velocity, and/or acceleration in a global coordinate system (WGS84). Used by an external controller to command the vehicle (manual controller or other system). </summary>
    public struct mavlink_set_position_target_global_int_t
    {
        public mavlink_set_position_target_global_int_t(uint time_boot_ms,int lat_int,int lon_int,float alt,float vx,float vy,float vz,float afx,float afy,float afz,float yaw,float yaw_rate,/*POSITION_TARGET_TYPEMASK*/ushort type_mask,byte target_system,byte target_component,/*MAV_FRAME*/byte coordinate_frame) 
        {
              this.time_boot_ms = time_boot_ms;
              this.lat_int = lat_int;
              this.lon_int = lon_int;
              this.alt = alt;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.afx = afx;
              this.afy = afy;
              this.afz = afz;
              this.yaw = yaw;
              this.yaw_rate = yaw_rate;
              this.type_mask = type_mask;
              this.target_system = target_system;
              this.target_component = target_component;
              this.coordinate_frame = coordinate_frame;
            
        }
        /// <summary>Timestamp (time since system boot). The rationale for the timestamp in the setpoint is to allow the system to compensate for the transport delay of the setpoint. This allows the system to compensate processing latency.  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot). The rationale for the timestamp in the setpoint is to allow the system to compensate for the transport delay of the setpoint. This allows the system to compensate processing latency.")]
        public  uint time_boot_ms;
            /// <summary>X Position in WGS84 frame  [degE7] </summary>
        [Units("[degE7]")]
        [Description("X Position in WGS84 frame")]
        public  int lat_int;
            /// <summary>Y Position in WGS84 frame  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Y Position in WGS84 frame")]
        public  int lon_int;
            /// <summary>Altitude (MSL, Relative to home, or AGL - depending on frame)  [m] </summary>
        [Units("[m]")]
        [Description("Altitude (MSL, Relative to home, or AGL - depending on frame)")]
        public  float alt;
            /// <summary>X velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X velocity in NED frame")]
        public  float vx;
            /// <summary>Y velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y velocity in NED frame")]
        public  float vy;
            /// <summary>Z velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z velocity in NED frame")]
        public  float vz;
            /// <summary>X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afx;
            /// <summary>Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afy;
            /// <summary>Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afz;
            /// <summary>yaw setpoint  [rad] </summary>
        [Units("[rad]")]
        [Description("yaw setpoint")]
        public  float yaw;
            /// <summary>yaw rate setpoint  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("yaw rate setpoint")]
        public  float yaw_rate;
            /// <summary>Bitmap to indicate which dimensions should be ignored by the vehicle. POSITION_TARGET_TYPEMASK  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate which dimensions should be ignored by the vehicle.")]
        public  /*POSITION_TARGET_TYPEMASK*/ushort type_mask;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = 6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11 MAV_FRAME  </summary>
        [Units("")]
        [Description("Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = 6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11")]
        public  /*MAV_FRAME*/byte coordinate_frame;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=51)]
    ///<summary> Reports the current commanded vehicle position, velocity, and acceleration as specified by the autopilot. This should match the commands sent in SET_POSITION_TARGET_GLOBAL_INT if the vehicle is being controlled this way. </summary>
    public struct mavlink_position_target_global_int_t
    {
        public mavlink_position_target_global_int_t(uint time_boot_ms,int lat_int,int lon_int,float alt,float vx,float vy,float vz,float afx,float afy,float afz,float yaw,float yaw_rate,/*POSITION_TARGET_TYPEMASK*/ushort type_mask,/*MAV_FRAME*/byte coordinate_frame) 
        {
              this.time_boot_ms = time_boot_ms;
              this.lat_int = lat_int;
              this.lon_int = lon_int;
              this.alt = alt;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.afx = afx;
              this.afy = afy;
              this.afz = afz;
              this.yaw = yaw;
              this.yaw_rate = yaw_rate;
              this.type_mask = type_mask;
              this.coordinate_frame = coordinate_frame;
            
        }
        /// <summary>Timestamp (time since system boot). The rationale for the timestamp in the setpoint is to allow the system to compensate for the transport delay of the setpoint. This allows the system to compensate processing latency.  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot). The rationale for the timestamp in the setpoint is to allow the system to compensate for the transport delay of the setpoint. This allows the system to compensate processing latency.")]
        public  uint time_boot_ms;
            /// <summary>X Position in WGS84 frame  [degE7] </summary>
        [Units("[degE7]")]
        [Description("X Position in WGS84 frame")]
        public  int lat_int;
            /// <summary>Y Position in WGS84 frame  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Y Position in WGS84 frame")]
        public  int lon_int;
            /// <summary>Altitude (MSL, AGL or relative to home altitude, depending on frame)  [m] </summary>
        [Units("[m]")]
        [Description("Altitude (MSL, AGL or relative to home altitude, depending on frame)")]
        public  float alt;
            /// <summary>X velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X velocity in NED frame")]
        public  float vx;
            /// <summary>Y velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y velocity in NED frame")]
        public  float vy;
            /// <summary>Z velocity in NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z velocity in NED frame")]
        public  float vz;
            /// <summary>X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afx;
            /// <summary>Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afy;
            /// <summary>Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N")]
        public  float afz;
            /// <summary>yaw setpoint  [rad] </summary>
        [Units("[rad]")]
        [Description("yaw setpoint")]
        public  float yaw;
            /// <summary>yaw rate setpoint  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("yaw rate setpoint")]
        public  float yaw_rate;
            /// <summary>Bitmap to indicate which dimensions should be ignored by the vehicle. POSITION_TARGET_TYPEMASK  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate which dimensions should be ignored by the vehicle.")]
        public  /*POSITION_TARGET_TYPEMASK*/ushort type_mask;
            /// <summary>Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = 6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11 MAV_FRAME  </summary>
        [Units("")]
        [Description("Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = 6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11")]
        public  /*MAV_FRAME*/byte coordinate_frame;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=28)]
    ///<summary> The offset in X, Y, Z and yaw between the LOCAL_POSITION_NED messages of MAV X and the global coordinate frame in NED coordinates. Coordinate frame is right-handed, Z-axis down (aeronautical frame, NED / north-east-down convention) </summary>
    public struct mavlink_local_position_ned_system_global_offset_t
    {
        public mavlink_local_position_ned_system_global_offset_t(uint time_boot_ms,float x,float y,float z,float roll,float pitch,float yaw) 
        {
              this.time_boot_ms = time_boot_ms;
              this.x = x;
              this.y = y;
              this.z = z;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X Position  [m] </summary>
        [Units("[m]")]
        [Description("X Position")]
        public  float x;
            /// <summary>Y Position  [m] </summary>
        [Units("[m]")]
        [Description("Y Position")]
        public  float y;
            /// <summary>Z Position  [m] </summary>
        [Units("[m]")]
        [Description("Z Position")]
        public  float z;
            /// <summary>Roll  [rad] </summary>
        [Units("[rad]")]
        [Description("Roll")]
        public  float roll;
            /// <summary>Pitch  [rad] </summary>
        [Units("[rad]")]
        [Description("Pitch")]
        public  float pitch;
            /// <summary>Yaw  [rad] </summary>
        [Units("[rad]")]
        [Description("Yaw")]
        public  float yaw;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=56)]
    ///<summary> Sent from simulation to autopilot. This packet is useful for high throughput applications such as hardware in the loop simulations. </summary>
    public struct mavlink_hil_state_t
    {
        public mavlink_hil_state_t(ulong time_usec,float roll,float pitch,float yaw,float rollspeed,float pitchspeed,float yawspeed,int lat,int lon,int alt,short vx,short vy,short vz,short xacc,short yacc,short zacc) 
        {
              this.time_usec = time_usec;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
              this.rollspeed = rollspeed;
              this.pitchspeed = pitchspeed;
              this.yawspeed = yawspeed;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Roll angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Roll angle")]
        public  float roll;
            /// <summary>Pitch angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Pitch angle")]
        public  float pitch;
            /// <summary>Yaw angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Yaw angle")]
        public  float yaw;
            /// <summary>Body frame roll / phi angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body frame roll / phi angular speed")]
        public  float rollspeed;
            /// <summary>Body frame pitch / theta angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body frame pitch / theta angular speed")]
        public  float pitchspeed;
            /// <summary>Body frame yaw / psi angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body frame yaw / psi angular speed")]
        public  float yawspeed;
            /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int lat;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int lon;
            /// <summary>Altitude  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude")]
        public  int alt;
            /// <summary>Ground X Speed (Latitude)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground X Speed (Latitude)")]
        public  short vx;
            /// <summary>Ground Y Speed (Longitude)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground Y Speed (Longitude)")]
        public  short vy;
            /// <summary>Ground Z Speed (Altitude)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground Z Speed (Altitude)")]
        public  short vz;
            /// <summary>X acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("X acceleration")]
        public  short xacc;
            /// <summary>Y acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Y acceleration")]
        public  short yacc;
            /// <summary>Z acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Z acceleration")]
        public  short zacc;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=42)]
    ///<summary> Sent from autopilot to simulation. Hardware in the loop control outputs </summary>
    public struct mavlink_hil_controls_t
    {
        public mavlink_hil_controls_t(ulong time_usec,float roll_ailerons,float pitch_elevator,float yaw_rudder,float throttle,float aux1,float aux2,float aux3,float aux4,/*MAV_MODE*/byte mode,byte nav_mode) 
        {
              this.time_usec = time_usec;
              this.roll_ailerons = roll_ailerons;
              this.pitch_elevator = pitch_elevator;
              this.yaw_rudder = yaw_rudder;
              this.throttle = throttle;
              this.aux1 = aux1;
              this.aux2 = aux2;
              this.aux3 = aux3;
              this.aux4 = aux4;
              this.mode = mode;
              this.nav_mode = nav_mode;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Control output -1 .. 1   </summary>
        [Units("")]
        [Description("Control output -1 .. 1")]
        public  float roll_ailerons;
            /// <summary>Control output -1 .. 1   </summary>
        [Units("")]
        [Description("Control output -1 .. 1")]
        public  float pitch_elevator;
            /// <summary>Control output -1 .. 1   </summary>
        [Units("")]
        [Description("Control output -1 .. 1")]
        public  float yaw_rudder;
            /// <summary>Throttle 0 .. 1   </summary>
        [Units("")]
        [Description("Throttle 0 .. 1")]
        public  float throttle;
            /// <summary>Aux 1, -1 .. 1   </summary>
        [Units("")]
        [Description("Aux 1, -1 .. 1")]
        public  float aux1;
            /// <summary>Aux 2, -1 .. 1   </summary>
        [Units("")]
        [Description("Aux 2, -1 .. 1")]
        public  float aux2;
            /// <summary>Aux 3, -1 .. 1   </summary>
        [Units("")]
        [Description("Aux 3, -1 .. 1")]
        public  float aux3;
            /// <summary>Aux 4, -1 .. 1   </summary>
        [Units("")]
        [Description("Aux 4, -1 .. 1")]
        public  float aux4;
            /// <summary>System mode. MAV_MODE  </summary>
        [Units("")]
        [Description("System mode.")]
        public  /*MAV_MODE*/byte mode;
            /// <summary>Navigation mode (MAV_NAV_MODE)   </summary>
        [Units("")]
        [Description("Navigation mode (MAV_NAV_MODE)")]
        public  byte nav_mode;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=33)]
    ///<summary> Sent from simulation to autopilot. The RAW values of the RC channels received. The standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microseconds: 100%. Individual receivers/transmitters might violate this specification. </summary>
    public struct mavlink_hil_rc_inputs_raw_t
    {
        public mavlink_hil_rc_inputs_raw_t(ulong time_usec,ushort chan1_raw,ushort chan2_raw,ushort chan3_raw,ushort chan4_raw,ushort chan5_raw,ushort chan6_raw,ushort chan7_raw,ushort chan8_raw,ushort chan9_raw,ushort chan10_raw,ushort chan11_raw,ushort chan12_raw,byte rssi) 
        {
              this.time_usec = time_usec;
              this.chan1_raw = chan1_raw;
              this.chan2_raw = chan2_raw;
              this.chan3_raw = chan3_raw;
              this.chan4_raw = chan4_raw;
              this.chan5_raw = chan5_raw;
              this.chan6_raw = chan6_raw;
              this.chan7_raw = chan7_raw;
              this.chan8_raw = chan8_raw;
              this.chan9_raw = chan9_raw;
              this.chan10_raw = chan10_raw;
              this.chan11_raw = chan11_raw;
              this.chan12_raw = chan12_raw;
              this.rssi = rssi;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>RC channel 1 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 1 value")]
        public  ushort chan1_raw;
            /// <summary>RC channel 2 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 2 value")]
        public  ushort chan2_raw;
            /// <summary>RC channel 3 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 3 value")]
        public  ushort chan3_raw;
            /// <summary>RC channel 4 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 4 value")]
        public  ushort chan4_raw;
            /// <summary>RC channel 5 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 5 value")]
        public  ushort chan5_raw;
            /// <summary>RC channel 6 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 6 value")]
        public  ushort chan6_raw;
            /// <summary>RC channel 7 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 7 value")]
        public  ushort chan7_raw;
            /// <summary>RC channel 8 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 8 value")]
        public  ushort chan8_raw;
            /// <summary>RC channel 9 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 9 value")]
        public  ushort chan9_raw;
            /// <summary>RC channel 10 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 10 value")]
        public  ushort chan10_raw;
            /// <summary>RC channel 11 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 11 value")]
        public  ushort chan11_raw;
            /// <summary>RC channel 12 value  [us] </summary>
        [Units("[us]")]
        [Description("RC channel 12 value")]
        public  ushort chan12_raw;
            /// <summary>Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Receive signal strength indicator in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte rssi;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=81)]
    ///<summary> Sent from autopilot to simulation. Hardware in the loop control outputs (replacement for HIL_CONTROLS) </summary>
    public struct mavlink_hil_actuator_controls_t
    {
        public mavlink_hil_actuator_controls_t(ulong time_usec,ulong flags,float[] controls,/*MAV_MODE_FLAG*/byte mode) 
        {
              this.time_usec = time_usec;
              this.flags = flags;
              this.controls = controls;
              this.mode = mode;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Flags as bitfield, 1: indicate simulation using lockstep.   bitmask</summary>
        [Units("")]
        [Description("Flags as bitfield, 1: indicate simulation using lockstep.")]
        public  ulong flags;
            /// <summary>Control outputs -1 .. 1. Channel assignment depends on the simulated hardware.   </summary>
        [Units("")]
        [Description("Control outputs -1 .. 1. Channel assignment depends on the simulated hardware.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=16)]
		public float[] controls;
            /// <summary>System mode. Includes arming state. MAV_MODE_FLAG  bitmask</summary>
        [Units("")]
        [Description("System mode. Includes arming state.")]
        public  /*MAV_MODE_FLAG*/byte mode;
    
    };

    
    /// extensions_start 8
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=26)]
    ///<summary> Optical flow from a flow sensor (e.g. optical mouse sensor) </summary>
    public struct mavlink_optical_flow_t
    {
        public mavlink_optical_flow_t(ulong time_usec,float flow_comp_m_x,float flow_comp_m_y,float ground_distance,short flow_x,short flow_y,byte sensor_id,byte quality) 
        {
              this.time_usec = time_usec;
              this.flow_comp_m_x = flow_comp_m_x;
              this.flow_comp_m_y = flow_comp_m_y;
              this.ground_distance = ground_distance;
              this.flow_x = flow_x;
              this.flow_y = flow_y;
              this.sensor_id = sensor_id;
              this.quality = quality;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Flow in x-sensor direction, angular-speed compensated  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Flow in x-sensor direction, angular-speed compensated")]
        public  float flow_comp_m_x;
            /// <summary>Flow in y-sensor direction, angular-speed compensated  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Flow in y-sensor direction, angular-speed compensated")]
        public  float flow_comp_m_y;
            /// <summary>Ground distance. Positive value: distance known. Negative value: Unknown distance  [m] </summary>
        [Units("[m]")]
        [Description("Ground distance. Positive value: distance known. Negative value: Unknown distance")]
        public  float ground_distance;
            /// <summary>Flow in x-sensor direction  [dpix] </summary>
        [Units("[dpix]")]
        [Description("Flow in x-sensor direction")]
        public  short flow_x;
            /// <summary>Flow in y-sensor direction  [dpix] </summary>
        [Units("[dpix]")]
        [Description("Flow in y-sensor direction")]
        public  short flow_y;
            /// <summary>Sensor ID   </summary>
        [Units("")]
        [Description("Sensor ID")]
        public  byte sensor_id;
            /// <summary>Optical flow quality / confidence. 0: bad, 255: maximum quality   </summary>
        [Units("")]
        [Description("Optical flow quality / confidence. 0: bad, 255: maximum quality")]
        public  byte quality;
    
    };

    
    /// extensions_start 7
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> Global position/attitude estimate from a vision source. </summary>
    public struct mavlink_global_vision_position_estimate_t
    {
        public mavlink_global_vision_position_estimate_t(ulong usec,float x,float y,float z,float roll,float pitch,float yaw) 
        {
              this.usec = usec;
              this.x = x;
              this.y = y;
              this.z = z;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
            
        }
        /// <summary>Timestamp (UNIX time or since system boot)  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX time or since system boot)")]
        public  ulong usec;
            /// <summary>Global X position  [m] </summary>
        [Units("[m]")]
        [Description("Global X position")]
        public  float x;
            /// <summary>Global Y position  [m] </summary>
        [Units("[m]")]
        [Description("Global Y position")]
        public  float y;
            /// <summary>Global Z position  [m] </summary>
        [Units("[m]")]
        [Description("Global Z position")]
        public  float z;
            /// <summary>Roll angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Roll angle")]
        public  float roll;
            /// <summary>Pitch angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Pitch angle")]
        public  float pitch;
            /// <summary>Yaw angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Yaw angle")]
        public  float yaw;
    
    };

    
    /// extensions_start 7
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> Local position/attitude estimate from a vision source. </summary>
    public struct mavlink_vision_position_estimate_t
    {
        public mavlink_vision_position_estimate_t(ulong usec,float x,float y,float z,float roll,float pitch,float yaw) 
        {
              this.usec = usec;
              this.x = x;
              this.y = y;
              this.z = z;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
            
        }
        /// <summary>Timestamp (UNIX time or time since system boot)  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX time or time since system boot)")]
        public  ulong usec;
            /// <summary>Local X position  [m] </summary>
        [Units("[m]")]
        [Description("Local X position")]
        public  float x;
            /// <summary>Local Y position  [m] </summary>
        [Units("[m]")]
        [Description("Local Y position")]
        public  float y;
            /// <summary>Local Z position  [m] </summary>
        [Units("[m]")]
        [Description("Local Z position")]
        public  float z;
            /// <summary>Roll angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Roll angle")]
        public  float roll;
            /// <summary>Pitch angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Pitch angle")]
        public  float pitch;
            /// <summary>Yaw angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Yaw angle")]
        public  float yaw;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=20)]
    ///<summary> Speed estimate from a vision source. </summary>
    public struct mavlink_vision_speed_estimate_t
    {
        public mavlink_vision_speed_estimate_t(ulong usec,float x,float y,float z) 
        {
              this.usec = usec;
              this.x = x;
              this.y = y;
              this.z = z;
            
        }
        /// <summary>Timestamp (UNIX time or time since system boot)  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX time or time since system boot)")]
        public  ulong usec;
            /// <summary>Global X speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Global X speed")]
        public  float x;
            /// <summary>Global Y speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Global Y speed")]
        public  float y;
            /// <summary>Global Z speed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Global Z speed")]
        public  float z;
    
    };

    
    /// extensions_start 7
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> Global position estimate from a Vicon motion system source. </summary>
    public struct mavlink_vicon_position_estimate_t
    {
        public mavlink_vicon_position_estimate_t(ulong usec,float x,float y,float z,float roll,float pitch,float yaw) 
        {
              this.usec = usec;
              this.x = x;
              this.y = y;
              this.z = z;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
            
        }
        /// <summary>Timestamp (UNIX time or time since system boot)  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX time or time since system boot)")]
        public  ulong usec;
            /// <summary>Global X position  [m] </summary>
        [Units("[m]")]
        [Description("Global X position")]
        public  float x;
            /// <summary>Global Y position  [m] </summary>
        [Units("[m]")]
        [Description("Global Y position")]
        public  float y;
            /// <summary>Global Z position  [m] </summary>
        [Units("[m]")]
        [Description("Global Z position")]
        public  float z;
            /// <summary>Roll angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Roll angle")]
        public  float roll;
            /// <summary>Pitch angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Pitch angle")]
        public  float pitch;
            /// <summary>Yaw angle  [rad] </summary>
        [Units("[rad]")]
        [Description("Yaw angle")]
        public  float yaw;
    
    };

    
    /// extensions_start 15
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=62)]
    ///<summary> The IMU readings in SI units in NED body frame </summary>
    public struct mavlink_highres_imu_t
    {
        public mavlink_highres_imu_t(ulong time_usec,float xacc,float yacc,float zacc,float xgyro,float ygyro,float zgyro,float xmag,float ymag,float zmag,float abs_pressure,float diff_pressure,float pressure_alt,float temperature,/*HIGHRES_IMU_UPDATED_FLAGS*/ushort fields_updated) 
        {
              this.time_usec = time_usec;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.xmag = xmag;
              this.ymag = ymag;
              this.zmag = zmag;
              this.abs_pressure = abs_pressure;
              this.diff_pressure = diff_pressure;
              this.pressure_alt = pressure_alt;
              this.temperature = temperature;
              this.fields_updated = fields_updated;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>X acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration")]
        public  float xacc;
            /// <summary>Y acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration")]
        public  float yacc;
            /// <summary>Z acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration")]
        public  float zacc;
            /// <summary>Angular speed around X axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around X axis")]
        public  float xgyro;
            /// <summary>Angular speed around Y axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around Y axis")]
        public  float ygyro;
            /// <summary>Angular speed around Z axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around Z axis")]
        public  float zgyro;
            /// <summary>X Magnetic field  [gauss] </summary>
        [Units("[gauss]")]
        [Description("X Magnetic field")]
        public  float xmag;
            /// <summary>Y Magnetic field  [gauss] </summary>
        [Units("[gauss]")]
        [Description("Y Magnetic field")]
        public  float ymag;
            /// <summary>Z Magnetic field  [gauss] </summary>
        [Units("[gauss]")]
        [Description("Z Magnetic field")]
        public  float zmag;
            /// <summary>Absolute pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Absolute pressure")]
        public  float abs_pressure;
            /// <summary>Differential pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Differential pressure")]
        public  float diff_pressure;
            /// <summary>Altitude calculated from pressure   </summary>
        [Units("")]
        [Description("Altitude calculated from pressure")]
        public  float pressure_alt;
            /// <summary>Temperature  [degC] </summary>
        [Units("[degC]")]
        [Description("Temperature")]
        public  float temperature;
            /// <summary>Bitmap for fields that have updated since last message HIGHRES_IMU_UPDATED_FLAGS  bitmask</summary>
        [Units("")]
        [Description("Bitmap for fields that have updated since last message")]
        public  /*HIGHRES_IMU_UPDATED_FLAGS*/ushort fields_updated;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=44)]
    ///<summary> Optical flow from an angular rate flow sensor (e.g. PX4FLOW or mouse sensor) </summary>
    public struct mavlink_optical_flow_rad_t
    {
        public mavlink_optical_flow_rad_t(ulong time_usec,uint integration_time_us,float integrated_x,float integrated_y,float integrated_xgyro,float integrated_ygyro,float integrated_zgyro,uint time_delta_distance_us,float distance,short temperature,byte sensor_id,byte quality) 
        {
              this.time_usec = time_usec;
              this.integration_time_us = integration_time_us;
              this.integrated_x = integrated_x;
              this.integrated_y = integrated_y;
              this.integrated_xgyro = integrated_xgyro;
              this.integrated_ygyro = integrated_ygyro;
              this.integrated_zgyro = integrated_zgyro;
              this.time_delta_distance_us = time_delta_distance_us;
              this.distance = distance;
              this.temperature = temperature;
              this.sensor_id = sensor_id;
              this.quality = quality;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Integration time. Divide integrated_x and integrated_y by the integration time to obtain average flow. The integration time also indicates the.  [us] </summary>
        [Units("[us]")]
        [Description("Integration time. Divide integrated_x and integrated_y by the integration time to obtain average flow. The integration time also indicates the.")]
        public  uint integration_time_us;
            /// <summary>Flow around X axis (Sensor RH rotation about the X axis induces a positive flow. Sensor linear motion along the positive Y axis induces a negative flow.)  [rad] </summary>
        [Units("[rad]")]
        [Description("Flow around X axis (Sensor RH rotation about the X axis induces a positive flow. Sensor linear motion along the positive Y axis induces a negative flow.)")]
        public  float integrated_x;
            /// <summary>Flow around Y axis (Sensor RH rotation about the Y axis induces a positive flow. Sensor linear motion along the positive X axis induces a positive flow.)  [rad] </summary>
        [Units("[rad]")]
        [Description("Flow around Y axis (Sensor RH rotation about the Y axis induces a positive flow. Sensor linear motion along the positive X axis induces a positive flow.)")]
        public  float integrated_y;
            /// <summary>RH rotation around X axis  [rad] </summary>
        [Units("[rad]")]
        [Description("RH rotation around X axis")]
        public  float integrated_xgyro;
            /// <summary>RH rotation around Y axis  [rad] </summary>
        [Units("[rad]")]
        [Description("RH rotation around Y axis")]
        public  float integrated_ygyro;
            /// <summary>RH rotation around Z axis  [rad] </summary>
        [Units("[rad]")]
        [Description("RH rotation around Z axis")]
        public  float integrated_zgyro;
            /// <summary>Time since the distance was sampled.  [us] </summary>
        [Units("[us]")]
        [Description("Time since the distance was sampled.")]
        public  uint time_delta_distance_us;
            /// <summary>Distance to the center of the flow field. Positive value (including zero): distance known. Negative value: Unknown distance.  [m] </summary>
        [Units("[m]")]
        [Description("Distance to the center of the flow field. Positive value (including zero): distance known. Negative value: Unknown distance.")]
        public  float distance;
            /// <summary>Temperature  [cdegC] </summary>
        [Units("[cdegC]")]
        [Description("Temperature")]
        public  short temperature;
            /// <summary>Sensor ID   </summary>
        [Units("")]
        [Description("Sensor ID")]
        public  byte sensor_id;
            /// <summary>Optical flow quality / confidence. 0: no valid flow, 255: maximum quality   </summary>
        [Units("")]
        [Description("Optical flow quality / confidence. 0: no valid flow, 255: maximum quality")]
        public  byte quality;
    
    };

    
    /// extensions_start 15
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=64)]
    ///<summary> The IMU readings in SI units in NED body frame </summary>
    public struct mavlink_hil_sensor_t
    {
        public mavlink_hil_sensor_t(ulong time_usec,float xacc,float yacc,float zacc,float xgyro,float ygyro,float zgyro,float xmag,float ymag,float zmag,float abs_pressure,float diff_pressure,float pressure_alt,float temperature,/*HIL_SENSOR_UPDATED_FLAGS*/uint fields_updated) 
        {
              this.time_usec = time_usec;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.xmag = xmag;
              this.ymag = ymag;
              this.zmag = zmag;
              this.abs_pressure = abs_pressure;
              this.diff_pressure = diff_pressure;
              this.pressure_alt = pressure_alt;
              this.temperature = temperature;
              this.fields_updated = fields_updated;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>X acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration")]
        public  float xacc;
            /// <summary>Y acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration")]
        public  float yacc;
            /// <summary>Z acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration")]
        public  float zacc;
            /// <summary>Angular speed around X axis in body frame  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around X axis in body frame")]
        public  float xgyro;
            /// <summary>Angular speed around Y axis in body frame  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around Y axis in body frame")]
        public  float ygyro;
            /// <summary>Angular speed around Z axis in body frame  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around Z axis in body frame")]
        public  float zgyro;
            /// <summary>X Magnetic field  [gauss] </summary>
        [Units("[gauss]")]
        [Description("X Magnetic field")]
        public  float xmag;
            /// <summary>Y Magnetic field  [gauss] </summary>
        [Units("[gauss]")]
        [Description("Y Magnetic field")]
        public  float ymag;
            /// <summary>Z Magnetic field  [gauss] </summary>
        [Units("[gauss]")]
        [Description("Z Magnetic field")]
        public  float zmag;
            /// <summary>Absolute pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Absolute pressure")]
        public  float abs_pressure;
            /// <summary>Differential pressure (airspeed)  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Differential pressure (airspeed)")]
        public  float diff_pressure;
            /// <summary>Altitude calculated from pressure   </summary>
        [Units("")]
        [Description("Altitude calculated from pressure")]
        public  float pressure_alt;
            /// <summary>Temperature  [degC] </summary>
        [Units("[degC]")]
        [Description("Temperature")]
        public  float temperature;
            /// <summary>Bitmap for fields that have updated since last message HIL_SENSOR_UPDATED_FLAGS  bitmask</summary>
        [Units("")]
        [Description("Bitmap for fields that have updated since last message")]
        public  /*HIL_SENSOR_UPDATED_FLAGS*/uint fields_updated;
    
    };

    
    /// extensions_start 21
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=84)]
    ///<summary> Status of simulation environment, if used </summary>
    public struct mavlink_sim_state_t
    {
        public mavlink_sim_state_t(float q1,float q2,float q3,float q4,float roll,float pitch,float yaw,float xacc,float yacc,float zacc,float xgyro,float ygyro,float zgyro,float lat,float lon,float alt,float std_dev_horz,float std_dev_vert,float vn,float ve,float vd) 
        {
              this.q1 = q1;
              this.q2 = q2;
              this.q3 = q3;
              this.q4 = q4;
              this.roll = roll;
              this.pitch = pitch;
              this.yaw = yaw;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.std_dev_horz = std_dev_horz;
              this.std_dev_vert = std_dev_vert;
              this.vn = vn;
              this.ve = ve;
              this.vd = vd;
            
        }
        /// <summary>True attitude quaternion component 1, w (1 in null-rotation)   </summary>
        [Units("")]
        [Description("True attitude quaternion component 1, w (1 in null-rotation)")]
        public  float q1;
            /// <summary>True attitude quaternion component 2, x (0 in null-rotation)   </summary>
        [Units("")]
        [Description("True attitude quaternion component 2, x (0 in null-rotation)")]
        public  float q2;
            /// <summary>True attitude quaternion component 3, y (0 in null-rotation)   </summary>
        [Units("")]
        [Description("True attitude quaternion component 3, y (0 in null-rotation)")]
        public  float q3;
            /// <summary>True attitude quaternion component 4, z (0 in null-rotation)   </summary>
        [Units("")]
        [Description("True attitude quaternion component 4, z (0 in null-rotation)")]
        public  float q4;
            /// <summary>Attitude roll expressed as Euler angles, not recommended except for human-readable outputs   </summary>
        [Units("")]
        [Description("Attitude roll expressed as Euler angles, not recommended except for human-readable outputs")]
        public  float roll;
            /// <summary>Attitude pitch expressed as Euler angles, not recommended except for human-readable outputs   </summary>
        [Units("")]
        [Description("Attitude pitch expressed as Euler angles, not recommended except for human-readable outputs")]
        public  float pitch;
            /// <summary>Attitude yaw expressed as Euler angles, not recommended except for human-readable outputs   </summary>
        [Units("")]
        [Description("Attitude yaw expressed as Euler angles, not recommended except for human-readable outputs")]
        public  float yaw;
            /// <summary>X acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration")]
        public  float xacc;
            /// <summary>Y acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration")]
        public  float yacc;
            /// <summary>Z acceleration  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration")]
        public  float zacc;
            /// <summary>Angular speed around X axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around X axis")]
        public  float xgyro;
            /// <summary>Angular speed around Y axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around Y axis")]
        public  float ygyro;
            /// <summary>Angular speed around Z axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular speed around Z axis")]
        public  float zgyro;
            /// <summary>Latitude (lower precision). Both this and the lat_int field should be set.  [deg] </summary>
        [Units("[deg]")]
        [Description("Latitude (lower precision). Both this and the lat_int field should be set.")]
        public  float lat;
            /// <summary>Longitude (lower precision). Both this and the lon_int field should be set.  [deg] </summary>
        [Units("[deg]")]
        [Description("Longitude (lower precision). Both this and the lon_int field should be set.")]
        public  float lon;
            /// <summary>Altitude  [m] </summary>
        [Units("[m]")]
        [Description("Altitude")]
        public  float alt;
            /// <summary>Horizontal position standard deviation   </summary>
        [Units("")]
        [Description("Horizontal position standard deviation")]
        public  float std_dev_horz;
            /// <summary>Vertical position standard deviation   </summary>
        [Units("")]
        [Description("Vertical position standard deviation")]
        public  float std_dev_vert;
            /// <summary>True velocity in north direction in earth-fixed NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("True velocity in north direction in earth-fixed NED frame")]
        public  float vn;
            /// <summary>True velocity in east direction in earth-fixed NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("True velocity in east direction in earth-fixed NED frame")]
        public  float ve;
            /// <summary>True velocity in down direction in earth-fixed NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("True velocity in down direction in earth-fixed NED frame")]
        public  float vd;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=9)]
    ///<summary> Status generated by radio and injected into MAVLink stream. </summary>
    public struct mavlink_radio_status_t
    {
        public mavlink_radio_status_t(ushort rxerrors,ushort @fixed,byte rssi,byte remrssi,byte txbuf,byte noise,byte remnoise) 
        {
              this.rxerrors = rxerrors;
              this.@fixed = @fixed;
              this.rssi = rssi;
              this.remrssi = remrssi;
              this.txbuf = txbuf;
              this.noise = noise;
              this.remnoise = remnoise;
            
        }
        /// <summary>Count of radio packet receive errors (since boot).   </summary>
        [Units("")]
        [Description("Count of radio packet receive errors (since boot).")]
        public  ushort rxerrors;
            /// <summary>Count of error corrected radio packets (since boot).   </summary>
        [Units("")]
        [Description("Count of error corrected radio packets (since boot).")]
        public  ushort @fixed;
            /// <summary>Local (message sender) received signal strength indication in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Local (message sender) received signal strength indication in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte rssi;
            /// <summary>Remote (message receiver) signal strength indication in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Remote (message receiver) signal strength indication in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte remrssi;
            /// <summary>Remaining free transmitter buffer space.  [%] </summary>
        [Units("[%]")]
        [Description("Remaining free transmitter buffer space.")]
        public  byte txbuf;
            /// <summary>Local background noise level. These are device dependent RSSI values (scale as approx 2x dB on SiK radios). Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Local background noise level. These are device dependent RSSI values (scale as approx 2x dB on SiK radios). Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte noise;
            /// <summary>Remote background noise level. These are device dependent RSSI values (scale as approx 2x dB on SiK radios). Values: [0-254], UINT8_MAX: invalid/unknown.   </summary>
        [Units("")]
        [Description("Remote background noise level. These are device dependent RSSI values (scale as approx 2x dB on SiK radios). Values: [0-254], UINT8_MAX: invalid/unknown.")]
        public  byte remnoise;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=254)]
    ///<summary> File transfer protocol message: https://mavlink.io/en/services/ftp.html. </summary>
    public struct mavlink_file_transfer_protocol_t
    {
        public mavlink_file_transfer_protocol_t(byte target_network,byte target_system,byte target_component,byte[] payload) 
        {
              this.target_network = target_network;
              this.target_system = target_system;
              this.target_component = target_component;
              this.payload = payload;
            
        }
        /// <summary>Network ID (0 for broadcast)   </summary>
        [Units("")]
        [Description("Network ID (0 for broadcast)")]
        public  byte target_network;
            /// <summary>System ID (0 for broadcast)   </summary>
        [Units("")]
        [Description("System ID (0 for broadcast)")]
        public  byte target_system;
            /// <summary>Component ID (0 for broadcast)   </summary>
        [Units("")]
        [Description("Component ID (0 for broadcast)")]
        public  byte target_component;
            /// <summary>Variable length payload. The length is defined by the remaining message length when subtracting the header and other fields. The content/format of this block is defined in https://mavlink.io/en/services/ftp.html.   </summary>
        [Units("")]
        [Description("Variable length payload. The length is defined by the remaining message length when subtracting the header and other fields. The content/format of this block is defined in https://mavlink.io/en/services/ftp.html.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=251)]
		public byte[] payload;
    
    };

    
    /// extensions_start 2
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=16)]
    ///<summary>          Time synchronization message.         The message is used for both timesync requests and responses.         The request is sent with `ts1=syncing component timestamp` and `tc1=0`, and may be broadcast or targeted to a specific system/component.         The response is sent with `ts1=syncing component timestamp` (mirror back unchanged), and `tc1=responding component timestamp`, with the `target_system` and `target_component` set to ids of the original request.         Systems can determine if they are receiving a request or response based on the value of `tc`.         If the response has `target_system==target_component==0` the remote system has not been updated to use the component IDs and cannot reliably timesync; the requestor may report an error.         Timestamps are UNIX Epoch time or time since system boot in nanoseconds (the timestamp format can be inferred by checking for the magnitude of the number; generally it doesn't matter as only the offset is used).         The message sequence is repeated numerous times with results being filtered/averaged to estimate the offset.        </summary>
    public struct mavlink_timesync_t
    {
        public mavlink_timesync_t(long tc1,long ts1) 
        {
              this.tc1 = tc1;
              this.ts1 = ts1;
            
        }
        /// <summary>Time sync timestamp 1. Syncing: 0. Responding: Timestamp of responding component.  [ns] </summary>
        [Units("[ns]")]
        [Description("Time sync timestamp 1. Syncing: 0. Responding: Timestamp of responding component.")]
        public  long tc1;
            /// <summary>Time sync timestamp 2. Timestamp of syncing component (mirrored in response).  [ns] </summary>
        [Units("[ns]")]
        [Description("Time sync timestamp 2. Timestamp of syncing component (mirrored in response).")]
        public  long ts1;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=12)]
    ///<summary> Camera-IMU triggering and synchronisation message. </summary>
    public struct mavlink_camera_trigger_t
    {
        public mavlink_camera_trigger_t(ulong time_usec,uint seq) 
        {
              this.time_usec = time_usec;
              this.seq = seq;
            
        }
        /// <summary>Timestamp for image frame (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp for image frame (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Image frame sequence   </summary>
        [Units("")]
        [Description("Image frame sequence")]
        public  uint seq;
    
    };

    
    /// extensions_start 13
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    ///<summary> The global position, as returned by the Global Positioning System (GPS). This is                  NOT the global position estimate of the system, but rather a RAW sensor value. See message GLOBAL_POSITION_INT for the global position estimate. </summary>
    public struct mavlink_hil_gps_t
    {
        public mavlink_hil_gps_t(ulong time_usec,int lat,int lon,int alt,ushort eph,ushort epv,ushort vel,short vn,short ve,short vd,ushort cog,byte fix_type,byte satellites_visible) 
        {
              this.time_usec = time_usec;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.eph = eph;
              this.epv = epv;
              this.vel = vel;
              this.vn = vn;
              this.ve = ve;
              this.vd = vd;
              this.cog = cog;
              this.fix_type = fix_type;
              this.satellites_visible = satellites_visible;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int lat;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int lon;
            /// <summary>Altitude (MSL). Positive for up.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  int alt;
            /// <summary>GPS HDOP horizontal dilution of position (unitless * 100). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS HDOP horizontal dilution of position (unitless * 100). If unknown, set to: UINT16_MAX")]
        public  ushort eph;
            /// <summary>GPS VDOP vertical dilution of position (unitless * 100). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS VDOP vertical dilution of position (unitless * 100). If unknown, set to: UINT16_MAX")]
        public  ushort epv;
            /// <summary>GPS ground speed. If unknown, set to: UINT16_MAX  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("GPS ground speed. If unknown, set to: UINT16_MAX")]
        public  ushort vel;
            /// <summary>GPS velocity in north direction in earth-fixed NED frame  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("GPS velocity in north direction in earth-fixed NED frame")]
        public  short vn;
            /// <summary>GPS velocity in east direction in earth-fixed NED frame  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("GPS velocity in east direction in earth-fixed NED frame")]
        public  short ve;
            /// <summary>GPS velocity in down direction in earth-fixed NED frame  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("GPS velocity in down direction in earth-fixed NED frame")]
        public  short vd;
            /// <summary>Course over ground (NOT heading, but direction of movement), 0.0..359.99 degrees. If unknown, set to: UINT16_MAX  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("Course over ground (NOT heading, but direction of movement), 0.0..359.99 degrees. If unknown, set to: UINT16_MAX")]
        public  ushort cog;
            /// <summary>0-1: no fix, 2: 2D fix, 3: 3D fix. Some applications will not use the value of this field unless it is at least two, so always correctly fill in the fix.   </summary>
        [Units("")]
        [Description("0-1: no fix, 2: 2D fix, 3: 3D fix. Some applications will not use the value of this field unless it is at least two, so always correctly fill in the fix.")]
        public  byte fix_type;
            /// <summary>Number of satellites visible. If unknown, set to UINT8_MAX   </summary>
        [Units("")]
        [Description("Number of satellites visible. If unknown, set to UINT8_MAX")]
        public  byte satellites_visible;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=44)]
    ///<summary> Simulated optical flow from a flow sensor (e.g. PX4FLOW or optical mouse sensor) </summary>
    public struct mavlink_hil_optical_flow_t
    {
        public mavlink_hil_optical_flow_t(ulong time_usec,uint integration_time_us,float integrated_x,float integrated_y,float integrated_xgyro,float integrated_ygyro,float integrated_zgyro,uint time_delta_distance_us,float distance,short temperature,byte sensor_id,byte quality) 
        {
              this.time_usec = time_usec;
              this.integration_time_us = integration_time_us;
              this.integrated_x = integrated_x;
              this.integrated_y = integrated_y;
              this.integrated_xgyro = integrated_xgyro;
              this.integrated_ygyro = integrated_ygyro;
              this.integrated_zgyro = integrated_zgyro;
              this.time_delta_distance_us = time_delta_distance_us;
              this.distance = distance;
              this.temperature = temperature;
              this.sensor_id = sensor_id;
              this.quality = quality;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Integration time. Divide integrated_x and integrated_y by the integration time to obtain average flow. The integration time also indicates the.  [us] </summary>
        [Units("[us]")]
        [Description("Integration time. Divide integrated_x and integrated_y by the integration time to obtain average flow. The integration time also indicates the.")]
        public  uint integration_time_us;
            /// <summary>Flow in radians around X axis (Sensor RH rotation about the X axis induces a positive flow. Sensor linear motion along the positive Y axis induces a negative flow.)  [rad] </summary>
        [Units("[rad]")]
        [Description("Flow in radians around X axis (Sensor RH rotation about the X axis induces a positive flow. Sensor linear motion along the positive Y axis induces a negative flow.)")]
        public  float integrated_x;
            /// <summary>Flow in radians around Y axis (Sensor RH rotation about the Y axis induces a positive flow. Sensor linear motion along the positive X axis induces a positive flow.)  [rad] </summary>
        [Units("[rad]")]
        [Description("Flow in radians around Y axis (Sensor RH rotation about the Y axis induces a positive flow. Sensor linear motion along the positive X axis induces a positive flow.)")]
        public  float integrated_y;
            /// <summary>RH rotation around X axis  [rad] </summary>
        [Units("[rad]")]
        [Description("RH rotation around X axis")]
        public  float integrated_xgyro;
            /// <summary>RH rotation around Y axis  [rad] </summary>
        [Units("[rad]")]
        [Description("RH rotation around Y axis")]
        public  float integrated_ygyro;
            /// <summary>RH rotation around Z axis  [rad] </summary>
        [Units("[rad]")]
        [Description("RH rotation around Z axis")]
        public  float integrated_zgyro;
            /// <summary>Time since the distance was sampled.  [us] </summary>
        [Units("[us]")]
        [Description("Time since the distance was sampled.")]
        public  uint time_delta_distance_us;
            /// <summary>Distance to the center of the flow field. Positive value (including zero): distance known. Negative value: Unknown distance.  [m] </summary>
        [Units("[m]")]
        [Description("Distance to the center of the flow field. Positive value (including zero): distance known. Negative value: Unknown distance.")]
        public  float distance;
            /// <summary>Temperature  [cdegC] </summary>
        [Units("[cdegC]")]
        [Description("Temperature")]
        public  short temperature;
            /// <summary>Sensor ID   </summary>
        [Units("")]
        [Description("Sensor ID")]
        public  byte sensor_id;
            /// <summary>Optical flow quality / confidence. 0: no valid flow, 255: maximum quality   </summary>
        [Units("")]
        [Description("Optical flow quality / confidence. 0: no valid flow, 255: maximum quality")]
        public  byte quality;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=64)]
    ///<summary> Sent from simulation to autopilot, avoids in contrast to HIL_STATE singularities. This packet is useful for high throughput applications such as hardware in the loop simulations. </summary>
    public struct mavlink_hil_state_quaternion_t
    {
        public mavlink_hil_state_quaternion_t(ulong time_usec,float[] attitude_quaternion,float rollspeed,float pitchspeed,float yawspeed,int lat,int lon,int alt,short vx,short vy,short vz,ushort ind_airspeed,ushort true_airspeed,short xacc,short yacc,short zacc) 
        {
              this.time_usec = time_usec;
              this.attitude_quaternion = attitude_quaternion;
              this.rollspeed = rollspeed;
              this.pitchspeed = pitchspeed;
              this.yawspeed = yawspeed;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.vx = vx;
              this.vy = vy;
              this.vz = vz;
              this.ind_airspeed = ind_airspeed;
              this.true_airspeed = true_airspeed;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Vehicle attitude expressed as normalized quaternion in w, x, y, z order (with 1 0 0 0 being the null-rotation)   </summary>
        [Units("")]
        [Description("Vehicle attitude expressed as normalized quaternion in w, x, y, z order (with 1 0 0 0 being the null-rotation)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] attitude_quaternion;
            /// <summary>Body frame roll / phi angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body frame roll / phi angular speed")]
        public  float rollspeed;
            /// <summary>Body frame pitch / theta angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body frame pitch / theta angular speed")]
        public  float pitchspeed;
            /// <summary>Body frame yaw / psi angular speed  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Body frame yaw / psi angular speed")]
        public  float yawspeed;
            /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int lat;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int lon;
            /// <summary>Altitude  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude")]
        public  int alt;
            /// <summary>Ground X Speed (Latitude)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground X Speed (Latitude)")]
        public  short vx;
            /// <summary>Ground Y Speed (Longitude)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground Y Speed (Longitude)")]
        public  short vy;
            /// <summary>Ground Z Speed (Altitude)  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Ground Z Speed (Altitude)")]
        public  short vz;
            /// <summary>Indicated airspeed  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("Indicated airspeed")]
        public  ushort ind_airspeed;
            /// <summary>True airspeed  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("True airspeed")]
        public  ushort true_airspeed;
            /// <summary>X acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("X acceleration")]
        public  short xacc;
            /// <summary>Y acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Y acceleration")]
        public  short yacc;
            /// <summary>Z acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Z acceleration")]
        public  short zacc;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> The RAW IMU readings for secondary 9DOF sensor setup. This message should contain the scaled values to the described units </summary>
    public struct mavlink_scaled_imu2_t
    {
        public mavlink_scaled_imu2_t(uint time_boot_ms,short xacc,short yacc,short zacc,short xgyro,short ygyro,short zgyro,short xmag,short ymag,short zmag) 
        {
              this.time_boot_ms = time_boot_ms;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.xmag = xmag;
              this.ymag = ymag;
              this.zmag = zmag;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("X acceleration")]
        public  short xacc;
            /// <summary>Y acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Y acceleration")]
        public  short yacc;
            /// <summary>Z acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Z acceleration")]
        public  short zacc;
            /// <summary>Angular speed around X axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around X axis")]
        public  short xgyro;
            /// <summary>Angular speed around Y axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around Y axis")]
        public  short ygyro;
            /// <summary>Angular speed around Z axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around Z axis")]
        public  short zgyro;
            /// <summary>X Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("X Magnetic field")]
        public  short xmag;
            /// <summary>Y Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("Y Magnetic field")]
        public  short ymag;
            /// <summary>Z Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("Z Magnetic field")]
        public  short zmag;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary> Request a list of available logs. On some systems calling this may stop on-board logging until LOG_REQUEST_END is called. If there are no log files available this request shall be answered with one LOG_ENTRY message with id = 0 and num_logs = 0. </summary>
    public struct mavlink_log_request_list_t
    {
        public mavlink_log_request_list_t(ushort start,ushort end,byte target_system,byte target_component) 
        {
              this.start = start;
              this.end = end;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>First log id (0 for first available)   </summary>
        [Units("")]
        [Description("First log id (0 for first available)")]
        public  ushort start;
            /// <summary>Last log id (0xffff for last available)   </summary>
        [Units("")]
        [Description("Last log id (0xffff for last available)")]
        public  ushort end;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    ///<summary> Reply to LOG_REQUEST_LIST </summary>
    public struct mavlink_log_entry_t
    {
        public mavlink_log_entry_t(uint time_utc,uint size,ushort id,ushort num_logs,ushort last_log_num) 
        {
              this.time_utc = time_utc;
              this.size = size;
              this.id = id;
              this.num_logs = num_logs;
              this.last_log_num = last_log_num;
            
        }
        /// <summary>UTC timestamp of log since 1970, or 0 if not available  [s] </summary>
        [Units("[s]")]
        [Description("UTC timestamp of log since 1970, or 0 if not available")]
        public  uint time_utc;
            /// <summary>Size of the log (may be approximate)  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Size of the log (may be approximate)")]
        public  uint size;
            /// <summary>Log id   </summary>
        [Units("")]
        [Description("Log id")]
        public  ushort id;
            /// <summary>Total number of logs   </summary>
        [Units("")]
        [Description("Total number of logs")]
        public  ushort num_logs;
            /// <summary>High log number   </summary>
        [Units("")]
        [Description("High log number")]
        public  ushort last_log_num;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=12)]
    ///<summary> Request a chunk of a log </summary>
    public struct mavlink_log_request_data_t
    {
        public mavlink_log_request_data_t(uint ofs,uint count,ushort id,byte target_system,byte target_component) 
        {
              this.ofs = ofs;
              this.count = count;
              this.id = id;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Offset into the log   </summary>
        [Units("")]
        [Description("Offset into the log")]
        public  uint ofs;
            /// <summary>Number of bytes  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Number of bytes")]
        public  uint count;
            /// <summary>Log id (from LOG_ENTRY reply)   </summary>
        [Units("")]
        [Description("Log id (from LOG_ENTRY reply)")]
        public  ushort id;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=97)]
    ///<summary> Reply to LOG_REQUEST_DATA </summary>
    public struct mavlink_log_data_t
    {
        public mavlink_log_data_t(uint ofs,ushort id,byte count,byte[] data) 
        {
              this.ofs = ofs;
              this.id = id;
              this.count = count;
              this.data = data;
            
        }
        /// <summary>Offset into the log   </summary>
        [Units("")]
        [Description("Offset into the log")]
        public  uint ofs;
            /// <summary>Log id (from LOG_ENTRY reply)   </summary>
        [Units("")]
        [Description("Log id (from LOG_ENTRY reply)")]
        public  ushort id;
            /// <summary>Number of bytes (zero for end of log)  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Number of bytes (zero for end of log)")]
        public  byte count;
            /// <summary>log data   </summary>
        [Units("")]
        [Description("log data")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=90)]
		public byte[] data;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> Erase all logs </summary>
    public struct mavlink_log_erase_t
    {
        public mavlink_log_erase_t(byte target_system,byte target_component) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> Stop log transfer and resume normal logging </summary>
    public struct mavlink_log_request_end_t
    {
        public mavlink_log_request_end_t(byte target_system,byte target_component) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=113)]
    ///<summary> Data for injecting into the onboard GPS (used for DGPS) </summary>
    public struct mavlink_gps_inject_data_t
    {
        public mavlink_gps_inject_data_t(byte target_system,byte target_component,byte len,byte[] data) 
        {
              this.target_system = target_system;
              this.target_component = target_component;
              this.len = len;
              this.data = data;
            
        }
        /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
            /// <summary>Data length  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Data length")]
        public  byte len;
            /// <summary>Raw data (110 is enough for 12 satellites of RTCMv2)   </summary>
        [Units("")]
        [Description("Raw data (110 is enough for 12 satellites of RTCMv2)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=110)]
		public byte[] data;
    
    };

    
    /// extensions_start 12
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=35)]
    ///<summary> Second GPS data. </summary>
    public struct mavlink_gps2_raw_t
    {
        public mavlink_gps2_raw_t(ulong time_usec,int lat,int lon,int alt,uint dgps_age,ushort eph,ushort epv,ushort vel,ushort cog,/*GPS_FIX_TYPE*/byte fix_type,byte satellites_visible,byte dgps_numch) 
        {
              this.time_usec = time_usec;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.dgps_age = dgps_age;
              this.eph = eph;
              this.epv = epv;
              this.vel = vel;
              this.cog = cog;
              this.fix_type = fix_type;
              this.satellites_visible = satellites_visible;
              this.dgps_numch = dgps_numch;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int lat;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int lon;
            /// <summary>Altitude (MSL). Positive for up.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  int alt;
            /// <summary>Age of DGPS info  [ms] </summary>
        [Units("[ms]")]
        [Description("Age of DGPS info")]
        public  uint dgps_age;
            /// <summary>GPS HDOP horizontal dilution of position (unitless * 100). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS HDOP horizontal dilution of position (unitless * 100). If unknown, set to: UINT16_MAX")]
        public  ushort eph;
            /// <summary>GPS VDOP vertical dilution of position (unitless * 100). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS VDOP vertical dilution of position (unitless * 100). If unknown, set to: UINT16_MAX")]
        public  ushort epv;
            /// <summary>GPS ground speed. If unknown, set to: UINT16_MAX  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("GPS ground speed. If unknown, set to: UINT16_MAX")]
        public  ushort vel;
            /// <summary>Course over ground (NOT heading, but direction of movement): 0.0..359.99 degrees. If unknown, set to: UINT16_MAX  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("Course over ground (NOT heading, but direction of movement): 0.0..359.99 degrees. If unknown, set to: UINT16_MAX")]
        public  ushort cog;
            /// <summary>GPS fix type. GPS_FIX_TYPE  </summary>
        [Units("")]
        [Description("GPS fix type.")]
        public  /*GPS_FIX_TYPE*/byte fix_type;
            /// <summary>Number of satellites visible. If unknown, set to UINT8_MAX   </summary>
        [Units("")]
        [Description("Number of satellites visible. If unknown, set to UINT8_MAX")]
        public  byte satellites_visible;
            /// <summary>Number of DGPS satellites   </summary>
        [Units("")]
        [Description("Number of DGPS satellites")]
        public  byte dgps_numch;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary> Power supply status </summary>
    public struct mavlink_power_status_t
    {
        public mavlink_power_status_t(ushort Vcc,ushort Vservo,/*MAV_POWER_STATUS*/ushort flags) 
        {
              this.Vcc = Vcc;
              this.Vservo = Vservo;
              this.flags = flags;
            
        }
        /// <summary>5V rail voltage.  [mV] </summary>
        [Units("[mV]")]
        [Description("5V rail voltage.")]
        public  ushort Vcc;
            /// <summary>Servo rail voltage.  [mV] </summary>
        [Units("[mV]")]
        [Description("Servo rail voltage.")]
        public  ushort Vservo;
            /// <summary>Bitmap of power supply status flags. MAV_POWER_STATUS  bitmask</summary>
        [Units("")]
        [Description("Bitmap of power supply status flags.")]
        public  /*MAV_POWER_STATUS*/ushort flags;
    
    };

    
    /// extensions_start 6
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=79)]
    ///<summary> Control a serial port. This can be used for raw access to an onboard serial peripheral such as a GPS or telemetry radio. It is designed to make it possible to update the devices firmware via MAVLink messages or change the devices settings. A message with zero bytes can be used to change just the baudrate. </summary>
    public struct mavlink_serial_control_t
    {
        public mavlink_serial_control_t(uint baudrate,ushort timeout,/*SERIAL_CONTROL_DEV*/byte device,/*SERIAL_CONTROL_FLAG*/byte flags,byte count,byte[] data) 
        {
              this.baudrate = baudrate;
              this.timeout = timeout;
              this.device = device;
              this.flags = flags;
              this.count = count;
              this.data = data;
            
        }
        /// <summary>Baudrate of transfer. Zero means no change.  [bits/s] </summary>
        [Units("[bits/s]")]
        [Description("Baudrate of transfer. Zero means no change.")]
        public  uint baudrate;
            /// <summary>Timeout for reply data  [ms] </summary>
        [Units("[ms]")]
        [Description("Timeout for reply data")]
        public  ushort timeout;
            /// <summary>Serial control device type. SERIAL_CONTROL_DEV  </summary>
        [Units("")]
        [Description("Serial control device type.")]
        public  /*SERIAL_CONTROL_DEV*/byte device;
            /// <summary>Bitmap of serial control flags. SERIAL_CONTROL_FLAG  bitmask</summary>
        [Units("")]
        [Description("Bitmap of serial control flags.")]
        public  /*SERIAL_CONTROL_FLAG*/byte flags;
            /// <summary>how many bytes in this transfer  [bytes] </summary>
        [Units("[bytes]")]
        [Description("how many bytes in this transfer")]
        public  byte count;
            /// <summary>serial data   </summary>
        [Units("")]
        [Description("serial data")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=70)]
		public byte[] data;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=35)]
    ///<summary> RTK GPS data. Gives information on the relative baseline calculation the GPS is reporting </summary>
    public struct mavlink_gps_rtk_t
    {
        public mavlink_gps_rtk_t(uint time_last_baseline_ms,uint tow,int baseline_a_mm,int baseline_b_mm,int baseline_c_mm,uint accuracy,int iar_num_hypotheses,ushort wn,byte rtk_receiver_id,byte rtk_health,byte rtk_rate,byte nsats,/*RTK_BASELINE_COORDINATE_SYSTEM*/byte baseline_coords_type) 
        {
              this.time_last_baseline_ms = time_last_baseline_ms;
              this.tow = tow;
              this.baseline_a_mm = baseline_a_mm;
              this.baseline_b_mm = baseline_b_mm;
              this.baseline_c_mm = baseline_c_mm;
              this.accuracy = accuracy;
              this.iar_num_hypotheses = iar_num_hypotheses;
              this.wn = wn;
              this.rtk_receiver_id = rtk_receiver_id;
              this.rtk_health = rtk_health;
              this.rtk_rate = rtk_rate;
              this.nsats = nsats;
              this.baseline_coords_type = baseline_coords_type;
            
        }
        /// <summary>Time since boot of last baseline message received.  [ms] </summary>
        [Units("[ms]")]
        [Description("Time since boot of last baseline message received.")]
        public  uint time_last_baseline_ms;
            /// <summary>GPS Time of Week of last baseline  [ms] </summary>
        [Units("[ms]")]
        [Description("GPS Time of Week of last baseline")]
        public  uint tow;
            /// <summary>Current baseline in ECEF x or NED north component.  [mm] </summary>
        [Units("[mm]")]
        [Description("Current baseline in ECEF x or NED north component.")]
        public  int baseline_a_mm;
            /// <summary>Current baseline in ECEF y or NED east component.  [mm] </summary>
        [Units("[mm]")]
        [Description("Current baseline in ECEF y or NED east component.")]
        public  int baseline_b_mm;
            /// <summary>Current baseline in ECEF z or NED down component.  [mm] </summary>
        [Units("[mm]")]
        [Description("Current baseline in ECEF z or NED down component.")]
        public  int baseline_c_mm;
            /// <summary>Current estimate of baseline accuracy.   </summary>
        [Units("")]
        [Description("Current estimate of baseline accuracy.")]
        public  uint accuracy;
            /// <summary>Current number of integer ambiguity hypotheses.   </summary>
        [Units("")]
        [Description("Current number of integer ambiguity hypotheses.")]
        public  int iar_num_hypotheses;
            /// <summary>GPS Week Number of last baseline   </summary>
        [Units("")]
        [Description("GPS Week Number of last baseline")]
        public  ushort wn;
            /// <summary>Identification of connected RTK receiver.   </summary>
        [Units("")]
        [Description("Identification of connected RTK receiver.")]
        public  byte rtk_receiver_id;
            /// <summary>GPS-specific health report for RTK data.   </summary>
        [Units("")]
        [Description("GPS-specific health report for RTK data.")]
        public  byte rtk_health;
            /// <summary>Rate of baseline messages being received by GPS  [Hz] </summary>
        [Units("[Hz]")]
        [Description("Rate of baseline messages being received by GPS")]
        public  byte rtk_rate;
            /// <summary>Current number of sats used for RTK calculation.   </summary>
        [Units("")]
        [Description("Current number of sats used for RTK calculation.")]
        public  byte nsats;
            /// <summary>Coordinate system of baseline RTK_BASELINE_COORDINATE_SYSTEM  </summary>
        [Units("")]
        [Description("Coordinate system of baseline")]
        public  /*RTK_BASELINE_COORDINATE_SYSTEM*/byte baseline_coords_type;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=35)]
    ///<summary> RTK GPS data. Gives information on the relative baseline calculation the GPS is reporting </summary>
    public struct mavlink_gps2_rtk_t
    {
        public mavlink_gps2_rtk_t(uint time_last_baseline_ms,uint tow,int baseline_a_mm,int baseline_b_mm,int baseline_c_mm,uint accuracy,int iar_num_hypotheses,ushort wn,byte rtk_receiver_id,byte rtk_health,byte rtk_rate,byte nsats,/*RTK_BASELINE_COORDINATE_SYSTEM*/byte baseline_coords_type) 
        {
              this.time_last_baseline_ms = time_last_baseline_ms;
              this.tow = tow;
              this.baseline_a_mm = baseline_a_mm;
              this.baseline_b_mm = baseline_b_mm;
              this.baseline_c_mm = baseline_c_mm;
              this.accuracy = accuracy;
              this.iar_num_hypotheses = iar_num_hypotheses;
              this.wn = wn;
              this.rtk_receiver_id = rtk_receiver_id;
              this.rtk_health = rtk_health;
              this.rtk_rate = rtk_rate;
              this.nsats = nsats;
              this.baseline_coords_type = baseline_coords_type;
            
        }
        /// <summary>Time since boot of last baseline message received.  [ms] </summary>
        [Units("[ms]")]
        [Description("Time since boot of last baseline message received.")]
        public  uint time_last_baseline_ms;
            /// <summary>GPS Time of Week of last baseline  [ms] </summary>
        [Units("[ms]")]
        [Description("GPS Time of Week of last baseline")]
        public  uint tow;
            /// <summary>Current baseline in ECEF x or NED north component.  [mm] </summary>
        [Units("[mm]")]
        [Description("Current baseline in ECEF x or NED north component.")]
        public  int baseline_a_mm;
            /// <summary>Current baseline in ECEF y or NED east component.  [mm] </summary>
        [Units("[mm]")]
        [Description("Current baseline in ECEF y or NED east component.")]
        public  int baseline_b_mm;
            /// <summary>Current baseline in ECEF z or NED down component.  [mm] </summary>
        [Units("[mm]")]
        [Description("Current baseline in ECEF z or NED down component.")]
        public  int baseline_c_mm;
            /// <summary>Current estimate of baseline accuracy.   </summary>
        [Units("")]
        [Description("Current estimate of baseline accuracy.")]
        public  uint accuracy;
            /// <summary>Current number of integer ambiguity hypotheses.   </summary>
        [Units("")]
        [Description("Current number of integer ambiguity hypotheses.")]
        public  int iar_num_hypotheses;
            /// <summary>GPS Week Number of last baseline   </summary>
        [Units("")]
        [Description("GPS Week Number of last baseline")]
        public  ushort wn;
            /// <summary>Identification of connected RTK receiver.   </summary>
        [Units("")]
        [Description("Identification of connected RTK receiver.")]
        public  byte rtk_receiver_id;
            /// <summary>GPS-specific health report for RTK data.   </summary>
        [Units("")]
        [Description("GPS-specific health report for RTK data.")]
        public  byte rtk_health;
            /// <summary>Rate of baseline messages being received by GPS  [Hz] </summary>
        [Units("[Hz]")]
        [Description("Rate of baseline messages being received by GPS")]
        public  byte rtk_rate;
            /// <summary>Current number of sats used for RTK calculation.   </summary>
        [Units("")]
        [Description("Current number of sats used for RTK calculation.")]
        public  byte nsats;
            /// <summary>Coordinate system of baseline RTK_BASELINE_COORDINATE_SYSTEM  </summary>
        [Units("")]
        [Description("Coordinate system of baseline")]
        public  /*RTK_BASELINE_COORDINATE_SYSTEM*/byte baseline_coords_type;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> The RAW IMU readings for 3rd 9DOF sensor setup. This message should contain the scaled values to the described units </summary>
    public struct mavlink_scaled_imu3_t
    {
        public mavlink_scaled_imu3_t(uint time_boot_ms,short xacc,short yacc,short zacc,short xgyro,short ygyro,short zgyro,short xmag,short ymag,short zmag) 
        {
              this.time_boot_ms = time_boot_ms;
              this.xacc = xacc;
              this.yacc = yacc;
              this.zacc = zacc;
              this.xgyro = xgyro;
              this.ygyro = ygyro;
              this.zgyro = zgyro;
              this.xmag = xmag;
              this.ymag = ymag;
              this.zmag = zmag;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>X acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("X acceleration")]
        public  short xacc;
            /// <summary>Y acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Y acceleration")]
        public  short yacc;
            /// <summary>Z acceleration  [mG] </summary>
        [Units("[mG]")]
        [Description("Z acceleration")]
        public  short zacc;
            /// <summary>Angular speed around X axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around X axis")]
        public  short xgyro;
            /// <summary>Angular speed around Y axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around Y axis")]
        public  short ygyro;
            /// <summary>Angular speed around Z axis  [mrad/s] </summary>
        [Units("[mrad/s]")]
        [Description("Angular speed around Z axis")]
        public  short zgyro;
            /// <summary>X Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("X Magnetic field")]
        public  short xmag;
            /// <summary>Y Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("Y Magnetic field")]
        public  short ymag;
            /// <summary>Z Magnetic field  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("Z Magnetic field")]
        public  short zmag;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=13)]
    ///<summary> Handshake message to initiate, control and stop image streaming when using the Image Transmission Protocol: https://mavlink.io/en/services/image_transmission.html. </summary>
    public struct mavlink_data_transmission_handshake_t
    {
        public mavlink_data_transmission_handshake_t(uint size,ushort width,ushort height,ushort packets,/*MAVLINK_DATA_STREAM_TYPE*/byte type,byte payload,byte jpg_quality) 
        {
              this.size = size;
              this.width = width;
              this.height = height;
              this.packets = packets;
              this.type = type;
              this.payload = payload;
              this.jpg_quality = jpg_quality;
            
        }
        /// <summary>total data size (set on ACK only).  [bytes] </summary>
        [Units("[bytes]")]
        [Description("total data size (set on ACK only).")]
        public  uint size;
            /// <summary>Width of a matrix or image.   </summary>
        [Units("")]
        [Description("Width of a matrix or image.")]
        public  ushort width;
            /// <summary>Height of a matrix or image.   </summary>
        [Units("")]
        [Description("Height of a matrix or image.")]
        public  ushort height;
            /// <summary>Number of packets being sent (set on ACK only).   </summary>
        [Units("")]
        [Description("Number of packets being sent (set on ACK only).")]
        public  ushort packets;
            /// <summary>Type of requested/acknowledged data. MAVLINK_DATA_STREAM_TYPE  </summary>
        [Units("")]
        [Description("Type of requested/acknowledged data.")]
        public  /*MAVLINK_DATA_STREAM_TYPE*/byte type;
            /// <summary>Payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only).  [bytes] </summary>
        [Units("[bytes]")]
        [Description("Payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only).")]
        public  byte payload;
            /// <summary>JPEG quality. Values: [1-100].  [%] </summary>
        [Units("[%]")]
        [Description("JPEG quality. Values: [1-100].")]
        public  byte jpg_quality;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=255)]
    ///<summary> Data packet for images sent using the Image Transmission Protocol: https://mavlink.io/en/services/image_transmission.html. </summary>
    public struct mavlink_encapsulated_data_t
    {
        public mavlink_encapsulated_data_t(ushort seqnr,byte[] data) 
        {
              this.seqnr = seqnr;
              this.data = data;
            
        }
        /// <summary>sequence number (starting with 0 on every transmission)   </summary>
        [Units("")]
        [Description("sequence number (starting with 0 on every transmission)")]
        public  ushort seqnr;
            /// <summary>image data bytes   </summary>
        [Units("")]
        [Description("image data bytes")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=253)]
		public byte[] data;
    
    };

    
    /// extensions_start 8
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    ///<summary> Distance sensor information for an onboard rangefinder. </summary>
    public struct mavlink_distance_sensor_t
    {
        public mavlink_distance_sensor_t(uint time_boot_ms,ushort min_distance,ushort max_distance,ushort current_distance,/*MAV_DISTANCE_SENSOR*/byte type,byte id,/*MAV_SENSOR_ORIENTATION*/byte orientation,byte covariance) 
        {
              this.time_boot_ms = time_boot_ms;
              this.min_distance = min_distance;
              this.max_distance = max_distance;
              this.current_distance = current_distance;
              this.type = type;
              this.id = id;
              this.orientation = orientation;
              this.covariance = covariance;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Minimum distance the sensor can measure  [cm] </summary>
        [Units("[cm]")]
        [Description("Minimum distance the sensor can measure")]
        public  ushort min_distance;
            /// <summary>Maximum distance the sensor can measure  [cm] </summary>
        [Units("[cm]")]
        [Description("Maximum distance the sensor can measure")]
        public  ushort max_distance;
            /// <summary>Current distance reading  [cm] </summary>
        [Units("[cm]")]
        [Description("Current distance reading")]
        public  ushort current_distance;
            /// <summary>Type of distance sensor. MAV_DISTANCE_SENSOR  </summary>
        [Units("")]
        [Description("Type of distance sensor.")]
        public  /*MAV_DISTANCE_SENSOR*/byte type;
            /// <summary>Onboard ID of the sensor   </summary>
        [Units("")]
        [Description("Onboard ID of the sensor")]
        public  byte id;
            /// <summary>Direction the sensor faces. downward-facing: ROTATION_PITCH_270, upward-facing: ROTATION_PITCH_90, backward-facing: ROTATION_PITCH_180, forward-facing: ROTATION_NONE, left-facing: ROTATION_YAW_90, right-facing: ROTATION_YAW_270 MAV_SENSOR_ORIENTATION  </summary>
        [Units("")]
        [Description("Direction the sensor faces. downward-facing: ROTATION_PITCH_270, upward-facing: ROTATION_PITCH_90, backward-facing: ROTATION_PITCH_180, forward-facing: ROTATION_NONE, left-facing: ROTATION_YAW_90, right-facing: ROTATION_YAW_270")]
        public  /*MAV_SENSOR_ORIENTATION*/byte orientation;
            /// <summary>Measurement variance. Max standard deviation is 6cm. UINT8_MAX if unknown.  [cm^2] </summary>
        [Units("[cm^2]")]
        [Description("Measurement variance. Max standard deviation is 6cm. UINT8_MAX if unknown.")]
        public  byte covariance;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=18)]
    ///<summary> Request for terrain data and terrain status. See terrain protocol docs: https://mavlink.io/en/services/terrain.html </summary>
    public struct mavlink_terrain_request_t
    {
        public mavlink_terrain_request_t(ulong mask,int lat,int lon,ushort grid_spacing) 
        {
              this.mask = mask;
              this.lat = lat;
              this.lon = lon;
              this.grid_spacing = grid_spacing;
            
        }
        /// <summary>Bitmask of requested 4x4 grids (row major 8x7 array of grids, 56 bits)   bitmask</summary>
        [Units("")]
        [Description("Bitmask of requested 4x4 grids (row major 8x7 array of grids, 56 bits)")]
        public  ulong mask;
            /// <summary>Latitude of SW corner of first grid  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude of SW corner of first grid")]
        public  int lat;
            /// <summary>Longitude of SW corner of first grid  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude of SW corner of first grid")]
        public  int lon;
            /// <summary>Grid spacing  [m] </summary>
        [Units("[m]")]
        [Description("Grid spacing")]
        public  ushort grid_spacing;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=43)]
    ///<summary> Terrain data sent from GCS. The lat/lon and grid_spacing must be the same as a lat/lon from a TERRAIN_REQUEST. See terrain protocol docs: https://mavlink.io/en/services/terrain.html </summary>
    public struct mavlink_terrain_data_t
    {
        public mavlink_terrain_data_t(int lat,int lon,ushort grid_spacing,short[] data,byte gridbit) 
        {
              this.lat = lat;
              this.lon = lon;
              this.grid_spacing = grid_spacing;
              this.data = data;
              this.gridbit = gridbit;
            
        }
        /// <summary>Latitude of SW corner of first grid  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude of SW corner of first grid")]
        public  int lat;
            /// <summary>Longitude of SW corner of first grid  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude of SW corner of first grid")]
        public  int lon;
            /// <summary>Grid spacing  [m] </summary>
        [Units("[m]")]
        [Description("Grid spacing")]
        public  ushort grid_spacing;
            /// <summary>Terrain data MSL  [m] </summary>
        [Units("[m]")]
        [Description("Terrain data MSL")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=16)]
		public short[] data;
            /// <summary>bit within the terrain request mask   </summary>
        [Units("")]
        [Description("bit within the terrain request mask")]
        public  byte gridbit;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=8)]
    ///<summary> Request that the vehicle report terrain height at the given location (expected response is a TERRAIN_REPORT). Used by GCS to check if vehicle has all terrain data needed for a mission. </summary>
    public struct mavlink_terrain_check_t
    {
        public mavlink_terrain_check_t(int lat,int lon) 
        {
              this.lat = lat;
              this.lon = lon;
            
        }
        /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int lat;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int lon;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=22)]
    ///<summary> Streamed from drone to report progress of terrain map download (initiated by TERRAIN_REQUEST), or sent as a response to a TERRAIN_CHECK request. See terrain protocol docs: https://mavlink.io/en/services/terrain.html </summary>
    public struct mavlink_terrain_report_t
    {
        public mavlink_terrain_report_t(int lat,int lon,float terrain_height,float current_height,ushort spacing,ushort pending,ushort loaded) 
        {
              this.lat = lat;
              this.lon = lon;
              this.terrain_height = terrain_height;
              this.current_height = current_height;
              this.spacing = spacing;
              this.pending = pending;
              this.loaded = loaded;
            
        }
        /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int lat;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int lon;
            /// <summary>Terrain height MSL  [m] </summary>
        [Units("[m]")]
        [Description("Terrain height MSL")]
        public  float terrain_height;
            /// <summary>Current vehicle height above lat/lon terrain height  [m] </summary>
        [Units("[m]")]
        [Description("Current vehicle height above lat/lon terrain height")]
        public  float current_height;
            /// <summary>grid spacing (zero if terrain at this location unavailable)   </summary>
        [Units("")]
        [Description("grid spacing (zero if terrain at this location unavailable)")]
        public  ushort spacing;
            /// <summary>Number of 4x4 terrain blocks waiting to be received or read from disk   </summary>
        [Units("")]
        [Description("Number of 4x4 terrain blocks waiting to be received or read from disk")]
        public  ushort pending;
            /// <summary>Number of 4x4 terrain blocks in memory   </summary>
        [Units("")]
        [Description("Number of 4x4 terrain blocks in memory")]
        public  ushort loaded;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    ///<summary> Barometer readings for 2nd barometer </summary>
    public struct mavlink_scaled_pressure2_t
    {
        public mavlink_scaled_pressure2_t(uint time_boot_ms,float press_abs,float press_diff,short temperature) 
        {
              this.time_boot_ms = time_boot_ms;
              this.press_abs = press_abs;
              this.press_diff = press_diff;
              this.temperature = temperature;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Absolute pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Absolute pressure")]
        public  float press_abs;
            /// <summary>Differential pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Differential pressure")]
        public  float press_diff;
            /// <summary>Absolute pressure temperature  [cdegC] </summary>
        [Units("[cdegC]")]
        [Description("Absolute pressure temperature")]
        public  short temperature;
    
    };

    
    /// extensions_start 5
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    ///<summary> Motion capture attitude and position </summary>
    public struct mavlink_att_pos_mocap_t
    {
        public mavlink_att_pos_mocap_t(ulong time_usec,float[] q,float x,float y,float z) 
        {
              this.time_usec = time_usec;
              this.q = q;
              this.x = x;
              this.y = y;
              this.z = z;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)   </summary>
        [Units("")]
        [Description("Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>X position (NED)  [m] </summary>
        [Units("[m]")]
        [Description("X position (NED)")]
        public  float x;
            /// <summary>Y position (NED)  [m] </summary>
        [Units("[m]")]
        [Description("Y position (NED)")]
        public  float y;
            /// <summary>Z position (NED)  [m] </summary>
        [Units("[m]")]
        [Description("Z position (NED)")]
        public  float z;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=43)]
    ///<summary> Set the vehicle attitude and body angular rates. </summary>
    public struct mavlink_set_actuator_control_target_t
    {
        public mavlink_set_actuator_control_target_t(ulong time_usec,float[] controls,byte group_mlx,byte target_system,byte target_component) 
        {
              this.time_usec = time_usec;
              this.controls = controls;
              this.group_mlx = group_mlx;
              this.target_system = target_system;
              this.target_component = target_component;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Actuator controls. Normed to -1..+1 where 0 is neutral position. Throttle for single rotation direction motors is 0..1, negative range for reverse direction. Standard mapping for attitude controls (group 0): (index 0-7): roll, pitch, yaw, throttle, flaps, spoilers, airbrakes, landing gear. Load a pass-through mixer to repurpose them as generic outputs.   </summary>
        [Units("")]
        [Description("Actuator controls. Normed to -1..+1 where 0 is neutral position. Throttle for single rotation direction motors is 0..1, negative range for reverse direction. Standard mapping for attitude controls (group 0): (index 0-7): roll, pitch, yaw, throttle, flaps, spoilers, airbrakes, landing gear. Load a pass-through mixer to repurpose them as generic outputs.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=8)]
		public float[] controls;
            /// <summary>Actuator group. The '_mlx' indicates this is a multi-instance message and a MAVLink parser should use this field to difference between instances.   </summary>
        [Units("")]
        [Description("Actuator group. The '_mlx' indicates this is a multi-instance message and a MAVLink parser should use this field to difference between instances.")]
        public  byte group_mlx;
            /// <summary>System ID   </summary>
        [Units("")]
        [Description("System ID")]
        public  byte target_system;
            /// <summary>Component ID   </summary>
        [Units("")]
        [Description("Component ID")]
        public  byte target_component;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=41)]
    ///<summary> Set the vehicle attitude and body angular rates. </summary>
    public struct mavlink_actuator_control_target_t
    {
        public mavlink_actuator_control_target_t(ulong time_usec,float[] controls,byte group_mlx) 
        {
              this.time_usec = time_usec;
              this.controls = controls;
              this.group_mlx = group_mlx;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Actuator controls. Normed to -1..+1 where 0 is neutral position. Throttle for single rotation direction motors is 0..1, negative range for reverse direction. Standard mapping for attitude controls (group 0): (index 0-7): roll, pitch, yaw, throttle, flaps, spoilers, airbrakes, landing gear. Load a pass-through mixer to repurpose them as generic outputs.   </summary>
        [Units("")]
        [Description("Actuator controls. Normed to -1..+1 where 0 is neutral position. Throttle for single rotation direction motors is 0..1, negative range for reverse direction. Standard mapping for attitude controls (group 0): (index 0-7): roll, pitch, yaw, throttle, flaps, spoilers, airbrakes, landing gear. Load a pass-through mixer to repurpose them as generic outputs.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=8)]
		public float[] controls;
            /// <summary>Actuator group. The '_mlx' indicates this is a multi-instance message and a MAVLink parser should use this field to difference between instances.   </summary>
        [Units("")]
        [Description("Actuator group. The '_mlx' indicates this is a multi-instance message and a MAVLink parser should use this field to difference between instances.")]
        public  byte group_mlx;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> The current system altitude. </summary>
    public struct mavlink_altitude_t
    {
        public mavlink_altitude_t(ulong time_usec,float altitude_monotonic,float altitude_amsl,float altitude_local,float altitude_relative,float altitude_terrain,float bottom_clearance) 
        {
              this.time_usec = time_usec;
              this.altitude_monotonic = altitude_monotonic;
              this.altitude_amsl = altitude_amsl;
              this.altitude_local = altitude_local;
              this.altitude_relative = altitude_relative;
              this.altitude_terrain = altitude_terrain;
              this.bottom_clearance = bottom_clearance;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>This altitude measure is initialized on system boot and monotonic (it is never reset, but represents the local altitude change). The only guarantee on this field is that it will never be reset and is consistent within a flight. The recommended value for this field is the uncorrected barometric altitude at boot time. This altitude will also drift and vary between flights.  [m] </summary>
        [Units("[m]")]
        [Description("This altitude measure is initialized on system boot and monotonic (it is never reset, but represents the local altitude change). The only guarantee on this field is that it will never be reset and is consistent within a flight. The recommended value for this field is the uncorrected barometric altitude at boot time. This altitude will also drift and vary between flights.")]
        public  float altitude_monotonic;
            /// <summary>This altitude measure is strictly above mean sea level and might be non-monotonic (it might reset on events like GPS lock or when a new QNH value is set). It should be the altitude to which global altitude waypoints are compared to. Note that it is *not* the GPS altitude, however, most GPS modules already output MSL by default and not the WGS84 altitude.  [m] </summary>
        [Units("[m]")]
        [Description("This altitude measure is strictly above mean sea level and might be non-monotonic (it might reset on events like GPS lock or when a new QNH value is set). It should be the altitude to which global altitude waypoints are compared to. Note that it is *not* the GPS altitude, however, most GPS modules already output MSL by default and not the WGS84 altitude.")]
        public  float altitude_amsl;
            /// <summary>This is the local altitude in the local coordinate frame. It is not the altitude above home, but in reference to the coordinate origin (0, 0, 0). It is up-positive.  [m] </summary>
        [Units("[m]")]
        [Description("This is the local altitude in the local coordinate frame. It is not the altitude above home, but in reference to the coordinate origin (0, 0, 0). It is up-positive.")]
        public  float altitude_local;
            /// <summary>This is the altitude above the home position. It resets on each change of the current home position.  [m] </summary>
        [Units("[m]")]
        [Description("This is the altitude above the home position. It resets on each change of the current home position.")]
        public  float altitude_relative;
            /// <summary>This is the altitude above terrain. It might be fed by a terrain database or an altimeter. Values smaller than -1000 should be interpreted as unknown.  [m] </summary>
        [Units("[m]")]
        [Description("This is the altitude above terrain. It might be fed by a terrain database or an altimeter. Values smaller than -1000 should be interpreted as unknown.")]
        public  float altitude_terrain;
            /// <summary>This is not the altitude, but the clear space below the system according to the fused clearance estimate. It generally should max out at the maximum range of e.g. the laser altimeter. It is generally a moving target. A negative value indicates no measurement available.  [m] </summary>
        [Units("[m]")]
        [Description("This is not the altitude, but the clear space below the system according to the fused clearance estimate. It generally should max out at the maximum range of e.g. the laser altimeter. It is generally a moving target. A negative value indicates no measurement available.")]
        public  float bottom_clearance;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=243)]
    ///<summary> The autopilot is requesting a resource (file, binary, other type of data) </summary>
    public struct mavlink_resource_request_t
    {
        public mavlink_resource_request_t(byte request_id,byte uri_type,byte[] uri,byte transfer_type,byte[] storage) 
        {
              this.request_id = request_id;
              this.uri_type = uri_type;
              this.uri = uri;
              this.transfer_type = transfer_type;
              this.storage = storage;
            
        }
        /// <summary>Request ID. This ID should be re-used when sending back URI contents   </summary>
        [Units("")]
        [Description("Request ID. This ID should be re-used when sending back URI contents")]
        public  byte request_id;
            /// <summary>The type of requested URI. 0 = a file via URL. 1 = a UAVCAN binary   </summary>
        [Units("")]
        [Description("The type of requested URI. 0 = a file via URL. 1 = a UAVCAN binary")]
        public  byte uri_type;
            /// <summary>The requested unique resource identifier (URI). It is not necessarily a straight domain name (depends on the URI type enum)   </summary>
        [Units("")]
        [Description("The requested unique resource identifier (URI). It is not necessarily a straight domain name (depends on the URI type enum)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=120)]
		public byte[] uri;
            /// <summary>The way the autopilot wants to receive the URI. 0 = MAVLink FTP. 1 = binary stream.   </summary>
        [Units("")]
        [Description("The way the autopilot wants to receive the URI. 0 = MAVLink FTP. 1 = binary stream.")]
        public  byte transfer_type;
            /// <summary>The storage path the autopilot wants the URI to be stored in. Will only be valid if the transfer_type has a storage associated (e.g. MAVLink FTP).   </summary>
        [Units("")]
        [Description("The storage path the autopilot wants the URI to be stored in. Will only be valid if the transfer_type has a storage associated (e.g. MAVLink FTP).")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=120)]
		public byte[] storage;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    ///<summary> Barometer readings for 3rd barometer </summary>
    public struct mavlink_scaled_pressure3_t
    {
        public mavlink_scaled_pressure3_t(uint time_boot_ms,float press_abs,float press_diff,short temperature) 
        {
              this.time_boot_ms = time_boot_ms;
              this.press_abs = press_abs;
              this.press_diff = press_diff;
              this.temperature = temperature;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Absolute pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Absolute pressure")]
        public  float press_abs;
            /// <summary>Differential pressure  [hPa] </summary>
        [Units("[hPa]")]
        [Description("Differential pressure")]
        public  float press_diff;
            /// <summary>Absolute pressure temperature  [cdegC] </summary>
        [Units("[cdegC]")]
        [Description("Absolute pressure temperature")]
        public  short temperature;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=93)]
    ///<summary> Current motion information from a designated system </summary>
    public struct mavlink_follow_target_t
    {
        public mavlink_follow_target_t(ulong timestamp,ulong custom_state,int lat,int lon,float alt,float[] vel,float[] acc,float[] attitude_q,float[] rates,float[] position_cov,byte est_capabilities) 
        {
              this.timestamp = timestamp;
              this.custom_state = custom_state;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.vel = vel;
              this.acc = acc;
              this.attitude_q = attitude_q;
              this.rates = rates;
              this.position_cov = position_cov;
              this.est_capabilities = est_capabilities;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  ulong timestamp;
            /// <summary>button states or switches of a tracker device   </summary>
        [Units("")]
        [Description("button states or switches of a tracker device")]
        public  ulong custom_state;
            /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int lat;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int lon;
            /// <summary>Altitude (MSL)  [m] </summary>
        [Units("[m]")]
        [Description("Altitude (MSL)")]
        public  float alt;
            /// <summary>target velocity (0,0,0) for unknown  [m/s] </summary>
        [Units("[m/s]")]
        [Description("target velocity (0,0,0) for unknown")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=3)]
		public float[] vel;
            /// <summary>linear target acceleration (0,0,0) for unknown  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("linear target acceleration (0,0,0) for unknown")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=3)]
		public float[] acc;
            /// <summary>(0 0 0 0 for unknown)   </summary>
        [Units("")]
        [Description("(0 0 0 0 for unknown)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] attitude_q;
            /// <summary>(0 0 0 for unknown)   </summary>
        [Units("")]
        [Description("(0 0 0 for unknown)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=3)]
		public float[] rates;
            /// <summary>eph epv   </summary>
        [Units("")]
        [Description("eph epv")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=3)]
		public float[] position_cov;
            /// <summary>bit positions for tracker reporting capabilities (POS = 0, VEL = 1, ACCEL = 2, ATT + RATES = 3)   </summary>
        [Units("")]
        [Description("bit positions for tracker reporting capabilities (POS = 0, VEL = 1, ACCEL = 2, ATT + RATES = 3)")]
        public  byte est_capabilities;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=100)]
    ///<summary> The smoothed, monotonic system state used to feed the control loops of the system. </summary>
    public struct mavlink_control_system_state_t
    {
        public mavlink_control_system_state_t(ulong time_usec,float x_acc,float y_acc,float z_acc,float x_vel,float y_vel,float z_vel,float x_pos,float y_pos,float z_pos,float airspeed,float[] vel_variance,float[] pos_variance,float[] q,float roll_rate,float pitch_rate,float yaw_rate) 
        {
              this.time_usec = time_usec;
              this.x_acc = x_acc;
              this.y_acc = y_acc;
              this.z_acc = z_acc;
              this.x_vel = x_vel;
              this.y_vel = y_vel;
              this.z_vel = z_vel;
              this.x_pos = x_pos;
              this.y_pos = y_pos;
              this.z_pos = z_pos;
              this.airspeed = airspeed;
              this.vel_variance = vel_variance;
              this.pos_variance = pos_variance;
              this.q = q;
              this.roll_rate = roll_rate;
              this.pitch_rate = pitch_rate;
              this.yaw_rate = yaw_rate;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>X acceleration in body frame  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("X acceleration in body frame")]
        public  float x_acc;
            /// <summary>Y acceleration in body frame  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Y acceleration in body frame")]
        public  float y_acc;
            /// <summary>Z acceleration in body frame  [m/s/s] </summary>
        [Units("[m/s/s]")]
        [Description("Z acceleration in body frame")]
        public  float z_acc;
            /// <summary>X velocity in body frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("X velocity in body frame")]
        public  float x_vel;
            /// <summary>Y velocity in body frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Y velocity in body frame")]
        public  float y_vel;
            /// <summary>Z velocity in body frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Z velocity in body frame")]
        public  float z_vel;
            /// <summary>X position in local frame  [m] </summary>
        [Units("[m]")]
        [Description("X position in local frame")]
        public  float x_pos;
            /// <summary>Y position in local frame  [m] </summary>
        [Units("[m]")]
        [Description("Y position in local frame")]
        public  float y_pos;
            /// <summary>Z position in local frame  [m] </summary>
        [Units("[m]")]
        [Description("Z position in local frame")]
        public  float z_pos;
            /// <summary>Airspeed, set to -1 if unknown  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Airspeed, set to -1 if unknown")]
        public  float airspeed;
            /// <summary>Variance of body velocity estimate   </summary>
        [Units("")]
        [Description("Variance of body velocity estimate")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=3)]
		public float[] vel_variance;
            /// <summary>Variance in local position   </summary>
        [Units("")]
        [Description("Variance in local position")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=3)]
		public float[] pos_variance;
            /// <summary>The attitude, represented as Quaternion   </summary>
        [Units("")]
        [Description("The attitude, represented as Quaternion")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>Angular rate in roll axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular rate in roll axis")]
        public  float roll_rate;
            /// <summary>Angular rate in pitch axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular rate in pitch axis")]
        public  float pitch_rate;
            /// <summary>Angular rate in yaw axis  [rad/s] </summary>
        [Units("[rad/s]")]
        [Description("Angular rate in yaw axis")]
        public  float yaw_rate;
    
    };

    
    /// extensions_start 9
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    ///<summary> Battery information. Updates GCS with flight controller battery status. Smart batteries also use this message, but may additionally send SMART_BATTERY_INFO. </summary>
    public struct mavlink_battery_status_t
    {
        public mavlink_battery_status_t(int current_consumed,int energy_consumed,short temperature,ushort[] voltages,short current_battery,byte id,/*MAV_BATTERY_FUNCTION*/byte battery_function,/*MAV_BATTERY_TYPE*/byte type,sbyte battery_remaining) 
        {
              this.current_consumed = current_consumed;
              this.energy_consumed = energy_consumed;
              this.temperature = temperature;
              this.voltages = voltages;
              this.current_battery = current_battery;
              this.id = id;
              this.battery_function = battery_function;
              this.type = type;
              this.battery_remaining = battery_remaining;
            
        }
        /// <summary>Consumed charge, -1: autopilot does not provide consumption estimate  [mAh] </summary>
        [Units("[mAh]")]
        [Description("Consumed charge, -1: autopilot does not provide consumption estimate")]
        public  int current_consumed;
            /// <summary>Consumed energy, -1: autopilot does not provide energy consumption estimate  [hJ] </summary>
        [Units("[hJ]")]
        [Description("Consumed energy, -1: autopilot does not provide energy consumption estimate")]
        public  int energy_consumed;
            /// <summary>Temperature of the battery. INT16_MAX for unknown temperature.  [cdegC] </summary>
        [Units("[cdegC]")]
        [Description("Temperature of the battery. INT16_MAX for unknown temperature.")]
        public  short temperature;
            /// <summary>Battery voltage of cells 1 to 10 (see voltages_ext for cells 11-14). Cells in this field above the valid cell count for this battery should have the UINT16_MAX value. If individual cell voltages are unknown or not measured for this battery, then the overall battery voltage should be filled in cell 0, with all others set to UINT16_MAX. If the voltage of the battery is greater than (UINT16_MAX - 1), then cell 0 should be set to (UINT16_MAX - 1), and cell 1 to the remaining voltage. This can be extended to multiple cells if the total voltage is greater than 2 * (UINT16_MAX - 1).  [mV] </summary>
        [Units("[mV]")]
        [Description("Battery voltage of cells 1 to 10 (see voltages_ext for cells 11-14). Cells in this field above the valid cell count for this battery should have the UINT16_MAX value. If individual cell voltages are unknown or not measured for this battery, then the overall battery voltage should be filled in cell 0, with all others set to UINT16_MAX. If the voltage of the battery is greater than (UINT16_MAX - 1), then cell 0 should be set to (UINT16_MAX - 1), and cell 1 to the remaining voltage. This can be extended to multiple cells if the total voltage is greater than 2 * (UINT16_MAX - 1).")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=10)]
		public ushort[] voltages;
            /// <summary>Battery current, -1: autopilot does not measure the current  [cA] </summary>
        [Units("[cA]")]
        [Description("Battery current, -1: autopilot does not measure the current")]
        public  short current_battery;
            /// <summary>Battery ID   </summary>
        [Units("")]
        [Description("Battery ID")]
        public  byte id;
            /// <summary>Function of the battery MAV_BATTERY_FUNCTION  </summary>
        [Units("")]
        [Description("Function of the battery")]
        public  /*MAV_BATTERY_FUNCTION*/byte battery_function;
            /// <summary>Type (chemistry) of the battery MAV_BATTERY_TYPE  </summary>
        [Units("")]
        [Description("Type (chemistry) of the battery")]
        public  /*MAV_BATTERY_TYPE*/byte type;
            /// <summary>Remaining battery energy. Values: [0-100], -1: autopilot does not estimate the remaining battery.  [%] </summary>
        [Units("[%]")]
        [Description("Remaining battery energy. Values: [0-100], -1: autopilot does not estimate the remaining battery.")]
        public  sbyte battery_remaining;
    
    };

    
    /// extensions_start 11
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=60)]
    ///<summary> Version and capability of autopilot software. This should be emitted in response to a request with MAV_CMD_REQUEST_MESSAGE. </summary>
    public struct mavlink_autopilot_version_t
    {
        public mavlink_autopilot_version_t(/*MAV_PROTOCOL_CAPABILITY*/ulong capabilities,ulong uid,uint flight_sw_version,uint middleware_sw_version,uint os_sw_version,uint board_version,ushort vendor_id,ushort product_id,byte[] flight_custom_version,byte[] middleware_custom_version,byte[] os_custom_version) 
        {
              this.capabilities = capabilities;
              this.uid = uid;
              this.flight_sw_version = flight_sw_version;
              this.middleware_sw_version = middleware_sw_version;
              this.os_sw_version = os_sw_version;
              this.board_version = board_version;
              this.vendor_id = vendor_id;
              this.product_id = product_id;
              this.flight_custom_version = flight_custom_version;
              this.middleware_custom_version = middleware_custom_version;
              this.os_custom_version = os_custom_version;
            
        }
        /// <summary>Bitmap of capabilities MAV_PROTOCOL_CAPABILITY  bitmask</summary>
        [Units("")]
        [Description("Bitmap of capabilities")]
        public  /*MAV_PROTOCOL_CAPABILITY*/ulong capabilities;
            /// <summary>UID if provided by hardware (see uid2)   </summary>
        [Units("")]
        [Description("UID if provided by hardware (see uid2)")]
        public  ulong uid;
            /// <summary>Firmware version number   </summary>
        [Units("")]
        [Description("Firmware version number")]
        public  uint flight_sw_version;
            /// <summary>Middleware version number   </summary>
        [Units("")]
        [Description("Middleware version number")]
        public  uint middleware_sw_version;
            /// <summary>Operating system version number   </summary>
        [Units("")]
        [Description("Operating system version number")]
        public  uint os_sw_version;
            /// <summary>HW / board version (last 8 bits should be silicon ID, if any). The first 16 bits of this field specify https://github.com/PX4/PX4-Bootloader/blob/master/board_types.txt   </summary>
        [Units("")]
        [Description("HW / board version (last 8 bits should be silicon ID, if any). The first 16 bits of this field specify https://github.com/PX4/PX4-Bootloader/blob/master/board_types.txt")]
        public  uint board_version;
            /// <summary>ID of the board vendor   </summary>
        [Units("")]
        [Description("ID of the board vendor")]
        public  ushort vendor_id;
            /// <summary>ID of the product   </summary>
        [Units("")]
        [Description("ID of the product")]
        public  ushort product_id;
            /// <summary>Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.   </summary>
        [Units("")]
        [Description("Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=8)]
		public byte[] flight_custom_version;
            /// <summary>Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.   </summary>
        [Units("")]
        [Description("Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=8)]
		public byte[] middleware_custom_version;
            /// <summary>Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.   </summary>
        [Units("")]
        [Description("Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=8)]
		public byte[] os_custom_version;
    
    };

    
    /// extensions_start 8
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=30)]
    ///<summary> The location of a landing target. See: https://mavlink.io/en/services/landing_target.html </summary>
    public struct mavlink_landing_target_t
    {
        public mavlink_landing_target_t(ulong time_usec,float angle_x,float angle_y,float distance,float size_x,float size_y,byte target_num,/*MAV_FRAME*/byte frame) 
        {
              this.time_usec = time_usec;
              this.angle_x = angle_x;
              this.angle_y = angle_y;
              this.distance = distance;
              this.size_x = size_x;
              this.size_y = size_y;
              this.target_num = target_num;
              this.frame = frame;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>X-axis angular offset of the target from the center of the image  [rad] </summary>
        [Units("[rad]")]
        [Description("X-axis angular offset of the target from the center of the image")]
        public  float angle_x;
            /// <summary>Y-axis angular offset of the target from the center of the image  [rad] </summary>
        [Units("[rad]")]
        [Description("Y-axis angular offset of the target from the center of the image")]
        public  float angle_y;
            /// <summary>Distance to the target from the vehicle  [m] </summary>
        [Units("[m]")]
        [Description("Distance to the target from the vehicle")]
        public  float distance;
            /// <summary>Size of target along x-axis  [rad] </summary>
        [Units("[rad]")]
        [Description("Size of target along x-axis")]
        public  float size_x;
            /// <summary>Size of target along y-axis  [rad] </summary>
        [Units("[rad]")]
        [Description("Size of target along y-axis")]
        public  float size_y;
            /// <summary>The ID of the target if multiple targets are present   </summary>
        [Units("")]
        [Description("The ID of the target if multiple targets are present")]
        public  byte target_num;
            /// <summary>Coordinate frame used for following fields. MAV_FRAME  </summary>
        [Units("")]
        [Description("Coordinate frame used for following fields.")]
        public  /*MAV_FRAME*/byte frame;
    
    };

    
    /// extensions_start 4
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=8)]
    ///<summary> Status of geo-fencing. Sent in extended status stream when fencing enabled. </summary>
    public struct mavlink_fence_status_t
    {
        public mavlink_fence_status_t(uint breach_time,ushort breach_count,byte breach_status,/*FENCE_BREACH*/byte breach_type) 
        {
              this.breach_time = breach_time;
              this.breach_count = breach_count;
              this.breach_status = breach_status;
              this.breach_type = breach_type;
            
        }
        /// <summary>Time (since boot) of last breach.  [ms] </summary>
        [Units("[ms]")]
        [Description("Time (since boot) of last breach.")]
        public  uint breach_time;
            /// <summary>Number of fence breaches.   </summary>
        [Units("")]
        [Description("Number of fence breaches.")]
        public  ushort breach_count;
            /// <summary>Breach status (0 if currently inside fence, 1 if outside).   </summary>
        [Units("")]
        [Description("Breach status (0 if currently inside fence, 1 if outside).")]
        public  byte breach_status;
            /// <summary>Last breach type. FENCE_BREACH  </summary>
        [Units("")]
        [Description("Last breach type.")]
        public  /*FENCE_BREACH*/byte breach_type;
    
    };

    
    /// extensions_start 14
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=44)]
    ///<summary> Reports results of completed compass calibration. Sent until MAG_CAL_ACK received. </summary>
    public struct mavlink_mag_cal_report_t
    {
        public mavlink_mag_cal_report_t(float fitness,float ofs_x,float ofs_y,float ofs_z,float diag_x,float diag_y,float diag_z,float offdiag_x,float offdiag_y,float offdiag_z,byte compass_id,byte cal_mask,/*MAG_CAL_STATUS*/byte cal_status,byte autosaved) 
        {
              this.fitness = fitness;
              this.ofs_x = ofs_x;
              this.ofs_y = ofs_y;
              this.ofs_z = ofs_z;
              this.diag_x = diag_x;
              this.diag_y = diag_y;
              this.diag_z = diag_z;
              this.offdiag_x = offdiag_x;
              this.offdiag_y = offdiag_y;
              this.offdiag_z = offdiag_z;
              this.compass_id = compass_id;
              this.cal_mask = cal_mask;
              this.cal_status = cal_status;
              this.autosaved = autosaved;
            
        }
        /// <summary>RMS milligauss residuals.  [mgauss] </summary>
        [Units("[mgauss]")]
        [Description("RMS milligauss residuals.")]
        public  float fitness;
            /// <summary>X offset.   </summary>
        [Units("")]
        [Description("X offset.")]
        public  float ofs_x;
            /// <summary>Y offset.   </summary>
        [Units("")]
        [Description("Y offset.")]
        public  float ofs_y;
            /// <summary>Z offset.   </summary>
        [Units("")]
        [Description("Z offset.")]
        public  float ofs_z;
            /// <summary>X diagonal (matrix 11).   </summary>
        [Units("")]
        [Description("X diagonal (matrix 11).")]
        public  float diag_x;
            /// <summary>Y diagonal (matrix 22).   </summary>
        [Units("")]
        [Description("Y diagonal (matrix 22).")]
        public  float diag_y;
            /// <summary>Z diagonal (matrix 33).   </summary>
        [Units("")]
        [Description("Z diagonal (matrix 33).")]
        public  float diag_z;
            /// <summary>X off-diagonal (matrix 12 and 21).   </summary>
        [Units("")]
        [Description("X off-diagonal (matrix 12 and 21).")]
        public  float offdiag_x;
            /// <summary>Y off-diagonal (matrix 13 and 31).   </summary>
        [Units("")]
        [Description("Y off-diagonal (matrix 13 and 31).")]
        public  float offdiag_y;
            /// <summary>Z off-diagonal (matrix 32 and 23).   </summary>
        [Units("")]
        [Description("Z off-diagonal (matrix 32 and 23).")]
        public  float offdiag_z;
            /// <summary>Compass being calibrated.   </summary>
        [Units("")]
        [Description("Compass being calibrated.")]
        public  byte compass_id;
            /// <summary>Bitmask of compasses being calibrated.   bitmask</summary>
        [Units("")]
        [Description("Bitmask of compasses being calibrated.")]
        public  byte cal_mask;
            /// <summary>Calibration Status. MAG_CAL_STATUS  </summary>
        [Units("")]
        [Description("Calibration Status.")]
        public  /*MAG_CAL_STATUS*/byte cal_status;
            /// <summary>0=requires a MAV_CMD_DO_ACCEPT_MAG_CAL, 1=saved to parameters.   </summary>
        [Units("")]
        [Description("0=requires a MAV_CMD_DO_ACCEPT_MAG_CAL, 1=saved to parameters.")]
        public  byte autosaved;
    
    };

    
    /// extensions_start 17
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=65)]
    ///<summary> EFI status output </summary>
    public struct mavlink_efi_status_t
    {
        public mavlink_efi_status_t(float ecu_index,float rpm,float fuel_consumed,float fuel_flow,float engine_load,float throttle_position,float spark_dwell_time,float barometric_pressure,float intake_manifold_pressure,float intake_manifold_temperature,float cylinder_head_temperature,float ignition_timing,float injection_time,float exhaust_gas_temperature,float throttle_out,float pt_compensation,byte health) 
        {
              this.ecu_index = ecu_index;
              this.rpm = rpm;
              this.fuel_consumed = fuel_consumed;
              this.fuel_flow = fuel_flow;
              this.engine_load = engine_load;
              this.throttle_position = throttle_position;
              this.spark_dwell_time = spark_dwell_time;
              this.barometric_pressure = barometric_pressure;
              this.intake_manifold_pressure = intake_manifold_pressure;
              this.intake_manifold_temperature = intake_manifold_temperature;
              this.cylinder_head_temperature = cylinder_head_temperature;
              this.ignition_timing = ignition_timing;
              this.injection_time = injection_time;
              this.exhaust_gas_temperature = exhaust_gas_temperature;
              this.throttle_out = throttle_out;
              this.pt_compensation = pt_compensation;
              this.health = health;
            
        }
        /// <summary>ECU index   </summary>
        [Units("")]
        [Description("ECU index")]
        public  float ecu_index;
            /// <summary>RPM   </summary>
        [Units("")]
        [Description("RPM")]
        public  float rpm;
            /// <summary>Fuel consumed  [cm^3] </summary>
        [Units("[cm^3]")]
        [Description("Fuel consumed")]
        public  float fuel_consumed;
            /// <summary>Fuel flow rate  [cm^3/min] </summary>
        [Units("[cm^3/min]")]
        [Description("Fuel flow rate")]
        public  float fuel_flow;
            /// <summary>Engine load  [%] </summary>
        [Units("[%]")]
        [Description("Engine load")]
        public  float engine_load;
            /// <summary>Throttle position  [%] </summary>
        [Units("[%]")]
        [Description("Throttle position")]
        public  float throttle_position;
            /// <summary>Spark dwell time  [ms] </summary>
        [Units("[ms]")]
        [Description("Spark dwell time")]
        public  float spark_dwell_time;
            /// <summary>Barometric pressure  [kPa] </summary>
        [Units("[kPa]")]
        [Description("Barometric pressure")]
        public  float barometric_pressure;
            /// <summary>Intake manifold pressure(  [kPa] </summary>
        [Units("[kPa]")]
        [Description("Intake manifold pressure(")]
        public  float intake_manifold_pressure;
            /// <summary>Intake manifold temperature  [degC] </summary>
        [Units("[degC]")]
        [Description("Intake manifold temperature")]
        public  float intake_manifold_temperature;
            /// <summary>Cylinder head temperature  [degC] </summary>
        [Units("[degC]")]
        [Description("Cylinder head temperature")]
        public  float cylinder_head_temperature;
            /// <summary>Ignition timing (Crank angle degrees)  [deg] </summary>
        [Units("[deg]")]
        [Description("Ignition timing (Crank angle degrees)")]
        public  float ignition_timing;
            /// <summary>Injection time  [ms] </summary>
        [Units("[ms]")]
        [Description("Injection time")]
        public  float injection_time;
            /// <summary>Exhaust gas temperature  [degC] </summary>
        [Units("[degC]")]
        [Description("Exhaust gas temperature")]
        public  float exhaust_gas_temperature;
            /// <summary>Output throttle  [%] </summary>
        [Units("[%]")]
        [Description("Output throttle")]
        public  float throttle_out;
            /// <summary>Pressure/temperature compensation   </summary>
        [Units("")]
        [Description("Pressure/temperature compensation")]
        public  float pt_compensation;
            /// <summary>EFI health status   </summary>
        [Units("")]
        [Description("EFI health status")]
        public  byte health;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=42)]
    ///<summary> Estimator status message including flags, innovation test ratios and estimated accuracies. The flags message is an integer bitmask containing information on which EKF outputs are valid. See the ESTIMATOR_STATUS_FLAGS enum definition for further information. The innovation test ratios show the magnitude of the sensor innovation divided by the innovation check threshold. Under normal operation the innovation test ratios should be below 0.5 with occasional values up to 1.0. Values greater than 1.0 should be rare under normal operation and indicate that a measurement has been rejected by the filter. The user should be notified if an innovation test ratio greater than 1.0 is recorded. Notifications for values in the range between 0.5 and 1.0 should be optional and controllable by the user. </summary>
    public struct mavlink_estimator_status_t
    {
        public mavlink_estimator_status_t(ulong time_usec,float vel_ratio,float pos_horiz_ratio,float pos_vert_ratio,float mag_ratio,float hagl_ratio,float tas_ratio,float pos_horiz_accuracy,float pos_vert_accuracy,/*ESTIMATOR_STATUS_FLAGS*/ushort flags) 
        {
              this.time_usec = time_usec;
              this.vel_ratio = vel_ratio;
              this.pos_horiz_ratio = pos_horiz_ratio;
              this.pos_vert_ratio = pos_vert_ratio;
              this.mag_ratio = mag_ratio;
              this.hagl_ratio = hagl_ratio;
              this.tas_ratio = tas_ratio;
              this.pos_horiz_accuracy = pos_horiz_accuracy;
              this.pos_vert_accuracy = pos_vert_accuracy;
              this.flags = flags;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Velocity innovation test ratio   </summary>
        [Units("")]
        [Description("Velocity innovation test ratio")]
        public  float vel_ratio;
            /// <summary>Horizontal position innovation test ratio   </summary>
        [Units("")]
        [Description("Horizontal position innovation test ratio")]
        public  float pos_horiz_ratio;
            /// <summary>Vertical position innovation test ratio   </summary>
        [Units("")]
        [Description("Vertical position innovation test ratio")]
        public  float pos_vert_ratio;
            /// <summary>Magnetometer innovation test ratio   </summary>
        [Units("")]
        [Description("Magnetometer innovation test ratio")]
        public  float mag_ratio;
            /// <summary>Height above terrain innovation test ratio   </summary>
        [Units("")]
        [Description("Height above terrain innovation test ratio")]
        public  float hagl_ratio;
            /// <summary>True airspeed innovation test ratio   </summary>
        [Units("")]
        [Description("True airspeed innovation test ratio")]
        public  float tas_ratio;
            /// <summary>Horizontal position 1-STD accuracy relative to the EKF local origin  [m] </summary>
        [Units("[m]")]
        [Description("Horizontal position 1-STD accuracy relative to the EKF local origin")]
        public  float pos_horiz_accuracy;
            /// <summary>Vertical position 1-STD accuracy relative to the EKF local origin  [m] </summary>
        [Units("[m]")]
        [Description("Vertical position 1-STD accuracy relative to the EKF local origin")]
        public  float pos_vert_accuracy;
            /// <summary>Bitmap indicating which EKF outputs are valid. ESTIMATOR_STATUS_FLAGS  bitmask</summary>
        [Units("")]
        [Description("Bitmap indicating which EKF outputs are valid.")]
        public  /*ESTIMATOR_STATUS_FLAGS*/ushort flags;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=40)]
    ///<summary> Wind estimate from vehicle. Note that despite the name, this message does not actually contain any covariances but instead variability and accuracy fields in terms of standard deviation (1-STD). </summary>
    public struct mavlink_wind_cov_t
    {
        public mavlink_wind_cov_t(ulong time_usec,float wind_x,float wind_y,float wind_z,float var_horiz,float var_vert,float wind_alt,float horiz_accuracy,float vert_accuracy) 
        {
              this.time_usec = time_usec;
              this.wind_x = wind_x;
              this.wind_y = wind_y;
              this.wind_z = wind_z;
              this.var_horiz = var_horiz;
              this.var_vert = var_vert;
              this.wind_alt = wind_alt;
              this.horiz_accuracy = horiz_accuracy;
              this.vert_accuracy = vert_accuracy;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Wind in North (NED) direction (NAN if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Wind in North (NED) direction (NAN if unknown)")]
        public  float wind_x;
            /// <summary>Wind in East (NED) direction (NAN if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Wind in East (NED) direction (NAN if unknown)")]
        public  float wind_y;
            /// <summary>Wind in down (NED) direction (NAN if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Wind in down (NED) direction (NAN if unknown)")]
        public  float wind_z;
            /// <summary>Variability of wind in XY, 1-STD estimated from a 1 Hz lowpassed wind estimate (NAN if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Variability of wind in XY, 1-STD estimated from a 1 Hz lowpassed wind estimate (NAN if unknown)")]
        public  float var_horiz;
            /// <summary>Variability of wind in Z, 1-STD estimated from a 1 Hz lowpassed wind estimate (NAN if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Variability of wind in Z, 1-STD estimated from a 1 Hz lowpassed wind estimate (NAN if unknown)")]
        public  float var_vert;
            /// <summary>Altitude (MSL) that this measurement was taken at (NAN if unknown)  [m] </summary>
        [Units("[m]")]
        [Description("Altitude (MSL) that this measurement was taken at (NAN if unknown)")]
        public  float wind_alt;
            /// <summary>Horizontal speed 1-STD accuracy (0 if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Horizontal speed 1-STD accuracy (0 if unknown)")]
        public  float horiz_accuracy;
            /// <summary>Vertical speed 1-STD accuracy (0 if unknown)  [m/s] </summary>
        [Units("[m/s]")]
        [Description("Vertical speed 1-STD accuracy (0 if unknown)")]
        public  float vert_accuracy;
    
    };

    
    /// extensions_start 18
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=63)]
    ///<summary> GPS sensor input message.  This is a raw sensor value sent by the GPS. This is NOT the global position estimate of the system. </summary>
    public struct mavlink_gps_input_t
    {
        public mavlink_gps_input_t(ulong time_usec,uint time_week_ms,int lat,int lon,float alt,float hdop,float vdop,float vn,float ve,float vd,float speed_accuracy,float horiz_accuracy,float vert_accuracy,/*GPS_INPUT_IGNORE_FLAGS*/ushort ignore_flags,ushort time_week,byte gps_id,byte fix_type,byte satellites_visible) 
        {
              this.time_usec = time_usec;
              this.time_week_ms = time_week_ms;
              this.lat = lat;
              this.lon = lon;
              this.alt = alt;
              this.hdop = hdop;
              this.vdop = vdop;
              this.vn = vn;
              this.ve = ve;
              this.vd = vd;
              this.speed_accuracy = speed_accuracy;
              this.horiz_accuracy = horiz_accuracy;
              this.vert_accuracy = vert_accuracy;
              this.ignore_flags = ignore_flags;
              this.time_week = time_week;
              this.gps_id = gps_id;
              this.fix_type = fix_type;
              this.satellites_visible = satellites_visible;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>GPS time (from start of GPS week)  [ms] </summary>
        [Units("[ms]")]
        [Description("GPS time (from start of GPS week)")]
        public  uint time_week_ms;
            /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int lat;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int lon;
            /// <summary>Altitude (MSL). Positive for up.  [m] </summary>
        [Units("[m]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  float alt;
            /// <summary>GPS HDOP horizontal dilution of position (unitless). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS HDOP horizontal dilution of position (unitless). If unknown, set to: UINT16_MAX")]
        public  float hdop;
            /// <summary>GPS VDOP vertical dilution of position (unitless). If unknown, set to: UINT16_MAX   </summary>
        [Units("")]
        [Description("GPS VDOP vertical dilution of position (unitless). If unknown, set to: UINT16_MAX")]
        public  float vdop;
            /// <summary>GPS velocity in north direction in earth-fixed NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("GPS velocity in north direction in earth-fixed NED frame")]
        public  float vn;
            /// <summary>GPS velocity in east direction in earth-fixed NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("GPS velocity in east direction in earth-fixed NED frame")]
        public  float ve;
            /// <summary>GPS velocity in down direction in earth-fixed NED frame  [m/s] </summary>
        [Units("[m/s]")]
        [Description("GPS velocity in down direction in earth-fixed NED frame")]
        public  float vd;
            /// <summary>GPS speed accuracy  [m/s] </summary>
        [Units("[m/s]")]
        [Description("GPS speed accuracy")]
        public  float speed_accuracy;
            /// <summary>GPS horizontal accuracy  [m] </summary>
        [Units("[m]")]
        [Description("GPS horizontal accuracy")]
        public  float horiz_accuracy;
            /// <summary>GPS vertical accuracy  [m] </summary>
        [Units("[m]")]
        [Description("GPS vertical accuracy")]
        public  float vert_accuracy;
            /// <summary>Bitmap indicating which GPS input flags fields to ignore.  All other fields must be provided. GPS_INPUT_IGNORE_FLAGS  bitmask</summary>
        [Units("")]
        [Description("Bitmap indicating which GPS input flags fields to ignore.  All other fields must be provided.")]
        public  /*GPS_INPUT_IGNORE_FLAGS*/ushort ignore_flags;
            /// <summary>GPS week number   </summary>
        [Units("")]
        [Description("GPS week number")]
        public  ushort time_week;
            /// <summary>ID of the GPS for multiple GPS inputs   </summary>
        [Units("")]
        [Description("ID of the GPS for multiple GPS inputs")]
        public  byte gps_id;
            /// <summary>0-1: no fix, 2: 2D fix, 3: 3D fix. 4: 3D with DGPS. 5: 3D with RTK   </summary>
        [Units("")]
        [Description("0-1: no fix, 2: 2D fix, 3: 3D fix. 4: 3D with DGPS. 5: 3D with RTK")]
        public  byte fix_type;
            /// <summary>Number of satellites visible.   </summary>
        [Units("")]
        [Description("Number of satellites visible.")]
        public  byte satellites_visible;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=182)]
    ///<summary> RTCM message for injecting into the onboard GPS (used for DGPS) </summary>
    public struct mavlink_gps_rtcm_data_t
    {
        public mavlink_gps_rtcm_data_t(byte flags,byte len,byte[] data) 
        {
              this.flags = flags;
              this.len = len;
              this.data = data;
            
        }
        /// <summary>LSB: 1 means message is fragmented, next 2 bits are the fragment ID, the remaining 5 bits are used for the sequence ID. Messages are only to be flushed to the GPS when the entire message has been reconstructed on the autopilot. The fragment ID specifies which order the fragments should be assembled into a buffer, while the sequence ID is used to detect a mismatch between different buffers. The buffer is considered fully reconstructed when either all 4 fragments are present, or all the fragments before the first fragment with a non full payload is received. This management is used to ensure that normal GPS operation doesn't corrupt RTCM data, and to recover from a unreliable transport delivery order.   </summary>
        [Units("")]
        [Description("LSB: 1 means message is fragmented, next 2 bits are the fragment ID, the remaining 5 bits are used for the sequence ID. Messages are only to be flushed to the GPS when the entire message has been reconstructed on the autopilot. The fragment ID specifies which order the fragments should be assembled into a buffer, while the sequence ID is used to detect a mismatch between different buffers. The buffer is considered fully reconstructed when either all 4 fragments are present, or all the fragments before the first fragment with a non full payload is received. This management is used to ensure that normal GPS operation doesn't corrupt RTCM data, and to recover from a unreliable transport delivery order.")]
        public  byte flags;
            /// <summary>data length  [bytes] </summary>
        [Units("[bytes]")]
        [Description("data length")]
        public  byte len;
            /// <summary>RTCM message (may be fragmented)   </summary>
        [Units("")]
        [Description("RTCM message (may be fragmented)")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=180)]
		public byte[] data;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=40)]
    ///<summary> Message appropriate for high latency connections like Iridium </summary>
    public struct mavlink_high_latency_t
    {
        public mavlink_high_latency_t(uint custom_mode,int latitude,int longitude,short roll,short pitch,ushort heading,short heading_sp,short altitude_amsl,short altitude_sp,ushort wp_distance,/*MAV_MODE_FLAG*/byte base_mode,/*MAV_LANDED_STATE*/byte landed_state,sbyte throttle,byte airspeed,byte airspeed_sp,byte groundspeed,sbyte climb_rate,byte gps_nsat,/*GPS_FIX_TYPE*/byte gps_fix_type,byte battery_remaining,sbyte temperature,sbyte temperature_air,byte failsafe,byte wp_num) 
        {
              this.custom_mode = custom_mode;
              this.latitude = latitude;
              this.longitude = longitude;
              this.roll = roll;
              this.pitch = pitch;
              this.heading = heading;
              this.heading_sp = heading_sp;
              this.altitude_amsl = altitude_amsl;
              this.altitude_sp = altitude_sp;
              this.wp_distance = wp_distance;
              this.base_mode = base_mode;
              this.landed_state = landed_state;
              this.throttle = throttle;
              this.airspeed = airspeed;
              this.airspeed_sp = airspeed_sp;
              this.groundspeed = groundspeed;
              this.climb_rate = climb_rate;
              this.gps_nsat = gps_nsat;
              this.gps_fix_type = gps_fix_type;
              this.battery_remaining = battery_remaining;
              this.temperature = temperature;
              this.temperature_air = temperature_air;
              this.failsafe = failsafe;
              this.wp_num = wp_num;
            
        }
        /// <summary>A bitfield for use for autopilot-specific flags.   bitmask</summary>
        [Units("")]
        [Description("A bitfield for use for autopilot-specific flags.")]
        public  uint custom_mode;
            /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int latitude;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int longitude;
            /// <summary>roll  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("roll")]
        public  short roll;
            /// <summary>pitch  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("pitch")]
        public  short pitch;
            /// <summary>heading  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("heading")]
        public  ushort heading;
            /// <summary>heading setpoint  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("heading setpoint")]
        public  short heading_sp;
            /// <summary>Altitude above mean sea level  [m] </summary>
        [Units("[m]")]
        [Description("Altitude above mean sea level")]
        public  short altitude_amsl;
            /// <summary>Altitude setpoint relative to the home position  [m] </summary>
        [Units("[m]")]
        [Description("Altitude setpoint relative to the home position")]
        public  short altitude_sp;
            /// <summary>distance to target  [m] </summary>
        [Units("[m]")]
        [Description("distance to target")]
        public  ushort wp_distance;
            /// <summary>Bitmap of enabled system modes. MAV_MODE_FLAG  bitmask</summary>
        [Units("")]
        [Description("Bitmap of enabled system modes.")]
        public  /*MAV_MODE_FLAG*/byte base_mode;
            /// <summary>The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown. MAV_LANDED_STATE  </summary>
        [Units("")]
        [Description("The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown.")]
        public  /*MAV_LANDED_STATE*/byte landed_state;
            /// <summary>throttle (percentage)  [%] </summary>
        [Units("[%]")]
        [Description("throttle (percentage)")]
        public  sbyte throttle;
            /// <summary>airspeed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("airspeed")]
        public  byte airspeed;
            /// <summary>airspeed setpoint  [m/s] </summary>
        [Units("[m/s]")]
        [Description("airspeed setpoint")]
        public  byte airspeed_sp;
            /// <summary>groundspeed  [m/s] </summary>
        [Units("[m/s]")]
        [Description("groundspeed")]
        public  byte groundspeed;
            /// <summary>climb rate  [m/s] </summary>
        [Units("[m/s]")]
        [Description("climb rate")]
        public  sbyte climb_rate;
            /// <summary>Number of satellites visible. If unknown, set to UINT8_MAX   </summary>
        [Units("")]
        [Description("Number of satellites visible. If unknown, set to UINT8_MAX")]
        public  byte gps_nsat;
            /// <summary>GPS Fix type. GPS_FIX_TYPE  </summary>
        [Units("")]
        [Description("GPS Fix type.")]
        public  /*GPS_FIX_TYPE*/byte gps_fix_type;
            /// <summary>Remaining battery (percentage)  [%] </summary>
        [Units("[%]")]
        [Description("Remaining battery (percentage)")]
        public  byte battery_remaining;
            /// <summary>Autopilot temperature (degrees C)  [degC] </summary>
        [Units("[degC]")]
        [Description("Autopilot temperature (degrees C)")]
        public  sbyte temperature;
            /// <summary>Air temperature (degrees C) from airspeed sensor  [degC] </summary>
        [Units("[degC]")]
        [Description("Air temperature (degrees C) from airspeed sensor")]
        public  sbyte temperature_air;
            /// <summary>failsafe (each bit represents a failsafe where 0=ok, 1=failsafe active (bit0:RC, bit1:batt, bit2:GPS, bit3:GCS, bit4:fence)   </summary>
        [Units("")]
        [Description("failsafe (each bit represents a failsafe where 0=ok, 1=failsafe active (bit0:RC, bit1:batt, bit2:GPS, bit3:GCS, bit4:fence)")]
        public  byte failsafe;
            /// <summary>current waypoint number   </summary>
        [Units("")]
        [Description("current waypoint number")]
        public  byte wp_num;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=42)]
    ///<summary> Message appropriate for high latency connections like Iridium (version 2) </summary>
    public struct mavlink_high_latency2_t
    {
        public mavlink_high_latency2_t(uint timestamp,int latitude,int longitude,ushort custom_mode,short altitude,short target_altitude,ushort target_distance,ushort wp_num,/*HL_FAILURE_FLAG*/ushort failure_flags,/*MAV_TYPE*/byte type,/*MAV_AUTOPILOT*/byte autopilot,byte heading,byte target_heading,byte throttle,byte airspeed,byte airspeed_sp,byte groundspeed,byte windspeed,byte wind_heading,byte eph,byte epv,sbyte temperature_air,sbyte climb_rate,sbyte battery,sbyte custom0,sbyte custom1,sbyte custom2) 
        {
              this.timestamp = timestamp;
              this.latitude = latitude;
              this.longitude = longitude;
              this.custom_mode = custom_mode;
              this.altitude = altitude;
              this.target_altitude = target_altitude;
              this.target_distance = target_distance;
              this.wp_num = wp_num;
              this.failure_flags = failure_flags;
              this.type = type;
              this.autopilot = autopilot;
              this.heading = heading;
              this.target_heading = target_heading;
              this.throttle = throttle;
              this.airspeed = airspeed;
              this.airspeed_sp = airspeed_sp;
              this.groundspeed = groundspeed;
              this.windspeed = windspeed;
              this.wind_heading = wind_heading;
              this.eph = eph;
              this.epv = epv;
              this.temperature_air = temperature_air;
              this.climb_rate = climb_rate;
              this.battery = battery;
              this.custom0 = custom0;
              this.custom1 = custom1;
              this.custom2 = custom2;
            
        }
        /// <summary>Timestamp (milliseconds since boot or Unix epoch)  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (milliseconds since boot or Unix epoch)")]
        public  uint timestamp;
            /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int latitude;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int longitude;
            /// <summary>A bitfield for use for autopilot-specific flags (2 byte version).   bitmask</summary>
        [Units("")]
        [Description("A bitfield for use for autopilot-specific flags (2 byte version).")]
        public  ushort custom_mode;
            /// <summary>Altitude above mean sea level  [m] </summary>
        [Units("[m]")]
        [Description("Altitude above mean sea level")]
        public  short altitude;
            /// <summary>Altitude setpoint  [m] </summary>
        [Units("[m]")]
        [Description("Altitude setpoint")]
        public  short target_altitude;
            /// <summary>Distance to target waypoint or position  [dam] </summary>
        [Units("[dam]")]
        [Description("Distance to target waypoint or position")]
        public  ushort target_distance;
            /// <summary>Current waypoint number   </summary>
        [Units("")]
        [Description("Current waypoint number")]
        public  ushort wp_num;
            /// <summary>Bitmap of failure flags. HL_FAILURE_FLAG  bitmask</summary>
        [Units("")]
        [Description("Bitmap of failure flags.")]
        public  /*HL_FAILURE_FLAG*/ushort failure_flags;
            /// <summary>Type of the MAV (quadrotor, helicopter, etc.) MAV_TYPE  </summary>
        [Units("")]
        [Description("Type of the MAV (quadrotor, helicopter, etc.)")]
        public  /*MAV_TYPE*/byte type;
            /// <summary>Autopilot type / class. Use MAV_AUTOPILOT_INVALID for components that are not flight controllers. MAV_AUTOPILOT  </summary>
        [Units("")]
        [Description("Autopilot type / class. Use MAV_AUTOPILOT_INVALID for components that are not flight controllers.")]
        public  /*MAV_AUTOPILOT*/byte autopilot;
            /// <summary>Heading  [deg/2] </summary>
        [Units("[deg/2]")]
        [Description("Heading")]
        public  byte heading;
            /// <summary>Heading setpoint  [deg/2] </summary>
        [Units("[deg/2]")]
        [Description("Heading setpoint")]
        public  byte target_heading;
            /// <summary>Throttle  [%] </summary>
        [Units("[%]")]
        [Description("Throttle")]
        public  byte throttle;
            /// <summary>Airspeed  [m/s*5] </summary>
        [Units("[m/s*5]")]
        [Description("Airspeed")]
        public  byte airspeed;
            /// <summary>Airspeed setpoint  [m/s*5] </summary>
        [Units("[m/s*5]")]
        [Description("Airspeed setpoint")]
        public  byte airspeed_sp;
            /// <summary>Groundspeed  [m/s*5] </summary>
        [Units("[m/s*5]")]
        [Description("Groundspeed")]
        public  byte groundspeed;
            /// <summary>Windspeed  [m/s*5] </summary>
        [Units("[m/s*5]")]
        [Description("Windspeed")]
        public  byte windspeed;
            /// <summary>Wind heading  [deg/2] </summary>
        [Units("[deg/2]")]
        [Description("Wind heading")]
        public  byte wind_heading;
            /// <summary>Maximum error horizontal position since last message  [dm] </summary>
        [Units("[dm]")]
        [Description("Maximum error horizontal position since last message")]
        public  byte eph;
            /// <summary>Maximum error vertical position since last message  [dm] </summary>
        [Units("[dm]")]
        [Description("Maximum error vertical position since last message")]
        public  byte epv;
            /// <summary>Air temperature from airspeed sensor  [degC] </summary>
        [Units("[degC]")]
        [Description("Air temperature from airspeed sensor")]
        public  sbyte temperature_air;
            /// <summary>Maximum climb rate magnitude since last message  [dm/s] </summary>
        [Units("[dm/s]")]
        [Description("Maximum climb rate magnitude since last message")]
        public  sbyte climb_rate;
            /// <summary>Battery level (-1 if field not provided).  [%] </summary>
        [Units("[%]")]
        [Description("Battery level (-1 if field not provided).")]
        public  sbyte battery;
            /// <summary>Field for custom payload.   </summary>
        [Units("")]
        [Description("Field for custom payload.")]
        public  sbyte custom0;
            /// <summary>Field for custom payload.   </summary>
        [Units("")]
        [Description("Field for custom payload.")]
        public  sbyte custom1;
            /// <summary>Field for custom payload.   </summary>
        [Units("")]
        [Description("Field for custom payload.")]
        public  sbyte custom2;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    ///<summary> Vibration levels and accelerometer clipping </summary>
    public struct mavlink_vibration_t
    {
        public mavlink_vibration_t(ulong time_usec,float vibration_x,float vibration_y,float vibration_z,uint clipping_0,uint clipping_1,uint clipping_2) 
        {
              this.time_usec = time_usec;
              this.vibration_x = vibration_x;
              this.vibration_y = vibration_y;
              this.vibration_z = vibration_z;
              this.clipping_0 = clipping_0;
              this.clipping_1 = clipping_1;
              this.clipping_2 = clipping_2;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>Vibration levels on X-axis   </summary>
        [Units("")]
        [Description("Vibration levels on X-axis")]
        public  float vibration_x;
            /// <summary>Vibration levels on Y-axis   </summary>
        [Units("")]
        [Description("Vibration levels on Y-axis")]
        public  float vibration_y;
            /// <summary>Vibration levels on Z-axis   </summary>
        [Units("")]
        [Description("Vibration levels on Z-axis")]
        public  float vibration_z;
            /// <summary>first accelerometer clipping count   </summary>
        [Units("")]
        [Description("first accelerometer clipping count")]
        public  uint clipping_0;
            /// <summary>second accelerometer clipping count   </summary>
        [Units("")]
        [Description("second accelerometer clipping count")]
        public  uint clipping_1;
            /// <summary>third accelerometer clipping count   </summary>
        [Units("")]
        [Description("third accelerometer clipping count")]
        public  uint clipping_2;
    
    };

    
    /// extensions_start 10
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=52)]
    ///<summary>  	Contains the home position. 	The home position is the default position that the system will return to and land on. 	The position must be set automatically by the system during the takeoff, and may also be explicitly set using MAV_CMD_DO_SET_HOME. 	The global and local positions encode the position in the respective coordinate frames, while the q parameter encodes the orientation of the surface. 	Under normal conditions it describes the heading and terrain slope, which can be used by the aircraft to adjust the approach. 	The approach 3D vector describes the point to which the system should fly in normal flight mode and then perform a landing sequence along the vector.         Note: this message can be requested by sending the MAV_CMD_REQUEST_MESSAGE with param1=242 (or the deprecated MAV_CMD_GET_HOME_POSITION command).        </summary>
    public struct mavlink_home_position_t
    {
        public mavlink_home_position_t(int latitude,int longitude,int altitude,float x,float y,float z,float[] q,float approach_x,float approach_y,float approach_z) 
        {
              this.latitude = latitude;
              this.longitude = longitude;
              this.altitude = altitude;
              this.x = x;
              this.y = y;
              this.z = z;
              this.q = q;
              this.approach_x = approach_x;
              this.approach_y = approach_y;
              this.approach_z = approach_z;
            
        }
        /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int latitude;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int longitude;
            /// <summary>Altitude (MSL). Positive for up.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  int altitude;
            /// <summary>Local X position of this position in the local coordinate frame (NED)  [m] </summary>
        [Units("[m]")]
        [Description("Local X position of this position in the local coordinate frame (NED)")]
        public  float x;
            /// <summary>Local Y position of this position in the local coordinate frame (NED)  [m] </summary>
        [Units("[m]")]
        [Description("Local Y position of this position in the local coordinate frame (NED)")]
        public  float y;
            /// <summary>Local Z position of this position in the local coordinate frame (NED: positive 'down')  [m] </summary>
        [Units("[m]")]
        [Description("Local Z position of this position in the local coordinate frame (NED: positive 'down')")]
        public  float z;
            /// <summary>World to surface normal and heading transformation of the takeoff position. Used to indicate the heading and slope of the ground   </summary>
        [Units("")]
        [Description("World to surface normal and heading transformation of the takeoff position. Used to indicate the heading and slope of the ground")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>Local X position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.  [m] </summary>
        [Units("[m]")]
        [Description("Local X position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.")]
        public  float approach_x;
            /// <summary>Local Y position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.  [m] </summary>
        [Units("[m]")]
        [Description("Local Y position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.")]
        public  float approach_y;
            /// <summary>Local Z position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.  [m] </summary>
        [Units("[m]")]
        [Description("Local Z position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.")]
        public  float approach_z;
    
    };

    
    /// extensions_start 11
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=53)]
    ///<summary>          Sets the home position. 	The home position is the default position that the system will return to and land on.         The position is set automatically by the system during the takeoff (and may also be set using this message).         The global and local positions encode the position in the respective coordinate frames, while the q parameter encodes the orientation of the surface.         Under normal conditions it describes the heading and terrain slope, which can be used by the aircraft to adjust the approach.         The approach 3D vector describes the point to which the system should fly in normal flight mode and then perform a landing sequence along the vector.         Note: the current home position may be emitted in a HOME_POSITION message on request (using MAV_CMD_REQUEST_MESSAGE with param1=242).        </summary>
    public struct mavlink_set_home_position_t
    {
        public mavlink_set_home_position_t(int latitude,int longitude,int altitude,float x,float y,float z,float[] q,float approach_x,float approach_y,float approach_z,byte target_system) 
        {
              this.latitude = latitude;
              this.longitude = longitude;
              this.altitude = altitude;
              this.x = x;
              this.y = y;
              this.z = z;
              this.q = q;
              this.approach_x = approach_x;
              this.approach_y = approach_y;
              this.approach_z = approach_z;
              this.target_system = target_system;
            
        }
        /// <summary>Latitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude (WGS84)")]
        public  int latitude;
            /// <summary>Longitude (WGS84)  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude (WGS84)")]
        public  int longitude;
            /// <summary>Altitude (MSL). Positive for up.  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude (MSL). Positive for up.")]
        public  int altitude;
            /// <summary>Local X position of this position in the local coordinate frame (NED)  [m] </summary>
        [Units("[m]")]
        [Description("Local X position of this position in the local coordinate frame (NED)")]
        public  float x;
            /// <summary>Local Y position of this position in the local coordinate frame (NED)  [m] </summary>
        [Units("[m]")]
        [Description("Local Y position of this position in the local coordinate frame (NED)")]
        public  float y;
            /// <summary>Local Z position of this position in the local coordinate frame (NED: positive 'down')  [m] </summary>
        [Units("[m]")]
        [Description("Local Z position of this position in the local coordinate frame (NED: positive 'down')")]
        public  float z;
            /// <summary>World to surface normal and heading transformation of the takeoff position. Used to indicate the heading and slope of the ground   </summary>
        [Units("")]
        [Description("World to surface normal and heading transformation of the takeoff position. Used to indicate the heading and slope of the ground")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=4)]
		public float[] q;
            /// <summary>Local X position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.  [m] </summary>
        [Units("[m]")]
        [Description("Local X position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.")]
        public  float approach_x;
            /// <summary>Local Y position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.  [m] </summary>
        [Units("[m]")]
        [Description("Local Y position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.")]
        public  float approach_y;
            /// <summary>Local Z position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.  [m] </summary>
        [Units("[m]")]
        [Description("Local Z position of the end of the approach vector. Multicopters should set this position based on their takeoff path. Grass-landing fixed wing aircraft should set it the same way as multicopters. Runway-landing fixed wing aircraft should set it to the opposite direction of the takeoff, assuming the takeoff happened from the threshold / touchdown zone.")]
        public  float approach_z;
            /// <summary>System ID.   </summary>
        [Units("")]
        [Description("System ID.")]
        public  byte target_system;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=6)]
    ///<summary>          The interval between messages for a particular MAVLink message ID.         This message is sent in response to the MAV_CMD_REQUEST_MESSAGE command with param1=244 (this message) and param2=message_id (the id of the message for which the interval is required). 	It may also be sent in response to MAV_CMD_GET_MESSAGE_INTERVAL. 	This interface replaces DATA_STREAM. </summary>
    public struct mavlink_message_interval_t
    {
        public mavlink_message_interval_t(int interval_us,ushort message_id) 
        {
              this.interval_us = interval_us;
              this.message_id = message_id;
            
        }
        /// <summary>The interval between two messages. A value of -1 indicates this stream is disabled, 0 indicates it is not available, > 0 indicates the interval at which it is sent.  [us] </summary>
        [Units("[us]")]
        [Description("The interval between two messages. A value of -1 indicates this stream is disabled, 0 indicates it is not available, > 0 indicates the interval at which it is sent.")]
        public  int interval_us;
            /// <summary>The ID of the requested MAVLink message. v1.0 is limited to 254 messages.   </summary>
        [Units("")]
        [Description("The ID of the requested MAVLink message. v1.0 is limited to 254 messages.")]
        public  ushort message_id;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    ///<summary> Provides state for additional features </summary>
    public struct mavlink_extended_sys_state_t
    {
        public mavlink_extended_sys_state_t(/*MAV_VTOL_STATE*/byte vtol_state,/*MAV_LANDED_STATE*/byte landed_state) 
        {
              this.vtol_state = vtol_state;
              this.landed_state = landed_state;
            
        }
        /// <summary>The VTOL state if applicable. Is set to MAV_VTOL_STATE_UNDEFINED if UAV is not in VTOL configuration. MAV_VTOL_STATE  </summary>
        [Units("")]
        [Description("The VTOL state if applicable. Is set to MAV_VTOL_STATE_UNDEFINED if UAV is not in VTOL configuration.")]
        public  /*MAV_VTOL_STATE*/byte vtol_state;
            /// <summary>The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown. MAV_LANDED_STATE  </summary>
        [Units("")]
        [Description("The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown.")]
        public  /*MAV_LANDED_STATE*/byte landed_state;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=38)]
    ///<summary> The location and information of an ADSB vehicle </summary>
    public struct mavlink_adsb_vehicle_t
    {
        public mavlink_adsb_vehicle_t(uint ICAO_address,int lat,int lon,int altitude,ushort heading,ushort hor_velocity,short ver_velocity,/*ADSB_FLAGS*/ushort flags,ushort squawk,/*ADSB_ALTITUDE_TYPE*/byte altitude_type,byte[] callsign,/*ADSB_EMITTER_TYPE*/byte emitter_type,byte tslc) 
        {
              this.ICAO_address = ICAO_address;
              this.lat = lat;
              this.lon = lon;
              this.altitude = altitude;
              this.heading = heading;
              this.hor_velocity = hor_velocity;
              this.ver_velocity = ver_velocity;
              this.flags = flags;
              this.squawk = squawk;
              this.altitude_type = altitude_type;
              this.callsign = callsign;
              this.emitter_type = emitter_type;
              this.tslc = tslc;
            
        }
        /// <summary>ICAO address   </summary>
        [Units("")]
        [Description("ICAO address")]
        public  uint ICAO_address;
            /// <summary>Latitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Latitude")]
        public  int lat;
            /// <summary>Longitude  [degE7] </summary>
        [Units("[degE7]")]
        [Description("Longitude")]
        public  int lon;
            /// <summary>Altitude(ASL)  [mm] </summary>
        [Units("[mm]")]
        [Description("Altitude(ASL)")]
        public  int altitude;
            /// <summary>Course over ground  [cdeg] </summary>
        [Units("[cdeg]")]
        [Description("Course over ground")]
        public  ushort heading;
            /// <summary>The horizontal velocity  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("The horizontal velocity")]
        public  ushort hor_velocity;
            /// <summary>The vertical velocity. Positive is up  [cm/s] </summary>
        [Units("[cm/s]")]
        [Description("The vertical velocity. Positive is up")]
        public  short ver_velocity;
            /// <summary>Bitmap to indicate various statuses including valid data fields ADSB_FLAGS  bitmask</summary>
        [Units("")]
        [Description("Bitmap to indicate various statuses including valid data fields")]
        public  /*ADSB_FLAGS*/ushort flags;
            /// <summary>Squawk code   </summary>
        [Units("")]
        [Description("Squawk code")]
        public  ushort squawk;
            /// <summary>ADSB altitude type. ADSB_ALTITUDE_TYPE  </summary>
        [Units("")]
        [Description("ADSB altitude type.")]
        public  /*ADSB_ALTITUDE_TYPE*/byte altitude_type;
            /// <summary>The callsign, 8+null   </summary>
        [Units("")]
        [Description("The callsign, 8+null")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=9)]
		public byte[] callsign;
            /// <summary>ADSB emitter type. ADSB_EMITTER_TYPE  </summary>
        [Units("")]
        [Description("ADSB emitter type.")]
        public  /*ADSB_EMITTER_TYPE*/byte emitter_type;
            /// <summary>Time since last communication in seconds  [s] </summary>
        [Units("[s]")]
        [Description("Time since last communication in seconds")]
        public  byte tslc;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=19)]
    ///<summary> Information about a potential collision </summary>
    public struct mavlink_collision_t
    {
        public mavlink_collision_t(uint id,float time_to_minimum_delta,float altitude_minimum_delta,float horizontal_minimum_delta,/*MAV_COLLISION_SRC*/byte src,/*MAV_COLLISION_ACTION*/byte action,/*MAV_COLLISION_THREAT_LEVEL*/byte threat_level) 
        {
              this.id = id;
              this.time_to_minimum_delta = time_to_minimum_delta;
              this.altitude_minimum_delta = altitude_minimum_delta;
              this.horizontal_minimum_delta = horizontal_minimum_delta;
              this.src = src;
              this.action = action;
              this.threat_level = threat_level;
            
        }
        /// <summary>Unique identifier, domain based on src field   </summary>
        [Units("")]
        [Description("Unique identifier, domain based on src field")]
        public  uint id;
            /// <summary>Estimated time until collision occurs  [s] </summary>
        [Units("[s]")]
        [Description("Estimated time until collision occurs")]
        public  float time_to_minimum_delta;
            /// <summary>Closest vertical distance between vehicle and object  [m] </summary>
        [Units("[m]")]
        [Description("Closest vertical distance between vehicle and object")]
        public  float altitude_minimum_delta;
            /// <summary>Closest horizontal distance between vehicle and object  [m] </summary>
        [Units("[m]")]
        [Description("Closest horizontal distance between vehicle and object")]
        public  float horizontal_minimum_delta;
            /// <summary>Collision data source MAV_COLLISION_SRC  </summary>
        [Units("")]
        [Description("Collision data source")]
        public  /*MAV_COLLISION_SRC*/byte src;
            /// <summary>Action that is being taken to avoid this collision MAV_COLLISION_ACTION  </summary>
        [Units("")]
        [Description("Action that is being taken to avoid this collision")]
        public  /*MAV_COLLISION_ACTION*/byte action;
            /// <summary>How concerned the aircraft is about this collision MAV_COLLISION_THREAT_LEVEL  </summary>
        [Units("")]
        [Description("How concerned the aircraft is about this collision")]
        public  /*MAV_COLLISION_THREAT_LEVEL*/byte threat_level;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=254)]
    ///<summary> Message implementing parts of the V2 payload specs in V1 frames for transitional support. </summary>
    public struct mavlink_v2_extension_t
    {
        public mavlink_v2_extension_t(ushort message_type,byte target_network,byte target_system,byte target_component,byte[] payload) 
        {
              this.message_type = message_type;
              this.target_network = target_network;
              this.target_system = target_system;
              this.target_component = target_component;
              this.payload = payload;
            
        }
        /// <summary>A code that identifies the software component that understands this message (analogous to USB device classes or mime type strings). If this code is less than 32768, it is considered a 'registered' protocol extension and the corresponding entry should be added to https://github.com/mavlink/mavlink/definition_files/extension_message_ids.xml. Software creators can register blocks of message IDs as needed (useful for GCS specific metadata, etc...). Message_types greater than 32767 are considered local experiments and should not be checked in to any widely distributed codebase.   </summary>
        [Units("")]
        [Description("A code that identifies the software component that understands this message (analogous to USB device classes or mime type strings). If this code is less than 32768, it is considered a 'registered' protocol extension and the corresponding entry should be added to https://github.com/mavlink/mavlink/definition_files/extension_message_ids.xml. Software creators can register blocks of message IDs as needed (useful for GCS specific metadata, etc...). Message_types greater than 32767 are considered local experiments and should not be checked in to any widely distributed codebase.")]
        public  ushort message_type;
            /// <summary>Network ID (0 for broadcast)   </summary>
        [Units("")]
        [Description("Network ID (0 for broadcast)")]
        public  byte target_network;
            /// <summary>System ID (0 for broadcast)   </summary>
        [Units("")]
        [Description("System ID (0 for broadcast)")]
        public  byte target_system;
            /// <summary>Component ID (0 for broadcast)   </summary>
        [Units("")]
        [Description("Component ID (0 for broadcast)")]
        public  byte target_component;
            /// <summary>Variable length payload. The length must be encoded in the payload as part of the message_type protocol, e.g. by including the length as payload data, or by terminating the payload data with a non-zero marker. This is required in order to reconstruct zero-terminated payloads that are (or otherwise would be) trimmed by MAVLink 2 empty-byte truncation. The entire content of the payload block is opaque unless you understand the encoding message_type. The particular encoding used can be extension specific and might not always be documented as part of the MAVLink specification.   </summary>
        [Units("")]
        [Description("Variable length payload. The length must be encoded in the payload as part of the message_type protocol, e.g. by including the length as payload data, or by terminating the payload data with a non-zero marker. This is required in order to reconstruct zero-terminated payloads that are (or otherwise would be) trimmed by MAVLink 2 empty-byte truncation. The entire content of the payload block is opaque unless you understand the encoding message_type. The particular encoding used can be extension specific and might not always be documented as part of the MAVLink specification.")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=249)]
		public byte[] payload;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    ///<summary> Send raw controller memory. The use of this message is discouraged for normal packets, but a quite efficient way for testing new messages and getting experimental debug output. </summary>
    public struct mavlink_memory_vect_t
    {
        public mavlink_memory_vect_t(ushort address,byte ver,byte type,sbyte[] value) 
        {
              this.address = address;
              this.ver = ver;
              this.type = type;
              this.value = value;
            
        }
        /// <summary>Starting address of the debug variables   </summary>
        [Units("")]
        [Description("Starting address of the debug variables")]
        public  ushort address;
            /// <summary>Version code of the type variable. 0=unknown, type ignored and assumed int16_t. 1=as below   </summary>
        [Units("")]
        [Description("Version code of the type variable. 0=unknown, type ignored and assumed int16_t. 1=as below")]
        public  byte ver;
            /// <summary>Type code of the memory variables. for ver = 1: 0=16 x int16_t, 1=16 x uint16_t, 2=16 x Q15, 3=16 x 1Q14   </summary>
        [Units("")]
        [Description("Type code of the memory variables. for ver = 1: 0=16 x int16_t, 1=16 x uint16_t, 2=16 x Q15, 3=16 x 1Q14")]
        public  byte type;
            /// <summary>Memory contents at specified address   </summary>
        [Units("")]
        [Description("Memory contents at specified address")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=32)]
		public sbyte[] value;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=30)]
    ///<summary> To debug something using a named 3D vector. </summary>
    public struct mavlink_debug_vect_t
    {
        public mavlink_debug_vect_t(ulong time_usec,float x,float y,float z,byte[] name) 
        {
              this.time_usec = time_usec;
              this.x = x;
              this.y = y;
              this.z = z;
              this.name = name;
            
        }
        /// <summary>Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.  [us] </summary>
        [Units("[us]")]
        [Description("Timestamp (UNIX Epoch time or time since system boot). The receiving end can infer timestamp format (since 1.1.1970 or since system boot) by checking for the magnitude of the number.")]
        public  ulong time_usec;
            /// <summary>x   </summary>
        [Units("")]
        [Description("x")]
        public  float x;
            /// <summary>y   </summary>
        [Units("")]
        [Description("y")]
        public  float y;
            /// <summary>z   </summary>
        [Units("")]
        [Description("z")]
        public  float z;
            /// <summary>Name   </summary>
        [Units("")]
        [Description("Name")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=10)]
		public byte[] name;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=18)]
    ///<summary> Send a key-value pair as float. The use of this message is discouraged for normal packets, but a quite efficient way for testing new messages and getting experimental debug output. </summary>
    public struct mavlink_named_value_float_t
    {
        public mavlink_named_value_float_t(uint time_boot_ms,float value,byte[] name) 
        {
              this.time_boot_ms = time_boot_ms;
              this.value = value;
              this.name = name;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Floating point value   </summary>
        [Units("")]
        [Description("Floating point value")]
        public  float value;
            /// <summary>Name of the debug variable   </summary>
        [Units("")]
        [Description("Name of the debug variable")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=10)]
		public byte[] name;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=18)]
    ///<summary> Send a key-value pair as integer. The use of this message is discouraged for normal packets, but a quite efficient way for testing new messages and getting experimental debug output. </summary>
    public struct mavlink_named_value_int_t
    {
        public mavlink_named_value_int_t(uint time_boot_ms,int value,byte[] name) 
        {
              this.time_boot_ms = time_boot_ms;
              this.value = value;
              this.name = name;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>Signed integer value   </summary>
        [Units("")]
        [Description("Signed integer value")]
        public  int value;
            /// <summary>Name of the debug variable   </summary>
        [Units("")]
        [Description("Name of the debug variable")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=10)]
		public byte[] name;
    
    };

    
    /// extensions_start 2
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=51)]
    ///<summary> Status text message. These messages are printed in yellow in the COMM console of QGroundControl. WARNING: They consume quite some bandwidth, so use only for important status and error messages. If implemented wisely, these messages are buffered on the MCU and sent only at a limited rate (e.g. 10 Hz). </summary>
    public struct mavlink_statustext_t
    {
        public mavlink_statustext_t(/*MAV_SEVERITY*/byte severity,byte[] text) 
        {
              this.severity = severity;
              this.text = text;
            
        }
        /// <summary>Severity of status. Relies on the definitions within RFC-5424. MAV_SEVERITY  </summary>
        [Units("")]
        [Description("Severity of status. Relies on the definitions within RFC-5424.")]
        public  /*MAV_SEVERITY*/byte severity;
            /// <summary>Status text message, without null termination character   </summary>
        [Units("")]
        [Description("Status text message, without null termination character")]
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=50)]
		public byte[] text;
    
    };

    
    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=9)]
    ///<summary> Send a debug value. The index is used to discriminate between values. These values show up in the plot of QGroundControl as DEBUG N. </summary>
    public struct mavlink_debug_t
    {
        public mavlink_debug_t(uint time_boot_ms,float value,byte ind) 
        {
              this.time_boot_ms = time_boot_ms;
              this.value = value;
              this.ind = ind;
            
        }
        /// <summary>Timestamp (time since system boot).  [ms] </summary>
        [Units("[ms]")]
        [Description("Timestamp (time since system boot).")]
        public  uint time_boot_ms;
            /// <summary>DEBUG value   </summary>
        [Units("")]
        [Description("DEBUG value")]
        public  float value;
            /// <summary>index of debug variable   </summary>
        [Units("")]
        [Description("index of debug variable")]
        public  byte ind;
    
    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 9)]
    ///<summary> The heartbeat message shows that a system or component is present and responding. The type and autopilot fields (along with the message component id), allow the receiving system to treat further messages from this system appropriately (e.g. by laying out the user interface based on the autopilot). This microservice is documented at https://mavlink.io/en/services/heartbeat.html </summary>
    public struct mavlink_heartbeat_t
    {
        public mavlink_heartbeat_t(uint custom_mode,/*MAV_TYPE*/byte type,/*MAV_AUTOPILOT*/byte autopilot,/*MAV_MODE_FLAG*/byte base_mode,/*MAV_STATE*/byte system_status, byte mavlink_version)
        {
            this.custom_mode = custom_mode;
            this.type = type;
            this.autopilot = autopilot;
            this.base_mode = base_mode;
            this.system_status = system_status;
            this.mavlink_version = mavlink_version;

        }
        /// <summary>A bitfield for use for autopilot-specific flags   </summary>
        [Units("")]
        [Description("A bitfield for use for autopilot-specific flags")]
        public uint custom_mode;
        /// <summary>Vehicle or component type. For a flight controller component the vehicle type (quadrotor, helicopter, etc.). For other components the component type (e.g. camera, gimbal, etc.). This should be used in preference to component id for identifying the component type. MAV_TYPE  </summary>
        [Units("")]
        [Description("Vehicle or component type. For a flight controller component the vehicle type (quadrotor, helicopter, etc.). For other components the component type (e.g. camera, gimbal, etc.). This should be used in preference to component id for identifying the component type.")]
        public  /*MAV_TYPE*/byte type;
        /// <summary>Autopilot type / class. Use MAV_AUTOPILOT_INVALID for components that are not flight controllers. MAV_AUTOPILOT  </summary>
        [Units("")]
        [Description("Autopilot type / class. Use MAV_AUTOPILOT_INVALID for components that are not flight controllers.")]
        public  /*MAV_AUTOPILOT*/byte autopilot;
        /// <summary>System mode bitmap. MAV_MODE_FLAG  bitmask</summary>
        [Units("")]
        [Description("System mode bitmap.")]
        public  /*MAV_MODE_FLAG*/byte base_mode;
        /// <summary>System status flag. MAV_STATE  </summary>
        [Units("")]
        [Description("System status flag.")]
        public  /*MAV_STATE*/byte system_status;
        /// <summary>MAVLink version, not writable by user, gets added by protocol because of magic data type: uint8_t_mavlink_version   </summary>
        [Units("")]
        [Description("MAVLink version, not writable by user, gets added by protocol because of magic data type: uint8_t_mavlink_version")]
        public byte mavlink_version;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
    ///<summary>  Bitfield that encodes whether the pumps are active or not. </summary>
    public struct mavlink_control_system_t
    {
        public mavlink_control_system_t(float dac_output, float potentiometer_signal)
        {
            this.dac_output = dac_output;
            this.potentiometer_signal = potentiometer_signal;

        }
        /// <summary>Digital-Analog converter output to control the motor.  [V] </summary>
        [Units("[V]")]
        [Description("Digital-Analog converter output to control the motor.")]
        public float dac_output;
        /// <summary>Potentiometer output to control the motor.  [V] </summary>
        [Units("[V]")]
        [Description("Potentiometer output to control the motor.")]
        public float potentiometer_signal;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
    ///<summary>  Instrumentation data for 3 current sensors and 1 voltage sensor. </summary>
    public struct mavlink_instrumentation_t
    {
        public mavlink_instrumentation_t(float battery_voltage, float motor_current, float battery_current, float mppt_current)
        {
            this.battery_voltage = battery_voltage;
            this.motor_current = motor_current;
            this.battery_current = battery_current;
            this.mppt_current = mppt_current;

        }
        /// <summary>Voltage sensor connected to A0 pin of ADS1115.  [V] </summary>
        [Units("[V]")]
        [Description("Voltage sensor connected to A0 pin of ADS1115.")]
        public float battery_voltage;
        /// <summary>Current sensor connected to A1 pin of ADS1115  [A] </summary>
        [Units("[A]")]
        [Description("Current sensor connected to A1 pin of ADS1115")]
        public float motor_current;
        /// <summary>Current sensor connected to A2 pin of ADS1115.  [A] </summary>
        [Units("[A]")]
        [Description("Current sensor connected to A2 pin of ADS1115.")]
        public float battery_current;
        /// <summary>Current sensor connected to A3 pin of ADS1115.  [A] </summary>
        [Units("[A]")]
        [Description("Current sensor connected to A3 pin of ADS1115.")]
        public float mppt_current;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
    ///<summary>  Temperature data for motor and MPPT. </summary>
    public struct mavlink_temperatures_t
    {
        public mavlink_temperatures_t(float temperature_motor, float temperature_battery, float temperature_mppt)
        {
            this.temperature_motor = temperature_motor;
            this.temperature_battery = temperature_battery;
            this.temperature_mppt = temperature_mppt;

        }
        /// <summary>Motor temperature.  [degC] </summary>
        [Units("[degC]")]
        [Description("Motor temperature.")]
        public float temperature_motor;
        /// <summary>MPPT temperature.  [degC] </summary>
        [Units("[degC]")]
        [Description("MPPT temperature.")]
        public float temperature_battery;
        /// <summary>MPPT temperature.  [degC] </summary>
        [Units("[degC]")]
        [Description("MPPT temperature.")]
        public float temperature_mppt;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 17)]
    ///<summary>  GPS data from NEO-6M module.  </summary>
    public struct mavlink_gps_info_t
    {
        public mavlink_gps_info_t(float latitude, float longitude, float speed, float course, byte satellites_visible)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.speed = speed;
            this.course = course;
            this.satellites_visible = satellites_visible;

        }
        /// <summary>Latitude info. Sixth decimal digit represents 11cm resolution   </summary>
        [Units("")]
        [Description("Latitude info. Sixth decimal digit represents 11cm resolution")]
        public float latitude;
        /// <summary>Longitude info. Sixth decimal digit represents 11cm resolution   </summary>
        [Units("")]
        [Description("Longitude info. Sixth decimal digit represents 11cm resolution")]
        public float longitude;
        /// <summary>Speed  [km/h] </summary>
        [Units("[km/h]")]
        [Description("Speed")]
        public float speed;
        /// <summary>Course  [deg] </summary>
        [Units("[deg]")]
        [Description("Course")]
        public float course;
        /// <summary>Number of visible satellites   </summary>
        [Units("")]
        [Description("Number of visible satellites")]
        public byte satellites_visible;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
    ///<summary>  Data related to auxiliary battery and pumps.  </summary>
    public struct mavlink_aux_system_t
    {
        public mavlink_aux_system_t(float voltage, float current, float pumps)
        {
            this.voltage = voltage;
            this.current = current;
            this.pumps = pumps;

        }
        /// <summary>Voltage of auxiliary battery   </summary>
        [Units("")]
        [Description("Voltage of auxiliary battery")]
        public float voltage;
        /// <summary>Current of auxiliary battery   </summary>
        [Units("")]
        [Description("Current of auxiliary battery")]
        public float current;
        /// <summary>Bitfield that represents the logical state of the pumps   </summary>
        [Units("")]
        [Description("Bitfield that represents the logical state of the pumps")]
        public float pumps;

    };

}
