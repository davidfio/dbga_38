Shader "Custom/ SimpleTextureShader"
{
	Properties
	{
		_Color("The Best Color", Color) = (1,1,1,1)
		_MainTex("The Best Texture", 2D) = "white" {}
		_EmissiveRatio("The Most Emmisive Ratio", Range(0.1, 4.0)) = 0.7
		_Emissive("Emissive Color", Color) = (1,1,1,1)
		_DetailTex("Detail Texture", 2D) = "white" {}

		//_TestInt("Test Int", Int) = 4
		//_TestCube("Test Cube", Cube) = "defaulttexture" {}
		//_Test3D("Test 3D", 3D) = "defaulttexture" {}
		//_Strenght("Strenght", float) = .5

	}


	SubShader
	{
		Pass
		{
			Material
			{
				Diffuse[_Color]
				Emission[_Emissive]
			}	
			Lighting On

			SetTexture[_MainTex] 
			{
				combine previous * texture
			}

			SetTexture[_DetailTex]
			{
				combine previous * texture
			}
		}
	}
}