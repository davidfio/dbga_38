Shader "Custom/DiffuseRed" {
	SubShader{
		Tags{
		"RenderType" = "Opaque"
		}

		CGPROGRAM
		// CG Program is written here
		#pragma surface surf Lambert

		struct Input 
		{
			float4 color : COLOR;
		};

		void surf(Input IN, inout SurfaceOutput o) 
		{
			o.Albedo.rgb = fixed4(0, 0, 1, 1);
		}

		ENDCG
	}
	FallBack "Diffuse"
}
