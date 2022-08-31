using UnityEngine;

namespace Paralysed.Core
{
    public interface IRespawnable 
    {
        public void SetRespawn(Vector3 respawnPoint);
        public void Respawn();
    }
}
