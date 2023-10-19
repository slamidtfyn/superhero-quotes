<script setup lang="ts">
import Quote from './components/Quote.vue';
</script>

<template>
  <main>
    <Quote />
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }
}

</style>
