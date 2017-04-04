#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array3829468939.h"
#include "AssemblyU2DCSharp_U3CModuleU3E3783534214.h"
#include "AssemblyU2DCSharp_LightSpawner11931828.h"
#include "mscorlib_System_Void1841601450.h"
#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Coroutine2299508840.h"
#include "AssemblyU2DCSharp_LightSpawner_U3CSpawnLightsContin993395695.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"
#include "UnityEngine_UnityEngine_Quaternion4030073918.h"
#include "mscorlib_System_Single2076509932.h"
#include "UnityEngine_UnityEngine_Transform3275118058.h"
#include "UnityEngine_UnityEngine_Component3819376471.h"
#include "mscorlib_System_Object2689449295.h"
#include "mscorlib_System_Boolean3825574718.h"
#include "UnityEngine_UnityEngine_Object1021602117.h"
#include "mscorlib_System_UInt322149682021.h"
#include "mscorlib_System_Int322071877448.h"
#include "UnityEngine_UnityEngine_WaitForSeconds3839502067.h"
#include "mscorlib_System_NotSupportedException1793819818.h"
#include "AssemblyU2DCSharp_MoveWASD2082359606.h"
#include "UnityEngine_UnityEngine_KeyCode2283395152.h"

// LightSpawner
struct LightSpawner_t11931828;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t1158329972;
// System.Collections.IEnumerator
struct IEnumerator_t1466026749;
// UnityEngine.Coroutine
struct Coroutine_t2299508840;
// LightSpawner/<SpawnLightsContinously>c__Iterator0
struct U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695;
// UnityEngine.Component
struct Component_t3819376471;
// UnityEngine.Transform
struct Transform_t3275118058;
// System.Object
struct Il2CppObject;
// UnityEngine.Object
struct Object_t1021602117;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t3839502067;
// System.NotSupportedException
struct NotSupportedException_t1793819818;
// MoveWASD
struct MoveWASD_t2082359606;
extern Il2CppClass* U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695_il2cpp_TypeInfo_var;
extern const uint32_t LightSpawner_SpawnLightsContinously_m721743070_MetadataUsageId;
extern Il2CppClass* Object_t1021602117_il2cpp_TypeInfo_var;
extern Il2CppClass* WaitForSeconds_t3839502067_il2cpp_TypeInfo_var;
extern const uint32_t U3CSpawnLightsContinouslyU3Ec__Iterator0_MoveNext_m3537587094_MetadataUsageId;
extern Il2CppClass* NotSupportedException_t1793819818_il2cpp_TypeInfo_var;
extern const uint32_t U3CSpawnLightsContinouslyU3Ec__Iterator0_Reset_m266370255_MetadataUsageId;
extern Il2CppClass* Input_t1785128008_il2cpp_TypeInfo_var;
extern const uint32_t MoveWASD_Update_m3818267072_MetadataUsageId;




