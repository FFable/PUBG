#version 330 core

in vec3 TexCoord; // ����3D��������ķ�������
out vec4 FragColor;

uniform samplerCube cubemap; // ��������ͼ�����������
uniform float lightIntensity;

void main()
{             
    FragColor = texture(cubemap, TexCoord) * lightIntensity;
}