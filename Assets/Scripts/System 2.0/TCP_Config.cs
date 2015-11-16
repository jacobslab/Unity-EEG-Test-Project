﻿using UnityEngine;
using System.Collections;

public class TCP_Config : MonoBehaviour {

	public static string HostIPAddress = "192.168.137.200"; //"169.254.50.2" for Mac Pro Desktop.
	public static int ConnectionPort = 8888; //8001 for Mac Pro Desktop communication


	public static char MSG_START = '[';
	public static char MSG_SEPARATOR = '~';
	public static char MSG_END = ']';
	
	public enum EventType {
		SUBJECTID,
		EXPNAME,
		VERSION,
		INFO,
		CONTROL,
		SESSION,
		PRACTICE,
		TRIAL,
		PHASE,
		DISPLAYON,
		DISPLAYOFF,
		HEARTBEAT,
		ALIGNCLOCK,
		ABORT,
		SYTNC,
		SYNCED,
		EXIT
	}

}