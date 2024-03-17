#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
224,
236,
237,
238,
239,
240,
241,
242,
243,
244,
247,
248,
249,
419,
420,
421,
450,
451,
452,
472,
473,
474,
475,
592,
593,
594,
597,
635,
636,
637,
640,
642,
644,
646,
651,
659,
660,
661,
662,
663,
664,
665,
666,
667,
668,
669,
670,
671,
672,
673,
674,
675,
677,
678,
679,
680,
681,
682,
683,
780,
781,
782,
783,
784,
785,
786,
787,
788,
789,
790,
791,
792,
793,
794,
795,
796,
798,
799,
800,
801,
802,
803,
804,
871,
872,
941,
948,
951,
953,
959,
960,
962,
963,
967,
969,
972,
973,
975,
977,
978,
981,
982,
983,
986,
988,
991,
993,
995,
1002,
1007,
1082,
1084,
1086,
1096,
1097,
1098,
1099,
1101,
1108,
1109,
1110,
1111,
1112,
1120,
1121,
1122,
1126,
1127,
1130,
1134,
1135,
1136,
1420,
1639,
1640,
9964,
9965,
9967,
9968,
9969,
9970,
9971,
9972,
9974,
9976,
9978,
9979,
9980,
9991,
9993,
10000,
10002,
10004,
10006,
10056,
10062,
10063,
10065,
10066,
10067,
10068,
10069,
10071,
10073,
11244,
11248,
11250,
11251,
11252,
11253,
11520,
11521,
11522,
11523,
11543,
11544,
11545,
11547,
11594,
11670,
11672,
11674,
11684,
11685,
11686,
11687,
11688,
12155,
12156,
12161,
12162,
12200,
12237,
12244,
12251,
12262,
12266,
12292,
12377,
12379,
12390,
12392,
12393,
12394,
12401,
12416,
12436,
12437,
12445,
12447,
12454,
12455,
12458,
12460,
12465,
12471,
12472,
12479,
12481,
12493,
12496,
12497,
12498,
12509,
12518,
12524,
12525,
12526,
12528,
12529,
12546,
12548,
12562,
12585,
12586,
12587,
12612,
12617,
12647,
12648,
13314,
13328,
13421,
13422,
13644,
13645,
13653,
13654,
13655,
13661,
13765,
14265,
14266,
14707,
14708,
14713,
14723,
16138,
16159,
16161,
16163,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_InitializeInternal_raw (int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
void ves_icall_RuntimeType_GetInterfaceMapData_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetPacking_raw (int,int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_System_RuntimeType_AllocateValueType_raw (int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeType_IsUnmanagedFunctionPointerInternal (int);
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Decrement_Long (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
void ves_icall_System_Threading_Thread_StartInternal_raw (int,int,int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 224,
ves_icall_System_Array_InternalCreate,
// token 236,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 237,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 238,
ves_icall_System_Array_CanChangePrimitive,
// token 239,
ves_icall_System_Array_FastCopy,
// token 240,
ves_icall_System_Array_GetLengthInternal_raw,
// token 241,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 242,
ves_icall_System_Array_GetGenericValue_icall,
// token 243,
ves_icall_System_Array_GetValueImpl_raw,
// token 244,
ves_icall_System_Array_SetGenericValue_icall,
// token 247,
ves_icall_System_Array_SetValueImpl_raw,
// token 248,
ves_icall_System_Array_InitializeInternal_raw,
// token 249,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 419,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 420,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 421,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 450,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 451,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 452,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 472,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 473,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 474,
ves_icall_System_Enum_InternalGetCorElementType,
// token 475,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 592,
ves_icall_System_Environment_get_ProcessorCount,
// token 593,
ves_icall_System_Environment_get_TickCount,
// token 594,
ves_icall_System_Environment_get_TickCount64,
// token 597,
ves_icall_System_Environment_FailFast_raw,
// token 635,
ves_icall_System_GC_GetCollectionCount,
// token 636,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 637,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 640,
ves_icall_System_GC_SuppressFinalize_raw,
// token 642,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 644,
ves_icall_System_GC_GetGCMemoryInfo,
// token 646,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 651,
ves_icall_System_Object_MemberwiseClone_raw,
// token 659,
ves_icall_System_Math_Acos,
// token 660,
ves_icall_System_Math_Acosh,
// token 661,
ves_icall_System_Math_Asin,
// token 662,
ves_icall_System_Math_Asinh,
// token 663,
ves_icall_System_Math_Atan,
// token 664,
ves_icall_System_Math_Atan2,
// token 665,
ves_icall_System_Math_Atanh,
// token 666,
ves_icall_System_Math_Cbrt,
// token 667,
ves_icall_System_Math_Ceiling,
// token 668,
ves_icall_System_Math_Cos,
// token 669,
ves_icall_System_Math_Cosh,
// token 670,
ves_icall_System_Math_Exp,
// token 671,
ves_icall_System_Math_Floor,
// token 672,
ves_icall_System_Math_Log,
// token 673,
ves_icall_System_Math_Log10,
// token 674,
ves_icall_System_Math_Pow,
// token 675,
ves_icall_System_Math_Sin,
// token 677,
ves_icall_System_Math_Sinh,
// token 678,
ves_icall_System_Math_Sqrt,
// token 679,
ves_icall_System_Math_Tan,
// token 680,
ves_icall_System_Math_Tanh,
// token 681,
ves_icall_System_Math_FusedMultiplyAdd,
// token 682,
ves_icall_System_Math_Log2,
// token 683,
ves_icall_System_Math_ModF,
// token 780,
ves_icall_System_MathF_Acos,
// token 781,
ves_icall_System_MathF_Acosh,
// token 782,
ves_icall_System_MathF_Asin,
// token 783,
ves_icall_System_MathF_Asinh,
// token 784,
ves_icall_System_MathF_Atan,
// token 785,
ves_icall_System_MathF_Atan2,
// token 786,
ves_icall_System_MathF_Atanh,
// token 787,
ves_icall_System_MathF_Cbrt,
// token 788,
ves_icall_System_MathF_Ceiling,
// token 789,
ves_icall_System_MathF_Cos,
// token 790,
ves_icall_System_MathF_Cosh,
// token 791,
ves_icall_System_MathF_Exp,
// token 792,
ves_icall_System_MathF_Floor,
// token 793,
ves_icall_System_MathF_Log,
// token 794,
ves_icall_System_MathF_Log10,
// token 795,
ves_icall_System_MathF_Pow,
// token 796,
ves_icall_System_MathF_Sin,
// token 798,
ves_icall_System_MathF_Sinh,
// token 799,
ves_icall_System_MathF_Sqrt,
// token 800,
ves_icall_System_MathF_Tan,
// token 801,
ves_icall_System_MathF_Tanh,
// token 802,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 803,
ves_icall_System_MathF_Log2,
// token 804,
ves_icall_System_MathF_ModF,
// token 871,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 872,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 941,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 948,
ves_icall_RuntimeType_make_array_type_raw,
// token 951,
ves_icall_RuntimeType_make_byref_type_raw,
// token 953,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 959,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 960,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 962,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 963,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 967,
ves_icall_RuntimeType_GetInterfaceMapData_raw,
// token 969,
ves_icall_RuntimeType_GetPacking_raw,
// token 972,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 973,
ves_icall_System_RuntimeType_AllocateValueType_raw,
// token 975,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 977,
ves_icall_System_RuntimeType_getFullName_raw,
// token 978,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 981,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 982,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 983,
ves_icall_RuntimeType_GetFields_native_raw,
// token 986,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 988,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 991,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 993,
ves_icall_RuntimeType_GetName_raw,
// token 995,
ves_icall_RuntimeType_GetNamespace_raw,
// token 1002,
ves_icall_RuntimeType_IsUnmanagedFunctionPointerInternal,
// token 1007,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 1082,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1084,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1086,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1096,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1097,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1098,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1099,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1101,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1108,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1109,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1110,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1111,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1112,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1120,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1121,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1122,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1126,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1127,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1130,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1134,
ves_icall_System_String_FastAllocateString_raw,
// token 1135,
ves_icall_System_String_InternalIsInterned_raw,
// token 1136,
ves_icall_System_String_InternalIntern_raw,
// token 1420,
ves_icall_System_Type_internal_from_handle_raw,
// token 1639,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1640,
ves_icall_System_ValueType_Equals_raw,
// token 9964,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 9965,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 9967,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 9968,
ves_icall_System_Threading_Interlocked_Decrement_Long,
// token 9969,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 9970,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 9971,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 9972,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 9974,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 9976,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 9978,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 9979,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 9980,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 9991,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 9993,
mono_monitor_exit_icall_raw,
// token 10000,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 10002,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 10004,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 10006,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 10056,
ves_icall_System_Threading_Thread_StartInternal_raw,
// token 10062,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 10063,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 10065,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 10066,
ves_icall_System_Threading_Thread_GetState_raw,
// token 10067,
ves_icall_System_Threading_Thread_SetState_raw,
// token 10068,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 10069,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 10071,
ves_icall_System_Threading_Thread_YieldInternal,
// token 10073,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 11244,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 11248,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 11250,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 11251,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 11252,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 11253,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 11520,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 11521,
ves_icall_System_GCHandle_InternalFree_raw,
// token 11522,
ves_icall_System_GCHandle_InternalGet_raw,
// token 11523,
ves_icall_System_GCHandle_InternalSet_raw,
// token 11543,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 11544,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 11545,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 11547,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 11594,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 11670,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 11672,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw,
// token 11674,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 11684,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 11685,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 11686,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 11687,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 11688,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 12155,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 12156,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 12161,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 12162,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 12200,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 12237,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 12244,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 12251,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 12262,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 12266,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 12292,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 12377,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 12379,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 12390,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 12392,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 12393,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 12394,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 12401,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 12416,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 12436,
ves_icall_reflection_get_token_raw,
// token 12437,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 12445,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 12447,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 12454,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 12455,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 12458,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 12460,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 12465,
ves_icall_reflection_get_token_raw,
// token 12471,
ves_icall_get_method_info_raw,
// token 12472,
ves_icall_get_method_attributes,
// token 12479,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 12481,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 12493,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 12496,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 12497,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 12498,
ves_icall_reflection_get_token_raw,
// token 12509,
ves_icall_InternalInvoke_raw,
// token 12518,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 12524,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 12525,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 12526,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 12528,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 12529,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 12546,
ves_icall_InvokeClassConstructor_raw,
// token 12548,
ves_icall_InternalInvoke_raw,
// token 12562,
ves_icall_reflection_get_token_raw,
// token 12585,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 12586,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 12587,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 12612,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 12617,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 12647,
ves_icall_reflection_get_token_raw,
// token 12648,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 13314,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 13328,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 13421,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 13422,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 13644,
ves_icall_ModuleBuilder_basic_init_raw,
// token 13645,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 13653,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 13654,
ves_icall_ModuleBuilder_getToken_raw,
// token 13655,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 13661,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 13765,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 14265,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 14266,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 14707,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 14708,
ves_icall_System_Diagnostics_Debugger_Log,
// token 14713,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 14723,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 16138,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 16159,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 16161,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 16163,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
0,
0,
0,
4,
0,
4,
4,
4,
4,
0,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
0,
4,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
};
