﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_SizeBySpeedModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule o;
			o=new UnityEngine.ParticleSystem.SizeBySpeedModule();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.size=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.x=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.y=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_z(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.z);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_z(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.z=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_separateAxes(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.separateAxes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_separateAxes(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.separateAxes=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_range(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.range);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_range(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SizeBySpeedModule self;
			checkValueType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.range=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.SizeBySpeedModule");
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"z",get_z,set_z,true);
		addMember(l,"separateAxes",get_separateAxes,set_separateAxes,true);
		addMember(l,"range",get_range,set_range,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.SizeBySpeedModule),typeof(System.ValueType));
	}
}
