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
#include "mscorlib_System_Collections_Generic_KeyValuePair_21174980068.h"
#include "mscorlib_System_Object2689449295.h"
#include "mscorlib_System_Void1841601450.h"
#include "mscorlib_System_Boolean3825574718.h"
#include "mscorlib_System_String2029220233.h"

// System.Object
struct Il2CppObject;
// System.String
struct String_t;
// System.String[]
struct StringU5BU5D_t1642385972;
extern Il2CppClass* StringU5BU5D_t1642385972_il2cpp_TypeInfo_var;
extern Il2CppClass* String_t_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral372029431;
extern Il2CppCodeGenString* _stringLiteral811305474;
extern Il2CppCodeGenString* _stringLiteral372029425;
extern const uint32_t KeyValuePair_2_ToString_m1739958171_MetadataUsageId;

// System.String[]
struct StringU5BU5D_t1642385972  : public Il2CppArray
{
public:
	ALIGN_FIELD (8) String_t* m_Items[1];

public:
	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};


// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::set_Key(TKey)
extern "C"  void KeyValuePair_2_set_Key_m1222844869_gshared (KeyValuePair_2_t1174980068 * __this, Il2CppObject * p0, const MethodInfo* method);
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::set_Value(TValue)
extern "C"  void KeyValuePair_2_set_Value_m965533293_gshared (KeyValuePair_2_t1174980068 * __this, bool p0, const MethodInfo* method);
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::.ctor(TKey,TValue)
extern "C"  void KeyValuePair_2__ctor_m4040336782_gshared (KeyValuePair_2_t1174980068 * __this, Il2CppObject * ___key0, bool ___value1, const MethodInfo* method);
// TKey System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::get_Key()
extern "C"  Il2CppObject * KeyValuePair_2_get_Key_m2113318928_gshared (KeyValuePair_2_t1174980068 * __this, const MethodInfo* method);
// TValue System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::get_Value()
extern "C"  bool KeyValuePair_2_get_Value_m1916631176_gshared (KeyValuePair_2_t1174980068 * __this, const MethodInfo* method);
// System.String System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::ToString()
extern "C"  String_t* KeyValuePair_2_ToString_m1739958171_gshared (KeyValuePair_2_t1174980068 * __this, const MethodInfo* method);

// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::set_Key(TKey)
#define KeyValuePair_2_set_Key_m1222844869(__this, p0, method) ((  void (*) (KeyValuePair_2_t1174980068 *, Il2CppObject *, const MethodInfo*))KeyValuePair_2_set_Key_m1222844869_gshared)(__this, p0, method)
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::set_Value(TValue)
#define KeyValuePair_2_set_Value_m965533293(__this, p0, method) ((  void (*) (KeyValuePair_2_t1174980068 *, bool, const MethodInfo*))KeyValuePair_2_set_Value_m965533293_gshared)(__this, p0, method)
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::.ctor(TKey,TValue)
#define KeyValuePair_2__ctor_m4040336782(__this, ___key0, ___value1, method) ((  void (*) (KeyValuePair_2_t1174980068 *, Il2CppObject *, bool, const MethodInfo*))KeyValuePair_2__ctor_m4040336782_gshared)(__this, ___key0, ___value1, method)
// TKey System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::get_Key()
#define KeyValuePair_2_get_Key_m2113318928(__this, method) ((  Il2CppObject * (*) (KeyValuePair_2_t1174980068 *, const MethodInfo*))KeyValuePair_2_get_Key_m2113318928_gshared)(__this, method)
// TValue System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::get_Value()
#define KeyValuePair_2_get_Value_m1916631176(__this, method) ((  bool (*) (KeyValuePair_2_t1174980068 *, const MethodInfo*))KeyValuePair_2_get_Value_m1916631176_gshared)(__this, method)
// System.String System.Boolean::ToString()
extern "C"  String_t* Boolean_ToString_m1253164328 (bool* __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Concat(System.String[])
extern "C"  String_t* String_Concat_m626692867 (Il2CppObject * __this /* static, unused */, StringU5BU5D_t1642385972* ___values0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::ToString()
#define KeyValuePair_2_ToString_m1739958171(__this, method) ((  String_t* (*) (KeyValuePair_2_t1174980068 *, const MethodInfo*))KeyValuePair_2_ToString_m1739958171_gshared)(__this, method)
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::.ctor(TKey,TValue)
extern "C"  void KeyValuePair_2__ctor_m4040336782_gshared (KeyValuePair_2_t1174980068 * __this, Il2CppObject * ___key0, bool ___value1, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = ___key0;
		KeyValuePair_2_set_Key_m1222844869((KeyValuePair_2_t1174980068 *)__this, (Il2CppObject *)L_0, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->declaring_type)->rgctx_data, 0));
		bool L_1 = ___value1;
		KeyValuePair_2_set_Value_m965533293((KeyValuePair_2_t1174980068 *)__this, (bool)L_1, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->declaring_type)->rgctx_data, 1));
		return;
	}
}
extern "C"  void KeyValuePair_2__ctor_m4040336782_AdjustorThunk (Il2CppObject * __this, Il2CppObject * ___key0, bool ___value1, const MethodInfo* method)
{
	KeyValuePair_2_t1174980068 * _thisAdjusted = reinterpret_cast<KeyValuePair_2_t1174980068 *>(__this + 1);
	KeyValuePair_2__ctor_m4040336782(_thisAdjusted, ___key0, ___value1, method);
}
// TKey System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::get_Key()
extern "C"  Il2CppObject * KeyValuePair_2_get_Key_m2113318928_gshared (KeyValuePair_2_t1174980068 * __this, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = (Il2CppObject *)__this->get_key_0();
		return L_0;
	}
}
extern "C"  Il2CppObject * KeyValuePair_2_get_Key_m2113318928_AdjustorThunk (Il2CppObject * __this, const MethodInfo* method)
{
	KeyValuePair_2_t1174980068 * _thisAdjusted = reinterpret_cast<KeyValuePair_2_t1174980068 *>(__this + 1);
	return KeyValuePair_2_get_Key_m2113318928(_thisAdjusted, method);
}
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::set_Key(TKey)
extern "C"  void KeyValuePair_2_set_Key_m1222844869_gshared (KeyValuePair_2_t1174980068 * __this, Il2CppObject * ___value0, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = ___value0;
		__this->set_key_0(L_0);
		return;
	}
}
extern "C"  void KeyValuePair_2_set_Key_m1222844869_AdjustorThunk (Il2CppObject * __this, Il2CppObject * ___value0, const MethodInfo* method)
{
	KeyValuePair_2_t1174980068 * _thisAdjusted = reinterpret_cast<KeyValuePair_2_t1174980068 *>(__this + 1);
	KeyValuePair_2_set_Key_m1222844869(_thisAdjusted, ___value0, method);
}
// TValue System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::get_Value()
extern "C"  bool KeyValuePair_2_get_Value_m1916631176_gshared (KeyValuePair_2_t1174980068 * __this, const MethodInfo* method)
{
	{
		bool L_0 = (bool)__this->get_value_1();
		return L_0;
	}
}
extern "C"  bool KeyValuePair_2_get_Value_m1916631176_AdjustorThunk (Il2CppObject * __this, const MethodInfo* method)
{
	KeyValuePair_2_t1174980068 * _thisAdjusted = reinterpret_cast<KeyValuePair_2_t1174980068 *>(__this + 1);
	return KeyValuePair_2_get_Value_m1916631176(_thisAdjusted, method);
}
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::set_Value(TValue)
extern "C"  void KeyValuePair_2_set_Value_m965533293_gshared (KeyValuePair_2_t1174980068 * __this, bool ___value0, const MethodInfo* method)
{
	{
		bool L_0 = ___value0;
		__this->set_value_1(L_0);
		return;
	}
}
extern "C"  void KeyValuePair_2_set_Value_m965533293_AdjustorThunk (Il2CppObject * __this, bool ___value0, const MethodInfo* method)
{
	KeyValuePair_2_t1174980068 * _thisAdjusted = reinterpret_cast<KeyValuePair_2_t1174980068 *>(__this + 1);
	KeyValuePair_2_set_Value_m965533293(_thisAdjusted, ___value0, method);
}
// System.String System.Collections.Generic.KeyValuePair`2<System.Object,System.Boolean>::ToString()
extern "C"  String_t* KeyValuePair_2_ToString_m1739958171_gshared (KeyValuePair_2_t1174980068 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (KeyValuePair_2_ToString_m1739958171_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Il2CppObject * V_0 = NULL;
	bool V_1 = false;
	int32_t G_B2_0 = 0;
	StringU5BU5D_t1642385972* G_B2_1 = NULL;
	StringU5BU5D_t1642385972* G_B2_2 = NULL;
	int32_t G_B1_0 = 0;
	StringU5BU5D_t1642385972* G_B1_1 = NULL;
	StringU5BU5D_t1642385972* G_B1_2 = NULL;
	String_t* G_B3_0 = NULL;
	int32_t G_B3_1 = 0;
	StringU5BU5D_t1642385972* G_B3_2 = NULL;
	StringU5BU5D_t1642385972* G_B3_3 = NULL;
	int32_t G_B5_0 = 0;
	StringU5BU5D_t1642385972* G_B5_1 = NULL;
	StringU5BU5D_t1642385972* G_B5_2 = NULL;
	int32_t G_B4_0 = 0;
	StringU5BU5D_t1642385972* G_B4_1 = NULL;
	StringU5BU5D_t1642385972* G_B4_2 = NULL;
	String_t* G_B6_0 = NULL;
	int32_t G_B6_1 = 0;
	StringU5BU5D_t1642385972* G_B6_2 = NULL;
	StringU5BU5D_t1642385972* G_B6_3 = NULL;
	{
		StringU5BU5D_t1642385972* L_0 = (StringU5BU5D_t1642385972*)((StringU5BU5D_t1642385972*)SZArrayNew(StringU5BU5D_t1642385972_il2cpp_TypeInfo_var, (uint32_t)5));
		ArrayElementTypeCheck (L_0, _stringLiteral372029431);
		(L_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral372029431);
		StringU5BU5D_t1642385972* L_1 = (StringU5BU5D_t1642385972*)L_0;
		Il2CppObject * L_2 = KeyValuePair_2_get_Key_m2113318928((KeyValuePair_2_t1174980068 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->declaring_type)->rgctx_data, 2));
		G_B1_0 = 1;
		G_B1_1 = L_1;
		G_B1_2 = L_1;
		if (!L_2)
		{
			G_B2_0 = 1;
			G_B2_1 = L_1;
			G_B2_2 = L_1;
			goto IL_0039;
		}
	}
	{
		Il2CppObject * L_3 = KeyValuePair_2_get_Key_m2113318928((KeyValuePair_2_t1174980068 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->declaring_type)->rgctx_data, 2));
		V_0 = (Il2CppObject *)L_3;
		String_t* L_4 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (Il2CppObject *)(*(&V_0)));
		G_B3_0 = L_4;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		goto IL_003e;
	}

