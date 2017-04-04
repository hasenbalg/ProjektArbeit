#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Object
struct Object_t1021602117;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LightSpawner
struct  LightSpawner_t11931828  : public MonoBehaviour_t1158329972
{
public:
	// System.Single LightSpawner::timeInterval
	float ___timeInterval_2;
	// System.Single LightSpawner::lifeTime
	float ___lifeTime_3;
	// UnityEngine.Object LightSpawner::light
	Object_t1021602117 * ___light_4;

public:
	inline static int32_t get_offset_of_timeInterval_2() { return static_cast<int32_t>(offsetof(LightSpawner_t11931828, ___timeInterval_2)); }
	inline float get_timeInterval_2() const { return ___timeInterval_2; }
	inline float* get_address_of_timeInterval_2() { return &___timeInterval_2; }
	inline void set_timeInterval_2(float value)
	{
		___timeInterval_2 = value;
	}

	inline static int32_t get_offset_of_lifeTime_3() { return static_cast<int32_t>(offsetof(LightSpawner_t11931828, ___lifeTime_3)); }
	inline float get_lifeTime_3() const { return ___lifeTime_3; }
	inline float* get_address_of_lifeTime_3() { return &___lifeTime_3; }
	inline void set_lifeTime_3(float value)
	{
		___lifeTime_3 = value;
	}

	inline static int32_t get_offset_of_light_4() { return static_cast<int32_t>(offsetof(LightSpawner_t11931828, ___light_4)); }
	inline Object_t1021602117 * get_light_4() const { return ___light_4; }
	inline Object_t1021602117 ** get_address_of_light_4() { return &___light_4; }
	inline void set_light_4(Object_t1021602117 * value)
	{
		___light_4 = value;
		Il2CppCodeGenWriteBarrier(&___light_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
