﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using LuaInterface;

using BindType = ToLuaMenu.BindType;
using System.Reflection;

using UnityEngine.EventSystems;

public static class CustomSettings
{
    public static string saveDir = Application.dataPath + "/Source/Generate/";
    public static string luaDir = Application.dataPath + "/Lua/";
    public static string toluaBaseType = Application.dataPath + "/ToLua/BaseType/";
    public static string toluaLuaDir = Application.dataPath + "/ToLua/Lua";

    //导出时强制做为静态类的类型(注意customTypeList 还要添加这个类型才能导出)
    //unity 有些类作为sealed class, 其实完全等价于静态类
    public static List<Type> staticClassTypes = new List<Type>
    {
        typeof(UnityEngine.Application),
        typeof(UnityEngine.Time),
        typeof(UnityEngine.Screen),
        typeof(UnityEngine.SleepTimeout),
        typeof(UnityEngine.Input),
        typeof(UnityEngine.Resources),
        typeof(UnityEngine.Physics),
        typeof(UnityEngine.RenderSettings),
        typeof(UnityEngine.QualitySettings),
        typeof(UnityEngine.GL),
        typeof(LuaHelper),
    };

    //附加导出委托类型(在导出委托时, customTypeList 中牵扯的委托类型都会导出， 无需写在这里)
    public static DelegateType[] customDelegateList =
    {
        _DT(typeof(Action)),
        _DT(typeof(UnityEngine.Events.UnityAction)),

    };