IL_0039:
	{
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_5 = ((String_t_StaticFields*)String_t_il2cpp_TypeInfo_var->static_fields)->get_Empty_2();
		G_B3_0 = L_5;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
	}

IL_003e:
	{
		ArrayElementTypeCheck (G_B3_2, G_B3_0);
		(G_B3_2)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(G_B3_1), (String_t*)G_B3_0);
		StringU5BU5D_t1642385972* L_6 = (StringU5BU5D_t1642385972*)G_B3_3;
		ArrayElementTypeCheck (L_6, _stringLiteral811305474);
		(L_6)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral811305474);
		StringU5BU5D_t1642385972* L_7 = (StringU5BU5D_t1642385972*)L_6;
		bool L_8 = KeyValuePair_2_get_Value_m1916631176((KeyValuePair_2_t1174980068 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->declaring_type)->rgctx_data, 4));
		G_B4_0 = 3;
		G_B4_1 = L_7;
		G_B4_2 = L_7;
	}
	{
		bool L_9 = KeyValuePair_2_get_Value_m1916631176((KeyValuePair_2_t1174980068 *)__this, /*hidden argument*/IL2CPP_RGCTX_METHOD_INFO(InitializedTypeInfo(method->declaring_type)->rgctx_data, 4));
		V_1 = (bool)L_9;
		String_t* L_10 = Boolean_ToString_m1253164328((bool*)(&V_1), /*hidden argument*/NULL);
		G_B6_0 = L_10;
		G_B6_1 = G_B4_0;
		G_B6_2 = G_B4_1;
		G_B6_3 = G_B4_2;
		goto IL_0077;
	}

IL_0072:
	{
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_11 = ((String_t_StaticFields*)String_t_il2cpp_TypeInfo_var->static_fields)->get_Empty_2();
		G_B6_0 = L_11;
		G_B6_1 = G_B5_0;
		G_B6_2 = G_B5_1;
		G_B6_3 = G_B5_2;
	}

IL_0077:
	{
		ArrayElementTypeCheck (G_B6_2, G_B6_0);
		(G_B6_2)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(G_B6_1), (String_t*)G_B6_0);
		StringU5BU5D_t1642385972* L_12 = (StringU5BU5D_t1642385972*)G_B6_3;
		ArrayElementTypeCheck (L_12, _stringLiteral372029425);
		(L_12)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral372029425);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_13 = String_Concat_m626692867(NULL /*static, unused*/, (StringU5BU5D_t1642385972*)L_12, /*hidden argument*/NULL);
		return L_13;
	}
}
extern "C"  String_t* KeyValuePair_2_ToString_m1739958171_AdjustorThunk (Il2CppObject * __this, const MethodInfo* method)
{
	KeyValuePair_2_t1174980068 * _thisAdjusted = reinterpret_cast<KeyValuePair_2_t1174980068 *>(__this + 1);
	return KeyValuePair_2_ToString_m1739958171(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
