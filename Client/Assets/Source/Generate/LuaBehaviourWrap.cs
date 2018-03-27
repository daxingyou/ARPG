﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;
public class LuaBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaBehaviour), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Init", Init);
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("AddOnValueChanged", AddOnValueChanged);
		L.RegFunction("AddSliderOnValueChanged", AddSliderOnValueChanged);
		L.RegFunction("AddToggleOnValueChanged", AddToggleOnValueChanged);
		L.RegFunction("AddInputFieldOnValueChanged", AddInputFieldOnValueChanged);
		L.RegFunction("AddInputFieldOnEndEdit", AddInputFieldOnEndEdit);
		L.RegFunction("AddScrollbarOnValueChange", AddScrollbarOnValueChange);
		L.RegFunction("AddOnClick", AddOnClick);
		L.RegFunction("AddOnDrag", AddOnDrag);
		L.RegFunction("AddOnDown", AddOnDown);
		L.RegFunction("AddOnUp", AddOnUp);
		L.RegFunction("AddOnClickPartEvent", AddOnClickPartEvent);
		L.RegFunction("AddPartEvent", AddPartEvent);
		L.RegFunction("RemoveClick", RemoveClick);
		L.RegFunction("RemoveOnValueChanged", RemoveOnValueChanged);
		L.RegFunction("RemoveScrollbarOnValueChanged", RemoveScrollbarOnValueChanged);
		L.RegFunction("RemoveSliderOnValueChanged", RemoveSliderOnValueChanged);
		L.RegFunction("RemoveToggleOnValueChanged", RemoveToggleOnValueChanged);
		L.RegFunction("RemoveOnClick", RemoveOnClick);
		L.RegFunction("RemoveDrag", RemoveDrag);
		L.RegFunction("RemoveUp", RemoveUp);
		L.RegFunction("RemoveDown", RemoveDown);
		L.RegFunction("RemoveListener", RemoveListener);
		L.RegFunction("RemovePartEvent", RemovePartEvent);
		L.RegFunction("RemoveObjPartEvent", RemoveObjPartEvent);
		L.RegFunction("ClearClick", ClearClick);
		L.RegFunction("ClearAllEvent", ClearAllEvent);
		L.RegFunction("ClearPartEvent", ClearPartEvent);
		L.RegFunction("ClearObjPartEvent", ClearObjPartEvent);
		L.RegFunction("SetGuideMaskEnableFalse", SetGuideMaskEnableFalse);
		L.RegFunction("SetGuideMaskEnableTrue", SetGuideMaskEnableTrue);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("UsingOnEnable", get_UsingOnEnable, set_UsingOnEnable);
		L.RegVar("UsingOnDisable", get_UsingOnDisable, set_UsingOnDisable);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.Init(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddOnValueChanged(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSliderOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddSliderOnValueChanged(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddToggleOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddToggleOnValueChanged(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddInputFieldOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddInputFieldOnValueChanged(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddInputFieldOnEndEdit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddInputFieldOnEndEdit(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddScrollbarOnValueChange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddScrollbarOnValueChange(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddOnClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddOnDrag(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddOnDown(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddOnUp(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnClickPartEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction> arg2 = (System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction>)ToLua.CheckObject(L, 4, typeof(System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction>));
			UITriggerListener.VoideDelegate arg3 = null;
			LuaTypes funcType5 = LuaDLL.lua_type(L, 5);

			if (funcType5 != LuaTypes.LUA_TFUNCTION)
			{
				 arg3 = (UITriggerListener.VoideDelegate)ToLua.CheckObject(L, 5, typeof(UITriggerListener.VoideDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 5);
				arg3 = DelegateFactory.CreateDelegate(typeof(UITriggerListener.VoideDelegate), func) as UITriggerListener.VoideDelegate;
			}

			obj.AddOnClickPartEvent(arg0, arg1, arg2, ref arg3);
			ToLua.Push(L, arg3);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPartEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction> arg2 = (System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction>)ToLua.CheckObject(L, 4, typeof(System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction>));
			UITriggerListener.VoideDelegate arg3 = null;
			LuaTypes funcType5 = LuaDLL.lua_type(L, 5);

			if (funcType5 != LuaTypes.LUA_TFUNCTION)
			{
				 arg3 = (UITriggerListener.VoideDelegate)ToLua.CheckObject(L, 5, typeof(UITriggerListener.VoideDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 5);
				arg3 = DelegateFactory.CreateDelegate(typeof(UITriggerListener.VoideDelegate), func) as UITriggerListener.VoideDelegate;
			}

			obj.AddPartEvent(arg0, arg1, arg2, ref arg3);
			ToLua.Push(L, arg3);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveOnValueChanged(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveScrollbarOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveScrollbarOnValueChanged(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveSliderOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveSliderOnValueChanged(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveToggleOnValueChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveToggleOnValueChanged(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveOnClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveUp(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveDown(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.RemoveListener(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemovePartEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction> arg1 = (System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction>));
			obj.RemovePartEvent(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveObjPartEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction> arg1 = (System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction>));
			obj.RemoveObjPartEvent(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			obj.ClearClick();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearAllEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			obj.ClearAllEvent();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearPartEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction> arg0 = (System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,LuaInterface.LuaFunction>));
			obj.ClearPartEvent(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearObjPartEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction> arg0 = (System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<UnityEngine.GameObject,LuaInterface.LuaFunction>));
			obj.ClearObjPartEvent(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGuideMaskEnableFalse(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.SetGuideMaskEnableFalse(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGuideMaskEnableTrue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.SetGuideMaskEnableTrue(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UsingOnEnable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			bool ret = obj.UsingOnEnable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index UsingOnEnable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UsingOnDisable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			bool ret = obj.UsingOnDisable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index UsingOnDisable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UsingOnEnable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.UsingOnEnable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index UsingOnEnable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UsingOnDisable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.UsingOnDisable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index UsingOnDisable on a nil value" : e.Message);
		}
	}
}
