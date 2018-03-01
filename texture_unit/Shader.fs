#version 330 core
out vec4 FragColor;
in vec3 ourColor;
in vec2 texCoord;
uniform sampler2D ourTexture1;
uniform sampler2D ourTexture2;
//uniform sampler2D ourTexture;

void main()
{
	//FragColor = vec4(ourColor, 1.0f);
	//FragColor = texture(ourTexture, texCoord);// * vec4(ourColor, 1.0f);
	FragColor = mix(texture(ourTexture1, texCoord), texture(ourTexture2, texCoord), 0.3);
	//FragColor = vec4(0.0f, greenValue, 0.0f, 1.0f);
}