export const animations = {
  idle: {
    frameDuration: 1000,
    frames: [
      {
        bones: {
          leftArm: { rotation: [0, 0, 0] },
          rightArm: { rotation: [0, 0, 0] },
          leftLeg: { rotation: [0, 0, 0] },
          rightLeg: { rotation: [0, 0, 0] }
        }
      }
    ]
  },
  walk: {
    frameDuration: 1000,
    frames: [
      {
        bones: {
          leftArm: { rotation: [-0.5, 0, 0] },
          rightArm: { rotation: [0.5, 0, 0] },
          leftLeg: { rotation: [0.5, 0, 0] },
          rightLeg: { rotation: [-0.5, 0, 0] }
        }
      },
      {
        bones: {
          leftArm: { rotation: [0.5, 0, 0] },
          rightArm: { rotation: [-0.5, 0, 0] },
          leftLeg: { rotation: [-0.5, 0, 0] },
          rightLeg: { rotation: [0.5, 0, 0] }
        }
      }
    ]
  }
};
