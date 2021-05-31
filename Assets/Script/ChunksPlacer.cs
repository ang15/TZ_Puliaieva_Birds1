using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Script
{
    public class ChunksPlacer : MonoBehaviour
    {
        public Transform Player;
        public CharacterController player;
        public Chunk[] ChunkPrefabs;
        public Chunk FirstChunk;

        private List<Chunk> spawnedChunks = new List<Chunk>();
        void Start()
        {
            spawnedChunks.Add(FirstChunk);
        }

        // Update is called once per frame
        void Update()
        {
            if (Player.position.x > spawnedChunks[spawnedChunks.Count - 1].End.position.x - 15)
            {
                player.Monets += 5;
                SpawnedChunks();
            }


        }

        private void SpawnedChunks()
        {
            Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
            newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;
            spawnedChunks.Add(newChunk);

            if (spawnedChunks.Count > 3)
            {
                Destroy(spawnedChunks[0].gameObject);
                spawnedChunks.RemoveAt(0);
            }

        }
    }
    
    }