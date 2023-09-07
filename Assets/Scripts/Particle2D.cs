using UnityEngine;

public class Particle2D : MonoBehaviour
{
    Vector3 vec1(1, 2, 3);
    Vector3 vec2(2, 3, 4);
    Vector3 vec3 = vec1 + vec2;
    std::cout << vec3 << std::endl;
  std::cout << vec3 - vec1 << std::endl;
  std::cout << vec3 + Vector3::Zero << std::endl;

  std::cout << vec3.Dot(Vector3::Zero) << std::endl;
  std::cout << vec1.Dot(vec2) << std::endl;

  std::cout << Vector3::Zero.Magnitude() << std::endl;

  std::cout << vec1.Magnitude() << std::endl;

  std::cout << vec1* 2 << std::endl;

  std::cout << vec1 / 2 << std::endl;
}
