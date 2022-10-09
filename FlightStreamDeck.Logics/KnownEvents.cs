﻿namespace FlightStreamDeck.Logics
{
    public enum KnownEvents
    {
        THROTTLE_FULL = 100,
        THROTTLE_INCR,
        THROTTLE_INCR_SMALL,
        THROTTLE_DECR,
        THROTTLE_DECR_SMALL,
        THROTTLE_CUT,
        INCREASE_THROTTLE,
        DECREASE_THROTTLE,
        THROTTLE1_FULL,
        THROTTLE1_INCR,
        THROTTLE1_INCR_SMALL,
        THROTTLE1_DECR,
        THROTTLE1_CUT,
        THROTTLE2_FULL,
        THROTTLE2_INCR,
        THROTTLE2_INCR_SMALL,
        THROTTLE2_DECR,
        THROTTLE2_CUT,
        THROTTLE3_FULL,
        THROTTLE3_INCR,
        THROTTLE3_INCR_SMALL,
        THROTTLE3_DECR,
        THROTTLE3_CUT,
        THROTTLE4_FULL,
        THROTTLE4_INCR,
        THROTTLE4_INCR_SMALL,
        THROTTLE4_DECR,
        THROTTLE4_CUT,
        THROTTLE_10,
        THROTTLE_20,
        THROTTLE_30,
        THROTTLE_40,
        THROTTLE_50,
        THROTTLE_60,
        THROTTLE_70,
        THROTTLE_80,
        THROTTLE_90,
        THROTTLE1_DECR_SMALL,
        THROTTLE2_DECR_SMALL,
        THROTTLE3_DECR_SMALL,
        THROTTLE4_DECR_SMALL,
        PROP_PITCH_DECR_SMALL,
        PROP_PITCH1_DECR_SMALL,
        PROP_PITCH2_DECR_SMALL,
        PROP_PITCH3_DECR_SMALL,
        PROP_PITCH4_DECR_SMALL,
        MIXTURE1_RICH,
        MIXTURE1_INCR,
        MIXTURE1_INCR_SMALL,
        MIXTURE1_DECR,
        MIXTURE1_LEAN,
        MIXTURE2_RICH,
        MIXTURE2_INCR,
        MIXTURE2_INCR_SMALL,
        MIXTURE2_DECR,
        MIXTURE2_LEAN,
        MIXTURE3_RICH,
        MIXTURE3_INCR,
        MIXTURE3_INCR_SMALL,
        MIXTURE3_DECR,
        MIXTURE3_LEAN,
        MIXTURE4_RICH,
        MIXTURE4_INCR,
        MIXTURE4_INCR_SMALL,
        MIXTURE4_DECR,
        MIXTURE4_LEAN,
        MIXTURE_RICH,
        MIXTURE_INCR,
        MIXTURE_INCR_SMALL,
        MIXTURE_DECR,
        MIXTURE_LEAN,
        MIXTURE_DECR_SMALL,
        MIXTURE1_DECR_SMALL,
        MIXTURE2_DECR_SMALL,
        MIXTURE3_DECR_SMALL,
        MIXTURE4_DECR_SMALL,
        PROP_PITCH_LO,
        PROP_PITCH_INCR,
        PROP_PITCH_INCR_SMALL,
        PROP_PITCH_DECR,
        PROP_PITCH_HI,
        PROP_PITCH1_LO,
        PROP_PITCH1_INCR,
        PROP_PITCH1_INCR_SMALL,
        PROP_PITCH1_DECR,
        PROP_PITCH1_HI,
        PROP_PITCH2_LO,
        PROP_PITCH2_INCR,
        PROP_PITCH2_INCR_SMALL,
        PROP_PITCH2_DECR,
        PROP_PITCH2_HI,
        PROP_PITCH3_LO,
        PROP_PITCH3_INCR,
        PROP_PITCH3_INCR_SMALL,
        PROP_PITCH3_DECR,
        PROP_PITCH3_HI,
        PROP_PITCH4_LO,
        PROP_PITCH4_INCR,
        PROP_PITCH4_INCR_SMALL,
        PROP_PITCH4_DECR,
        PROP_PITCH4_HI,
        JET_STARTER,
        TOGGLE_STARTER1,
        TOGGLE_STARTER2,
        TOGGLE_STARTER3,
        TOGGLE_STARTER4,
        TOGGLE_ALL_STARTERS,
        ENGINE_AUTO_START,
        ENGINE_AUTO_SHUTDOWN,
        MAGNETO,
        MAGNETO_DECR,
        MAGNETO_INCR,
        MAGNETO1_OFF,
        MAGNETO1_RIGHT,
        MAGNETO1_LEFT,
        MAGNETO1_BOTH,
        MAGNETO1_START,
        MAGNETO2_OFF,
        MAGNETO2_RIGHT,
        MAGNETO2_LEFT,
        MAGNETO2_BOTH,
        MAGNETO2_START,
        MAGNETO3_OFF,
        MAGNETO3_RIGHT,
        MAGNETO3_LEFT,
        MAGNETO3_BOTH,
        MAGNETO3_START,
        MAGNETO4_OFF,
        MAGNETO4_RIGHT,
        MAGNETO4_LEFT,
        MAGNETO4_BOTH,
        MAGNETO4_START,
        MAGNETO_OFF,
        MAGNETO_RIGHT,
        MAGNETO_LEFT,
        MAGNETO_BOTH,
        MAGNETO_START,
        MAGNETO1_DECR,
        MAGNETO1_INCR,
        MAGNETO2_DECR,
        MAGNETO2_INCR,
        MAGNETO3_DECR,
        MAGNETO3_INCR,
        MAGNETO4_DECR,
        MAGNETO4_INCR,
        ANTI_ICE_ON,
        ANTI_ICE_OFF,
        ANTI_ICE_TOGGLE,
        ANTI_ICE_TOGGLE_ENG1,
        ANTI_ICE_TOGGLE_ENG2,
        ANTI_ICE_TOGGLE_ENG3,
        ANTI_ICE_TOGGLE_ENG4,
        TOGGLE_FUEL_VALVE_ALL,
        TOGGLE_FUEL_VALVE_ENG1,
        TOGGLE_FUEL_VALVE_ENG2,
        TOGGLE_FUEL_VALVE_ENG3,
        TOGGLE_FUEL_VALVE_ENG4,
        INC_COWL_FLAPS,
        DEC_COWL_FLAPS,
        INC_COWL_FLAPS1,
        DEC_COWL_FLAPS1,
        INC_COWL_FLAPS2,
        DEC_COWL_FLAPS2,
        INC_COWL_FLAPS3,
        DEC_COWL_FLAPS3,
        INC_COWL_FLAPS4,
        DEC_COWL_FLAPS4,
        FUEL_PUMP,
        TOGGLE_ELECT_FUEL_PUMP,
        TOGGLE_ELECT_FUEL_PUMP1,
        TOGGLE_ELECT_FUEL_PUMP2,
        TOGGLE_ELECT_FUEL_PUMP3,
        TOGGLE_ELECT_FUEL_PUMP4,
        ENGINE_PRIMER,
        TOGGLE_PRIMER,
        TOGGLE_PRIMER1,
        TOGGLE_PRIMER2,
        TOGGLE_PRIMER3,
        TOGGLE_PRIMER4,
        TOGGLE_FEATHER_SWITCHES,
        TOGGLE_FEATHER_SWITCH_1,
        TOGGLE_FEATHER_SWITCH_2,
        TOGGLE_FEATHER_SWITCH_3,
        TOGGLE_FEATHER_SWITCH_4,
        TOGGLE_PROPELLER_SYNC,
        TOGGLE_AUTOFEATHER_ARM,
        TOGGLE_AFTERBURNER,
        TOGGLE_AFTERBURNER1,
        TOGGLE_AFTERBURNER2,
        TOGGLE_AFTERBURNER3,
        TOGGLE_AFTERBURNER4,
        ENGINE,
        SPOILERS_TOGGLE,
        FLAPS_UP,
        FLAPS_1,
        FLAPS_2,
        FLAPS_3,
        FLAPS_DOWN,
        ELEV_TRIM_DN,
        ELEV_DOWN,
        AILERONS_LEFT,
        CENTER_AILER_RUDDER,
        AILERONS_RIGHT,
        ELEV_TRIM_UP,
        ELEV_UP,
        RUDDER_LEFT,
        RUDDER_CENTER,
        RUDDER_RIGHT,
        FLAPS_INCR,
        FLAPS_DECR,
        SPOILERS_ARM_TOGGLE,
        SPOILERS_ON,
        SPOILERS_OFF,
        SPOILERS_ARM_ON,
        SPOILERS_ARM_OFF,
        AILERON_TRIM_LEFT,
        AILERON_TRIM_RIGHT,
        RUDDER_TRIM_LEFT,
        RUDDER_TRIM_RIGHT,
        AP_MASTER,
        AUTOPILOT_OFF,
        AUTOPILOT_ON,
        YAW_DAMPER_TOGGLE,
        AP_PANEL_HEADING_HOLD,
        AP_PANEL_ALTITUDE_HOLD,
        AP_ATT_HOLD_ON,
        AP_LOC_HOLD_ON,
        AP_APR_HOLD_ON,
        AP_HDG_HOLD_ON,
        AP_ALT_HOLD_ON,
        AP_WING_LEVELER_ON,
        AP_BC_HOLD_ON,
        AP_NAV1_HOLD_ON,
        AP_ATT_HOLD_OFF,
        AP_LOC_HOLD_OFF,
        AP_APR_HOLD_OFF,
        AP_HDG_HOLD_OFF,
        AP_ALT_HOLD_OFF,
        AP_WING_LEVELER_OFF,
        AP_BC_HOLD_OFF,
        AP_NAV1_HOLD_OFF,
        AP_AIRSPEED_HOLD,
        FLIGHT_LEVEL_CHANGE_ON,
        FLIGHT_LEVEL_CHANGE_OFF,
        AUTO_THROTTLE_ARM,
        AUTO_THROTTLE_TO_GA,
        HEADING_BUG_INC,
        HEADING_BUG_DEC,
        AP_PANEL_SPEED_HOLD,
        AP_ALT_VAR_INC,
        AP_ALT_VAR_DEC,
        AP_VS_VAR_INC,
        AP_VS_VAR_DEC,
        AP_VS_HOLD,
        AP_VS_ON,
        AP_VS_OFF,
        AP_PANEL_VS_ON,
        AP_PANEL_VS_OFF,
        AP_SPD_VAR_INC,
        AP_SPD_VAR_DEC,
        AP_PANEL_MACH_HOLD,
        AP_MACH_VAR_INC,
        AP_MACH_VAR_DEC,
        AP_MACH_HOLD,
        YAW_DAMPER_ON,
        YAW_DAMPER_OFF,
        AP_AIRSPEED_ON,
        AP_AIRSPEED_OFF,
        AP_MACH_ON,
        AP_MACH_OFF,
        AP_PANEL_ALTITUDE_ON,
        AP_PANEL_ALTITUDE_OFF,
        AP_PANEL_HEADING_ON,
        AP_PANEL_HEADING_OFF,
        AP_PANEL_MACH_ON,
        AP_PANEL_MACH_OFF,
        AP_PANEL_SPEED_ON,
        AP_PANEL_SPEED_OFF,
        TOGGLE_FLIGHT_DIRECTOR,
        SYNC_FLIGHT_DIRECTOR_PITCH,
        INCREASE_AUTOBRAKE_CONTROL,
        DECREASE_AUTOBRAKE_CONTROL,
        AP_PANEL_SPEED_HOLD_TOGGLE,
        AP_PANEL_MACH_HOLD_TOGGLE,
        HEADING_BUG_SELECT,
        ALTITUDE_BUG_SELECT,
        VSI_BUG_SELECT,
        AIRSPEED_BUG_SELECT,
        AP_PITCH_REF_INC_UP,
        AP_PITCH_REF_INC_DN,
        AP_PITCH_REF_SELECT,
        AP_ATT_HOLD,
        AP_LOC_HOLD,
        AP_APR_HOLD,
        AP_HDG_HOLD,
        AP_ALT_HOLD,
        AP_WING_LEVELER,
        AP_BC_HOLD,
        AP_NAV1_HOLD,
        AP_MAX_BANK_INC,
        AP_MAX_BANK_DEC,
        AP_N1_HOLD,
        AP_N1_REF_INC,
        AP_N1_REF_DEC,
        FLY_BY_WIRE_ELAC_TOGGLE,
        FLY_BY_WIRE_FAC_TOGGLE,
        FLY_BY_WIRE_SEC_TOGGLE,
        G1000_PFD_FLIGHTPLAN_BUTTON,
        G1000_PFD_PROCEDURE_BUTTON,
        G1000_PFD_ZOOMIN_BUTTON,
        G1000_PFD_ZOOMOUT_BUTTON,
        G1000_PFD_DIRECTTO_BUTTON,
        G1000_PFD_MENU_BUTTON,
        G1000_PFD_CLEAR_BUTTON,
        G1000_PFD_ENTER_BUTTON,
        G1000_PFD_CURSOR_BUTTON,
        G1000_PFD_GROUP_KNOB_INC,
        G1000_PFD_GROUP_KNOB_DEC,
        G1000_PFD_PAGE_KNOB_INC,
        G1000_PFD_PAGE_KNOB_DEC,
        G1000_PFD_SOFTKEY1,
        G1000_PFD_SOFTKEY2,
        G1000_PFD_SOFTKEY3,
        G1000_PFD_SOFTKEY4,
        G1000_PFD_SOFTKEY5,
        G1000_PFD_SOFTKEY6,
        G1000_PFD_SOFTKEY7,
        G1000_PFD_SOFTKEY8,
        G1000_PFD_SOFTKEY9,
        G1000_PFD_SOFTKEY10,
        G1000_PFD_SOFTKEY11,
        G1000_PFD_SOFTKEY12,
        G1000_MFD_FLIGHTPLAN_BUTTON,
        G1000_MFD_PROCEDURE_BUTTON,
        G1000_MFD_ZOOMIN_BUTTON,
        G1000_MFD_ZOOMOUT_BUTTON,
        G1000_MFD_DIRECTTO_BUTTON,
        G1000_MFD_MENU_BUTTON,
        G1000_MFD_CLEAR_BUTTON,
        G1000_MFD_ENTER_BUTTON,
        G1000_MFD_CURSOR_BUTTON,
        G1000_MFD_GROUP_KNOB_INC,
        G1000_MFD_GROUP_KNOB_DEC,
        G1000_MFD_PAGE_KNOB_INC,
        G1000_MFD_PAGE_KNOB_DEC,
        G1000_MFD_SOFTKEY1,
        G1000_MFD_SOFTKEY2,
        G1000_MFD_SOFTKEY3,
        G1000_MFD_SOFTKEY4,
        G1000_MFD_SOFTKEY5,
        G1000_MFD_SOFTKEY6,
        G1000_MFD_SOFTKEY7,
        G1000_MFD_SOFTKEY8,
        G1000_MFD_SOFTKEY9,
        G1000_MFD_SOFTKEY10,
        G1000_MFD_SOFTKEY11,
        G1000_MFD_SOFTKEY12,
        FUEL_SELECTOR_SET,
        FUEL_SELECTOR_OFF,
        FUEL_SELECTOR_ALL,
        FUEL_SELECTOR_LEFT,
        FUEL_SELECTOR_RIGHT,
        FUEL_SELECTOR_LEFT_AUX,
        FUEL_SELECTOR_RIGHT_AUX,
        FUEL_SELECTOR_CENTER,
        FUEL_SELECTOR_2_SET,
        FUEL_SELECTOR_2_OFF,
        FUEL_SELECTOR_2_ALL,
        FUEL_SELECTOR_2_LEFT,
        FUEL_SELECTOR_2_RIGHT,
        FUEL_SELECTOR_2_LEFT_AUX,
        FUEL_SELECTOR_2_RIGHT_AUX,
        FUEL_SELECTOR_2_CENTER,
        FUEL_SELECTOR_3_SET,
        FUEL_SELECTOR_3_OFF,
        FUEL_SELECTOR_3_ALL,
        FUEL_SELECTOR_3_LEFT,
        FUEL_SELECTOR_3_RIGHT,
        FUEL_SELECTOR_3_LEFT_AUX,
        FUEL_SELECTOR_3_RIGHT_AUX,
        FUEL_SELECTOR_3_CENTER,
        FUEL_SELECTOR_4_SET,
        FUEL_SELECTOR_4_OFF,
        FUEL_SELECTOR_4_ALL,
        FUEL_SELECTOR_4_LEFT,
        FUEL_SELECTOR_4_RIGHT,
        FUEL_SELECTOR_4_LEFT_AUX,
        FUEL_SELECTOR_4_RIGHT_AUX,
        FUEL_SELECTOR_4_CENTER,
        CROSS_FEED_OPEN,
        CROSS_FEED_TOGGLE,
        CROSS_FEED_OFF,
        ANTIDETONATION_TANK_VALVE_TOGGLE,
        NITROUS_TANK_VALVE_TOGGLE,
        REPAIR_AND_REFUEL,
        FUEL_DUMP_TOGGLE,
        REQUEST_FUEL_KEY,
        XPNDR,
        ADF,
        DME,
        COM_RADIO,
        VOR_OBS,
        NAV_RADIO,
        COM_RADIO_WHOLE_DEC,
        COM_RADIO_WHOLE_INC,
        COM_RADIO_FRACT_DEC,
        COM_RADIO_FRACT_INC,
        NAV1_RADIO_WHOLE_DEC,
        NAV1_RADIO_WHOLE_INC,
        NAV1_RADIO_FRACT_DEC,
        NAV1_RADIO_FRACT_INC,
        NAV2_RADIO_WHOLE_DEC,
        NAV2_RADIO_WHOLE_INC,
        NAV2_RADIO_FRACT_DEC,
        NAV2_RADIO_FRACT_INC,
        XPNDR_1000_INC,
        XPNDR_100_INC,
        XPNDR_10_INC,
        XPNDR_1_INC,
        VOR1_OBI_DEC,
        VOR1_OBI_INC,
        VOR2_OBI_DEC,
        VOR2_OBI_INC,
        DME1_TOGGLE,
        DME2_TOGGLE,
        RADIO_VOR1_IDENT_DISABLE,
        RADIO_VOR2_IDENT_DISABLE,
        RADIO_DME1_IDENT_DISABLE,
        RADIO_DME2_IDENT_DISABLE,
        RADIO_TACAN_DME1_IDENT_DISABLE,
        RADIO_TACAN_DME2_IDENT_DISABLE,
        RADIO_TACAN_DME1_IDENT_ENABLE,
        RADIO_TACAN_DME2_IDENT_ENABLE,
        RADIO_TACAN_DME1_IDENT_TOGGLE,
        RADIO_TACAN_DME2_IDENT_TOGGLE,
        RADIO_ADF_IDENT_DISABLE,
        RADIO_VOR1_IDENT_ENABLE,
        RADIO_VOR2_IDENT_ENABLE,
        RADIO_DME1_IDENT_ENABLE,
        RADIO_DME2_IDENT_ENABLE,
        RADIO_ADF_IDENT_ENABLE,
        RADIO_VOR1_IDENT_TOGGLE,
        RADIO_VOR2_IDENT_TOGGLE,
        RADIO_DME1_IDENT_TOGGLE,
        RADIO_DME2_IDENT_TOGGLE,
        RADIO_ADF_IDENT_TOGGLE,
        RADIO_TACAN1_IDENT_TOGGLE,
        RADIO_TACAN2_IDENT_TOGGLE,
        RADIO_TACAN1_IDENT_DISABLE,
        RADIO_TACAN2_IDENT_DISABLE,
        RADIO_TACAN1_IDENT_ENABLE,
        RADIO_TACAN2_IDENT_ENABLE,
        TOGGLE_DME,
        TOGGLE_AVIONICS_MASTER,
        COM_STBY_RADIO_SWAP,
        COM_RADIO_FRACT_DEC_CARRY,
        COM_RADIO_FRACT_INC_CARRY,
        COM2_RADIO_WHOLE_DEC,
        COM2_RADIO_WHOLE_INC,
        COM2_RADIO_FRACT_DEC,
        COM2_RADIO_FRACT_DEC_CARRY,
        COM2_RADIO_FRACT_INC,
        COM2_RADIO_FRACT_INC_CARRY,
        COM2_RADIO_SWAP,
        NAV1_RADIO_FRACT_DEC_CARRY,
        NAV1_RADIO_FRACT_INC_CARRY,
        NAV1_RADIO_SWAP,
        NAV2_RADIO_FRACT_DEC_CARRY,
        NAV2_RADIO_FRACT_INC_CARRY,
        NAV2_RADIO_SWAP,
        XPNDR_1000_DEC,
        XPNDR_100_DEC,
        XPNDR_10_DEC,
        XPNDR_1_DEC,
        XPNDR_DEC_CARRY,
        XPNDR_INC_CARRY,
        COM1_TRANSMIT_SELECT,
        COM2_TRANSMIT_SELECT,
        COM_RECEIVE_ALL_TOGGLE,
        MARKER_SOUND_TOGGLE,
        ADF_100_DEC,
        ADF_10_DEC,
        ADF_1_DEC,
        ADF_100_INC,
        ADF_10_INC,
        ADF_1_INC,
        ADF_FRACT_DEC_CARRY,
        ADF_FRACT_INC_CARRY,
        ADF_CARD_DEC,
        ADF_CARD_INC,
        ADF1_RADIO_SWAP,
        ADF1_RADIO_TENTHS_DEC,
        ADF1_RADIO_TENTHS_INC,
        ADF1_WHOLE_DEC,
        ADF1_WHOLE_INC,
        ADF2_RADIO_SWAP,
        ADF2_100_DEC,
        ADF2_10_DEC,
        ADF2_1_DEC,
        ADF2_100_INC,
        ADF2_10_INC,
        ADF2_1_INC,
        ADF2_RADIO_TENTHS_DEC,
        ADF2_RADIO_TENTHS_INC,
        ADF2_WHOLE_DEC,
        ADF2_WHOLE_INC,
        ADF2_FRACT_DEC_CARRY,
        ADF2_FRACT_INC_CARRY,
        RADIO_ADF2_IDENT_DISABLE,
        RADIO_ADF2_IDENT_ENABLE,
        RADIO_ADF2_IDENT_TOGGLE,
        FREQUENCY_SWAP,
        TACAN1_CHANNEL_INC,
        TACAN2_CHANNEL_INC,
        TACAN1_CHANNEL_DEC,
        TACAN2_CHANNEL_DEC,
        TACAN1_RADIO_SWAP,
        TACAN2_RADIO_SWAP,
        TACAN1_XY_BAND_TOGGLE,
        TACAN2_XY_BAND_TOGGLE,
        TOGGLE_GPS_DRIVES_NAV1,
        GPS_POWER_BUTTON,
        GPS_NEAREST_BUTTON,
        GPS_OBS_BUTTON,
        GPS_MSG_BUTTON,
        GPS_MSG_BUTTON_DOWN,
        GPS_MSG_BUTTON_UP,
        GPS_OBS_INC,
        GPS_OBS_DEC,
        GPS_OBS_SET,
        GPS_FLIGHTPLAN_BUTTON,
        GPS_TERRAIN_BUTTON,
        GPS_PROCEDURE_BUTTON,
        GPS_ZOOMIN_BUTTON,
        GPS_ZOOMOUT_BUTTON,
        GPS_DIRECTTO_BUTTON,
        GPS_MENU_BUTTON,
        GPS_CLEAR_BUTTON,
        GPS_CLEAR_ALL_BUTTON,
        GPS_CLEAR_BUTTON_DOWN,
        GPS_CLEAR_BUTTON_UP,
        GPS_ENTER_BUTTON,
        GPS_CURSOR_BUTTON,
        GPS_GROUP_KNOB_INC,
        GPS_GROUP_KNOB_DEC,
        GPS_PAGE_KNOB_INC,
        GPS_PAGE_KNOB_DEC,
        DME_SELECT,
        RADIO_SELECTED_DME_IDENT_ENABLE,
        RADIO_SELECTED_DME_IDENT_DISABLE,
        RADIO_SELECTED_DME_IDENT_TOGGLE,
        EGT,
        EGT_INC,
        EGT_DEC,
        BAROMETRIC,
        GYRO_DRIFT_INC,
        GYRO_DRIFT_DEC,
        KOHLSMAN_INC,
        KOHLSMAN_DEC,
        TRUE_AIRSPEED_CAL_INC,
        TRUE_AIRSPEED_CAL_DEC,
        EGT1_INC,
        EGT1_DEC,
        EGT2_INC,
        EGT2_DEC,
        EGT3_INC,
        EGT3_DEC,
        EGT4_INC,
        EGT4_DEC,
        ATTITUDE_BARS_POSITION_UP,
        ATTITUDE_BARS_POSITION_DOWN,
        ATTITUDE_CAGE_BUTTON,
        STROBES_TOGGLE,
        ALL_LIGHTS_TOGGLE,
        PANEL_LIGHTS_TOGGLE,
        LANDING_LIGHTS_TOGGLE,
        LANDING_LIGHT_UP,
        LANDING_LIGHT_DOWN,
        LANDING_LIGHT_LEFT,
        LANDING_LIGHT_RIGHT,
        LANDING_LIGHT_HOME,
        STROBES_ON,
        STROBES_OFF,
        PANEL_LIGHTS_ON,
        PANEL_LIGHTS_OFF,
        LANDING_LIGHTS_ON,
        LANDING_LIGHTS_OFF,
        TOGGLE_BEACON_LIGHTS,
        TOGGLE_TAXI_LIGHTS,
        TOGGLE_LOGO_LIGHTS,
        TOGGLE_RECOGNITION_LIGHTS,
        TOGGLE_WING_LIGHTS,
        TOGGLE_NAV_LIGHTS,
        TOGGLE_CABIN_LIGHTS,
        TOGGLE_VACUUM_FAILURE,
        TOGGLE_ELECTRICAL_FAILURE,
        TOGGLE_PITOT_BLOCKAGE,
        TOGGLE_STATIC_PORT_BLOCKAGE,
        TOGGLE_HYDRAULIC_FAILURE,
        TOGGLE_TOTAL_BRAKE_FAILURE,
        TOGGLE_LEFT_BRAKE_FAILURE,
        TOGGLE_RIGHT_BRAKE_FAILURE,
        TOGGLE_ENGINE1_FAILURE,
        TOGGLE_ENGINE2_FAILURE,
        TOGGLE_ENGINE3_FAILURE,
        TOGGLE_ENGINE4_FAILURE,
        SMOKE_TOGGLE,
        GEAR_TOGGLE,
        BRAKES,
        BRAKES_LEFT,
        BRAKES_RIGHT,
        PARKING_BRAKES,
        GEAR_PUMP,
        PITOT_HEAT_TOGGLE,
        SMOKE_ON,
        SMOKE_OFF,
        PITOT_HEAT_ON,
        PITOT_HEAT_OFF,
        GEAR_UP,
        GEAR_DOWN,
        TOGGLE_MASTER_BATTERY,
        TOGGLE_MASTER_ALTERNATOR,
        TOGGLE_GENALT_BUS1_CONTACT,
        TOGGLE_GENALT_BUS2_CONTACT,
        TOGGLE_GENALT_BUS3_CONTACT,
        TOGGLE_GENALT_BUS4_CONTACT,
        TOGGLE_BATTERY_BUS_CONTACT,
        TOGGLE_ELECTRIC_VACUUM_PUMP,
        TOGGLE_ALTERNATE_STATIC,
        DECREASE_DECISION_HEIGHT,
        INCREASE_DECISION_HEIGHT,
        TOGGLE_STRUCTURAL_DEICE,
        TOGGLE_PROPELLER_DEICE,
        TOGGLE_ALTERNATOR1,
        TOGGLE_ALTERNATOR2,
        TOGGLE_ALTERNATOR3,
        TOGGLE_ALTERNATOR4,
        TOGGLE_MASTER_BATTERY_ALTERNATOR,
        TOGGLE_AIRCRAFT_EXIT,
        TOGGLE_WING_FOLD,
        TOGGLE_TAIL_HOOK_HANDLE,
        TOGGLE_WATER_RUDDER,
        TOGGLE_PUSHBACK,
        KEY_TUG_HEADING,
        KEY_TUG_SPEED,
        TUG_DISABLE,
        TOGGLE_MASTER_IGNITION_SWITCH,
        TOGGLE_TAILWHEEL_LOCK,
        ADD_FUEL_QUANTITY,
        TOW_PLANE_RELEASE,
        TOW_PLANE_REQUEST,
        RELEASE_DROPPABLE_OBJECTS,
        RETRACT_FLOAT_SWITCH_DEC,
        RETRACT_FLOAT_SWITCH_INC,
        TOGGLE_WATER_BALLAST_VALVE,
        TOGGLE_VARIOMETER_SWITCH,
        TOGGLE_TURN_INDICATOR_SWITCH,
        APU_STARTER,
        APU_OFF_SWITCH,
        APU_GENERATOR_SWITCH_TOGGLE,
        ELECTRIC_GPU_SWITCH_TOGGLE,
        EXTINGUISH_ENGINE_FIRE,
        HYDRAULIC_SWITCH_TOGGLE,
        BLEED_AIR_SOURCE_CONTROL_INC,
        BLEED_AIR_SOURCE_CONTROL_DEC,
        BLEED_AIR_SOURCE_CONTROL_SET,
        TURBINE_IGNITION_SWITCH_TOGGLE,
        TURBINE_IGNITION_SWITCH_ON,
        TURBINE_IGNITION_SWITCH_OFF,
        TURBINE_IGNITION_SWITCH_AUTO,
        CABIN_NO_SMOKING_ALERT_SWITCH_TOGGLE,
        CABIN_SEATBELTS_ALERT_SWITCH_TOGGLE,
        ANTISKID_BRAKES_TOGGLE,
        GPWS_SWITCH_TOGGLE,
        MANUAL_FUEL_PRESSURE_PUMP,
        PAUSE_TOGGLE,
        PAUSE_ON,
        PAUSE_OFF,
        DEMO_STOP,
        SELECT_1,
        SELECT_2,
        SELECT_3,
        SELECT_4,
        MINUS,
        PLUS,
        ZOOM_1X,
        SOUND_TOGGLE,
        SIM_RATE,
        JOYSTICK_CALIBRATE,
        SITUATION_SAVE,
        EXIT,
        ABORT,
        READOUTS_SLEW,
        READOUTS_FLIGHT,
        MINUS_SHIFT,
        PLUS_SHIFT,
        SIM_RATE_INCR,
        SIM_RATE_DECR,
        KNEEBOARD_VIEW,
        PANEL_1,
        PANEL_2,
        PANEL_3,
        PANEL_4,
        PANEL_5,
        PANEL_6,
        PANEL_7,
        PANEL_8,
        PANEL_9,
        SOUND_ON,
        SOUND_OFF,
        INVOKE_HELP,
        TOGGLE_AIRCRAFT_LABELS,
        TOGGLE_TIME_PREVIEW_WINDOW,
        FLIGHT_MAP,
        RELOAD_PANELS,
        PANEL_ID_TOGGLE,
        PANEL_ID_OPEN,
        PANEL_ID_CLOSE,
        RELOAD_USER_AIRCRAFT,
        VIRTUAL_COPILOT_TOGGLE,
        VIRTUAL_COPILOT_ACTION,
        REFRESH_SCENERY,
        CLOCK_HOURS_DEC,
        CLOCK_HOURS_INC,
        CLOCK_MINUTES_DEC,
        CLOCK_MINUTES_INC,
        CLOCK_SECONDS_ZERO,
        GAUGE_KEYSTROKE,
        VIEW_WINDOW_TITLES_TOGGLE,
        AXIS_PAN_PITCH,
        AXIS_PAN_HEADING,
        AXIS_PAN_TILT,
        VIEW_AXIS_INDICATOR_CYCLE,
        VIEW_MAP_ORIENTATION_CYCLE,
        TOGGLE_JETWAY,
        VIDEO_RECORD_TOGGLE,
        TOGGLE_AIRPORT_NAME_DISPLAY,
        CAPTURE_SCREENSHOT,
        MOUSE_LOOK_TOGGLE,
        YAXIS_INVERT_TOGGLE,
        AUTORUDDER_TOGGLE,

        NAV1_STBY_SET = 1000,
        NAV2_STBY_SET,
        COM_STBY_RADIO_SET,
        COM_STBY_RADIO_SET_HZ,
        COM2_STBY_RADIO_SET,
        COM2_STBY_RADIO_SET_HZ,
        XPNDR_SET,
        VOR1_SET,
        VOR2_SET,
        ADF_SET,
        AP_NAV_SELECT_SET,
        SPEED_SLOT_INDEX_SET,
        HEADING_SLOT_INDEX_SET,
        ALTITUDE_SLOT_INDEX_SET,
        VS_SLOT_INDEX_SET,
        HEADING_BUG_SET,
        AP_ALT_VAR_SET_ENGLISH,
        AP_VS_VAR_SET_ENGLISH,
        AP_SPD_VAR_SET,
        AVIONICS_MASTER_SET,
        TURBINE_IGNITION_SWITCH_SET1,
        TURBINE_IGNITION_SWITCH_SET2,
        KOHLSMAN_SET,
        ELECTRICAL_BUS_TO_BUS_CONNECTION_TOGGLE,
        ELECTRICAL_CIRCUIT_TOGGLE,
        ELEVATOR_TRIM_SET,
        AXIS_ELEV_TRIM_SET,
        HEADING_GYRO_SET,
        GYRO_DRIFT_SET,

        ATC_MENU_0,
        ATC_MENU_1,
        ATC_MENU_2,
        ATC_MENU_3,
        ATC_MENU_4,
        ATC_MENU_5,
        ATC_MENU_6,
        ATC_MENU_7,
        ATC_MENU_8,
        ATC_MENU_9,
    }
}
