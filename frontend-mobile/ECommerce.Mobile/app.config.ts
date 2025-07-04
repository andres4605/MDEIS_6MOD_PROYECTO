import { ExpoConfig } from "@expo/config-types";
import packageJson from "./package.json";

const appConfig: ExpoConfig = {
  name: "movil-react-ecommerce",
  slug: "movil-react-ecommerce",
  scheme: "rnca",
  version: packageJson.version,
  orientation: "portrait",
  icon: "./assets/images/icon.png",
  userInterfaceStyle: "light",
  splash: {
    image: "./assets/images/splash.png",
    resizeMode: "cover",
    backgroundColor: "#ffffff",
  },
  updates: {
    fallbackToCacheTimeout: 0,
  },
  assetBundlePatterns: ["**/*"],
  ios: {
    supportsTablet: true,
  },
  android: {
    package: "com.cesarmc.reactnativecleanarchitecture",
    adaptiveIcon: {
      foregroundImage: "./assets/images/adaptive-icon.png",
      backgroundColor: "#FFFFFF",
    },
  },
  web: {
    favicon: "./assets/images/favicon.png",
  },
  plugins: [
    [
      "expo-build-properties",
      {
        ios: {
          deploymentTarget: "15.1",
          useFrameworks: "static",
        },
      },
    ],
    "expo-localization",
    "expo-tracking-transparency",
  ],
};

export default appConfig;