// System.Void UnityEngine.MonoBehaviour::.ctor()
extern "C"  void MonoBehaviour__ctor_m2464341955 (MonoBehaviour_t1158329972 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator LightSpawner::SpawnLightsContinously()
extern "C"  Il2CppObject * LightSpawner_SpawnLightsContinously_m721743070 (LightSpawner_t11931828 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Coroutine UnityEngine.MonoBehaviour::StartCoroutine(System.Collections.IEnumerator)
extern "C"  Coroutine_t2299508840 * MonoBehaviour_StartCoroutine_m2470621050 (MonoBehaviour_t1158329972 * __this, Il2CppObject * p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void LightSpawner/<SpawnLightsContinously>c__Iterator0::.ctor()
extern "C"  void U3CSpawnLightsContinouslyU3Ec__Iterator0__ctor_m4010510050 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Transform UnityEngine.Component::get_transform()
extern "C"  Transform_t3275118058 * Component_get_transform_m2697483695 (Component_t3819376471 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
extern "C"  Vector3_t2243707580  Transform_get_position_m1104419803 (Transform_t3275118058 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Transform::get_forward()
extern "C"  Vector3_t2243707580  Transform_get_forward_m1833488937 (Transform_t3275118058 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
extern "C"  Quaternion_t4030073918  Transform_get_rotation_m1033555130 (Transform_t3275118058 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t2243707580  Vector3_op_Multiply_m1351554733 (Il2CppObject * __this /* static, unused */, Vector3_t2243707580  p0, float p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t2243707580  Vector3_op_Addition_m3146764857 (Il2CppObject * __this /* static, unused */, Vector3_t2243707580  p0, Vector3_t2243707580  p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Object::.ctor()
extern "C"  void Object__ctor_m2551263788 (Il2CppObject * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 LightSpawner::spawnInFronOfPlayer()
extern "C"  Vector3_t2243707580  LightSpawner_spawnInFronOfPlayer_m1912743468 (LightSpawner_t11931828 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Object UnityEngine.Object::Instantiate(UnityEngine.Object,UnityEngine.Vector3,UnityEngine.Quaternion)
extern "C"  Object_t1021602117 * Object_Instantiate_m938141395 (Il2CppObject * __this /* static, unused */, Object_t1021602117 * p0, Vector3_t2243707580  p1, Quaternion_t4030073918  p2, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object,System.Single)
extern "C"  void Object_Destroy_m4279412553 (Il2CppObject * __this /* static, unused */, Object_t1021602117 * p0, float p1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
extern "C"  void WaitForSeconds__ctor_m1990515539 (WaitForSeconds_t3839502067 * __this, float p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.NotSupportedException::.ctor()
extern "C"  void NotSupportedException__ctor_m3232764727 (NotSupportedException_t1793819818 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Input::GetKey(UnityEngine.KeyCode)
extern "C"  bool Input_GetKey_m3849524999 (Il2CppObject * __this /* static, unused */, int32_t p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_forward()
extern "C"  Vector3_t2243707580  Vector3_get_forward_m1201659139 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Time::get_deltaTime()
extern "C"  float Time_get_deltaTime_m2233168104 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::Translate(UnityEngine.Vector3)
extern "C"  void Transform_Translate_m3316827744 (Transform_t3275118058 * __this, Vector3_t2243707580  p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_back()
extern "C"  Vector3_t2243707580  Vector3_get_back_m4246539215 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_down()
extern "C"  Vector3_t2243707580  Vector3_get_down_m2372302126 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::Rotate(UnityEngine.Vector3)
extern "C"  void Transform_Rotate_m1743927093 (Transform_t3275118058 * __this, Vector3_t2243707580  p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
extern "C"  Vector3_t2243707580  Vector3_get_up_m2725403797 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void LightSpawner::.ctor()
extern "C"  void LightSpawner__ctor_m804698689 (LightSpawner_t11931828 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void LightSpawner::Start()
extern "C"  void LightSpawner_Start_m2568476481 (LightSpawner_t11931828 * __this, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = LightSpawner_SpawnLightsContinously_m721743070(__this, /*hidden argument*/NULL);
		MonoBehaviour_StartCoroutine_m2470621050(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Collections.IEnumerator LightSpawner::SpawnLightsContinously()
extern "C"  Il2CppObject * LightSpawner_SpawnLightsContinously_m721743070 (LightSpawner_t11931828 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (LightSpawner_SpawnLightsContinously_m721743070_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * V_0 = NULL;
	{
		U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * L_0 = (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 *)il2cpp_codegen_object_new(U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695_il2cpp_TypeInfo_var);
		U3CSpawnLightsContinouslyU3Ec__Iterator0__ctor_m4010510050(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * L_1 = V_0;
		L_1->set_U24this_1(__this);
		U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Vector3 LightSpawner::spawnInFronOfPlayer()
extern "C"  Vector3_t2243707580  LightSpawner_spawnInFronOfPlayer_m1912743468 (LightSpawner_t11931828 * __this, const MethodInfo* method)
{
	Vector3_t2243707580  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t2243707580  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Quaternion_t4030073918  V_2;
	memset(&V_2, 0, sizeof(V_2));
	float V_3 = 0.0f;
	Vector3_t2243707580  V_4;
	memset(&V_4, 0, sizeof(V_4));
	{
		Transform_t3275118058 * L_0 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_1 = Transform_get_position_m1104419803(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		Transform_t3275118058 * L_2 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_3 = Transform_get_forward_m1833488937(L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		Transform_t3275118058 * L_4 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Quaternion_t4030073918  L_5 = Transform_get_rotation_m1033555130(L_4, /*hidden argument*/NULL);
		V_2 = L_5;
		V_3 = (10.0f);
		Vector3_t2243707580  L_6 = V_0;
		Vector3_t2243707580  L_7 = V_1;
		float L_8 = V_3;
		Vector3_t2243707580  L_9 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_7, L_8, /*hidden argument*/NULL);
		Vector3_t2243707580  L_10 = Vector3_op_Addition_m3146764857(NULL /*static, unused*/, L_6, L_9, /*hidden argument*/NULL);
		V_4 = L_10;
		Vector3_t2243707580  L_11 = V_4;
		return L_11;
	}
}
// System.Void LightSpawner/<SpawnLightsContinously>c__Iterator0::.ctor()
extern "C"  void U3CSpawnLightsContinouslyU3Ec__Iterator0__ctor_m4010510050 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method)
{
	{
		Object__ctor_m2551263788(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean LightSpawner/<SpawnLightsContinously>c__Iterator0::MoveNext()
extern "C"  bool U3CSpawnLightsContinouslyU3Ec__Iterator0_MoveNext_m3537587094 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CSpawnLightsContinouslyU3Ec__Iterator0_MoveNext_m3537587094_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	uint32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_U24PC_4();
		V_0 = L_0;
		__this->set_U24PC_4((-1));
		uint32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_0021;
		}
		if (L_1 == 1)
		{
			goto IL_0092;
		}
	}
	{
		goto IL_009e;
	}

IL_0021:
	{
		LightSpawner_t11931828 * L_2 = __this->get_U24this_1();
		Object_t1021602117 * L_3 = L_2->get_light_4();
		LightSpawner_t11931828 * L_4 = __this->get_U24this_1();
		Vector3_t2243707580  L_5 = LightSpawner_spawnInFronOfPlayer_m1912743468(L_4, /*hidden argument*/NULL);
		LightSpawner_t11931828 * L_6 = __this->get_U24this_1();
		Transform_t3275118058 * L_7 = Component_get_transform_m2697483695(L_6, /*hidden argument*/NULL);
		Quaternion_t4030073918  L_8 = Transform_get_rotation_m1033555130(L_7, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_t1021602117 * L_9 = Object_Instantiate_m938141395(NULL /*static, unused*/, L_3, L_5, L_8, /*hidden argument*/NULL);
		__this->set_U3CnewLightU3E__1_0(L_9);
		Object_t1021602117 * L_10 = __this->get_U3CnewLightU3E__1_0();
		LightSpawner_t11931828 * L_11 = __this->get_U24this_1();
		float L_12 = L_11->get_lifeTime_3();
		Object_Destroy_m4279412553(NULL /*static, unused*/, L_10, L_12, /*hidden argument*/NULL);
		LightSpawner_t11931828 * L_13 = __this->get_U24this_1();
		float L_14 = L_13->get_timeInterval_2();
		WaitForSeconds_t3839502067 * L_15 = (WaitForSeconds_t3839502067 *)il2cpp_codegen_object_new(WaitForSeconds_t3839502067_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_m1990515539(L_15, L_14, /*hidden argument*/NULL);
		__this->set_U24current_2(L_15);
		bool L_16 = __this->get_U24disposing_3();
		if (L_16)
		{
			goto IL_008d;
		}
	}
	{
		__this->set_U24PC_4(1);
	}

IL_008d:
	{
		goto IL_00a0;
	}

IL_0092:
	{
		goto IL_0021;
	}
	// Dead block : IL_0097: ldarg.0

IL_009e:
	{
		return (bool)0;
	}

IL_00a0:
	{
		return (bool)1;
	}
}
// System.Object LightSpawner/<SpawnLightsContinously>c__Iterator0::System.Collections.Generic.IEnumerator<object>.get_Current()
extern "C"  Il2CppObject * U3CSpawnLightsContinouslyU3Ec__Iterator0_System_Collections_Generic_IEnumeratorU3CobjectU3E_get_Current_m1385120160 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = __this->get_U24current_2();
		return L_0;
	}
}
// System.Object LightSpawner/<SpawnLightsContinously>c__Iterator0::System.Collections.IEnumerator.get_Current()
extern "C"  Il2CppObject * U3CSpawnLightsContinouslyU3Ec__Iterator0_System_Collections_IEnumerator_get_Current_m2951888520 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = __this->get_U24current_2();
		return L_0;
	}
}
// System.Void LightSpawner/<SpawnLightsContinously>c__Iterator0::Dispose()
extern "C"  void U3CSpawnLightsContinouslyU3Ec__Iterator0_Dispose_m1265063745 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method)
{
	{
		__this->set_U24disposing_3((bool)1);
		__this->set_U24PC_4((-1));
		return;
	}
}
// System.Void LightSpawner/<SpawnLightsContinously>c__Iterator0::Reset()
extern "C"  void U3CSpawnLightsContinouslyU3Ec__Iterator0_Reset_m266370255 (U3CSpawnLightsContinouslyU3Ec__Iterator0_t993395695 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CSpawnLightsContinouslyU3Ec__Iterator0_Reset_m266370255_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		NotSupportedException_t1793819818 * L_0 = (NotSupportedException_t1793819818 *)il2cpp_codegen_object_new(NotSupportedException_t1793819818_il2cpp_TypeInfo_var);
		NotSupportedException__ctor_m3232764727(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0);
	}
}
// System.Void MoveWASD::.ctor()
extern "C"  void MoveWASD__ctor_m2233040447 (MoveWASD_t2082359606 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MoveWASD::Start()
extern "C"  void MoveWASD_Start_m2886875011 (MoveWASD_t2082359606 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void MoveWASD::Update()
extern "C"  void MoveWASD_Update_m3818267072 (MoveWASD_t2082359606 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MoveWASD_Update_m3818267072_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t2243707580  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Transform_t3275118058 * L_0 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_1 = Transform_get_position_m1104419803(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		bool L_2 = Input_GetKey_m3849524999(NULL /*static, unused*/, ((int32_t)119), /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_003d;
		}
	}
	{
		Transform_t3275118058 * L_3 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_4 = Vector3_get_forward_m1201659139(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_5 = Time_get_deltaTime_m2233168104(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t2243707580  L_6 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_4, L_5, /*hidden argument*/NULL);
		float L_7 = __this->get_speed_2();
		Vector3_t2243707580  L_8 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_6, L_7, /*hidden argument*/NULL);
		Transform_Translate_m3316827744(L_3, L_8, /*hidden argument*/NULL);
	}

IL_003d:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		bool L_9 = Input_GetKey_m3849524999(NULL /*static, unused*/, ((int32_t)115), /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_006e;
		}
	}
	{
		Transform_t3275118058 * L_10 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_11 = Vector3_get_back_m4246539215(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_12 = Time_get_deltaTime_m2233168104(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t2243707580  L_13 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_11, L_12, /*hidden argument*/NULL);
		float L_14 = __this->get_speed_2();
		Vector3_t2243707580  L_15 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_13, L_14, /*hidden argument*/NULL);
		Transform_Translate_m3316827744(L_10, L_15, /*hidden argument*/NULL);
	}

IL_006e:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		bool L_16 = Input_GetKey_m3849524999(NULL /*static, unused*/, ((int32_t)97), /*hidden argument*/NULL);
		if (!L_16)
		{
			goto IL_009f;
		}
	}
	{
		Transform_t3275118058 * L_17 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_18 = Vector3_get_down_m2372302126(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_19 = Time_get_deltaTime_m2233168104(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t2243707580  L_20 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_18, L_19, /*hidden argument*/NULL);
		float L_21 = __this->get_rotSpeed_3();
		Vector3_t2243707580  L_22 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_20, L_21, /*hidden argument*/NULL);
		Transform_Rotate_m1743927093(L_17, L_22, /*hidden argument*/NULL);
	}

IL_009f:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		bool L_23 = Input_GetKey_m3849524999(NULL /*static, unused*/, ((int32_t)100), /*hidden argument*/NULL);
		if (!L_23)
		{
			goto IL_00d0;
		}
	}
	{
		Transform_t3275118058 * L_24 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_25 = Vector3_get_up_m2725403797(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_26 = Time_get_deltaTime_m2233168104(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t2243707580  L_27 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_25, L_26, /*hidden argument*/NULL);
		float L_28 = __this->get_rotSpeed_3();
		Vector3_t2243707580  L_29 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_27, L_28, /*hidden argument*/NULL);
		Transform_Rotate_m1743927093(L_24, L_29, /*hidden argument*/NULL);
	}

IL_00d0:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