    //在这里添加你要导出注册到lua的类型列表
    public static BindType[] customTypeList =
    {                
        //------------------------为例子导出--------------------------------
        //_GT(typeof(TestEventListener)),
        //_GT(typeof(TestAccount)),
        //_GT(typeof(Dictionary<int, TestAccount>)).SetLibName("AccountMap"),
        //_GT(typeof(KeyValuePair<int, TestAccount>)),    
        //_GT(typeof(TestExport)),
        //_GT(typeof(TestExport.Space)),
        //-------------------------------------------------------------------        
        _GT(typeof(Debugger)),

                               
                
        //_GT(typeof(Component)),
        //_GT(typeof(Transform)),
        //_GT(typeof(Material)),
        //_GT(typeof(Light)),
        //_GT(typeof(Rigidbody)),
        //_GT(typeof(Camera)),
        //_GT(typeof(AudioSource)),     
                        
        _GT(typeof(Behaviour)),
        _GT(typeof(PointerEventData)).SetBaseType(typeof(System.Object)),
        _GT(typeof(MonoBehaviour)),
        _GT(typeof(GameObject)),
        _GT(typeof(TrackedReference)),
        _GT(typeof(Application)),
        _GT(typeof(Physics)),
        _GT(typeof(Collider)),
        _GT(typeof(Time)),
        _GT(typeof(Texture)),
        _GT(typeof(Texture2D)),
        _GT(typeof(Shader)),
        _GT(typeof(Renderer)),
        _GT(typeof(WWW)),
        _GT(typeof(Screen)),
        _GT(typeof(CameraClearFlags)),
        _GT(typeof(AudioClip)),
        _GT(typeof(AssetBundle)),
        _GT(typeof(ParticleSystem)),
        _GT(typeof(AsyncOperation)).SetBaseType(typeof(System.Object)),
        _GT(typeof(LightType)),
        _GT(typeof(SleepTimeout)),
        _GT(typeof(UnityEngine.Experimental.Director.DirectorPlayer)),
        _GT(typeof(Animator)),
        _GT(typeof(Input)),
        _GT(typeof(KeyCode)),
        _GT(typeof(SkinnedMeshRenderer)),
        _GT(typeof(Space)),

        _GT(typeof(MeshRenderer)),
        _GT(typeof(ParticleEmitter)),
        _GT(typeof(ParticleRenderer)),
        _GT(typeof(ParticleAnimator)),

        _GT(typeof(BoxCollider)),
        _GT(typeof(MeshCollider)),
        _GT(typeof(SphereCollider)),
        _GT(typeof(CharacterController)),
        _GT(typeof(CapsuleCollider)),

        _GT(typeof(Animation)),
        _GT(typeof(AnimationClip)).SetBaseType(typeof(UnityEngine.Object)),
        _GT(typeof(AnimationState)),
        _GT(typeof(AnimationBlendMode)),
        _GT(typeof(QueueMode)),
        _GT(typeof(PlayMode)),
        _GT(typeof(WrapMode)),
        _GT(typeof(Profiler)),
        _GT(typeof(CanvasGroup)),

        _GT(typeof(QualitySettings)),
        _GT(typeof(RenderSettings)),
        _GT(typeof(BlendWeights)),
        _GT(typeof(RenderTexture)),

        ////////////////////////////////////////////
        _GT(typeof(Graphic)),
        _GT(typeof(MaskableGraphic)),
        _GT(typeof(Image)),
        _GT(typeof(Text)),
        _GT(typeof(Sprite)),
        _GT(typeof(Toggle)),
        _GT(typeof(ToggleGroup)),
        _GT(typeof(InputField)),
        _GT(typeof(Rect)),
        _GT(typeof(LayoutGroup)),
        _GT(typeof(HorizontalOrVerticalLayoutGroup)),
        _GT(typeof(VerticalLayoutGroup)),
        _GT(typeof(HorizontalLayoutGroup)),
        _GT(typeof(ContentSizeFitter)),

        _GT(typeof(Dropdown)),
        _GT(typeof(Mask)),
        _GT(typeof(RectMask2D)),
        _GT(typeof(LayoutElement)),

        _GT(typeof(Slider)),

        _GT(typeof(Scrollbar)),

        _GT(typeof(RectTransform)),
        _GT(typeof(RectTransformUtility)),

        _GT(typeof(UIBehaviour)),
        _GT(typeof(Selectable)),
        _GT(typeof(Button)),
        _GT(typeof(Canvas)),
        _GT(typeof(BaseRaycaster)),
        _GT(typeof(GraphicRaycaster)),

        _GT(typeof(LuaBehaviour)),
        _GT(typeof(GameResFactory)),

        _GT(typeof(ScrollRect)),
        _GT(typeof(LoopScrollRect)),
        _GT(typeof(LoopVerticalScrollRect)),
        _GT(typeof(LoopHorizontalScrollRect)),

        _GT(typeof(Base)),
        _GT(typeof(Manager)),
        _GT(typeof(ByteBuffer)),
        _GT(typeof(ByteArray)),
        _GT(typeof(MemBlock)),
        _GT(typeof(NetworkManager)),
        _GT(typeof(SocketClient)),
        _GT(typeof(GenerateMd5)), 

        _GT(typeof(LuaHelper)),

#region   dotween
        ///////////////////////////
         _GT(typeof(ToLua_UnityEngine_Transform)),
         _GT(typeof(ToLua_DG_Tweening_Tween)),
         _GT(typeof(ToLua_DG_Tweening_Tweener)),
         _GT(typeof(ToLua_DG_Tweening_Sequence)),
        _GT(typeof(DG.Tweening.AutoPlay)),
        _GT(typeof(DG.Tweening.AxisConstraint)),
        _GT(typeof(DG.Tweening.Ease)),
        _GT(typeof(DG.Tweening.LogBehaviour)),
        _GT(typeof(DG.Tweening.LoopType)),
        _GT(typeof(DG.Tweening.PathMode)),
        _GT(typeof(DG.Tweening.PathType)),
        _GT(typeof(DG.Tweening.RotateMode)),
        _GT(typeof(DG.Tweening.ScrambleMode)),
        _GT(typeof(DG.Tweening.TweenType)),
        _GT(typeof(DG.Tweening.UpdateType)),

        _GT(typeof(DG.Tweening.DOTween)),
        _GT(typeof(DG.Tweening.DOVirtual)),
        _GT(typeof(DG.Tweening.EaseFactory)),
        _GT(typeof(DG.Tweening.Tweener)),
        _GT(typeof(DG.Tweening.Tween)),
        _GT(typeof(DG.Tweening.Sequence)),
        _GT(typeof(DG.Tweening.TweenParams)),
        _GT(typeof(DG.Tweening.Core.ABSSequentiable)),
        _GT(typeof(DG.Tweening.Core.TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions>)).SetWrapName("TweenerCoreV3V3VO").SetLibName("TweenerCoreV3V3VO"),
#endregion

    };

    private static Type NewMethod()
    {
        return typeof(ByteArray);
    }

    public static List<Type> dynamicList = new List<Type>()
    {
        /*typeof(MeshRenderer),
        typeof(ParticleEmitter),
        typeof(ParticleRenderer),
        typeof(ParticleAnimator),

        typeof(BoxCollider),
        typeof(MeshCollider),
        typeof(SphereCollider),
        typeof(CharacterController),
        typeof(CapsuleCollider),

        typeof(Animation),
        typeof(AnimationClip),
        typeof(AnimationState),        

        typeof(BlendWeights),
        typeof(RenderTexture),
        typeof(Rigidbody),*/
    };

    //重载函数，相同参数个数，相同位置out参数匹配出问题时, 需要强制匹配解决
    //使用方法参见例子14
    public static List<Type> outList = new List<Type>()
    {

    };

    static BindType _GT(Type t)
    {
        return new BindType(t);
    }

    static DelegateType _DT(Type t)
    {
        return new DelegateType(t);
    }
}