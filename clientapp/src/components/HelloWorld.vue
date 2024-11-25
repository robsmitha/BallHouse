<template>
  <v-parallax 
    :src="props.src" 
    :height="props.height"
    aspect-ratio="16/9"
    class="mt-n5"
  >
      <v-overlay v-model="display" contained class="align-center justify-center" persistent :opacity="0">
          <div>
              <div class="text-center" style="background-color: rgba(255,255,255,.6); padding: 16px; border-radius: 0;">
                <span v-html="props.text"></span>
              </div>
          </div>
      </v-overlay>
  </v-parallax>
</template>

<script setup lang="ts">
type HeroAction = {
  text: string,
  to: string | undefined,
  href: string | undefined,
  icon: string | undefined
}

let display = true
const props = defineProps({
  src: { type: String, default: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/background-main.jpg' },
  height: { type: Number, default: 600 },
  text: { type: String, required: true },
  actions: { type: Array<HeroAction>, default: [] }
})
</script>
