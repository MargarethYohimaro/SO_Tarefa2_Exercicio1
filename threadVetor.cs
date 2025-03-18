import java.util.Random;

class ThreadVetor extends Thread {
    private int num;
        private int[] vetor;

            public ThreadVetor(int num, int[] vetor) {
                    this.num = num;
                            this.vetor = vetor;
                                }

                                    @Override
                                        public void run() {
                                                long inicio = System.nanoTime();
                                                        if (num % 2 == 0) {
                                                                    for (int i = 0; i < vetor.length; i++) {
                                                                                    int temp = vetor[i]; // Simulando processamento
                                                                                                }
                                                                                                        } else {
                                                                                                                    for (int val : vetor) {
                                                                                                                                    int temp = val; // Simulando processamento
                                                                                                                                                }
                                                                                                                                                        }
                                                                                                                                                                long fim = System.nanoTime();
                                                                                                                                                                        double tempoSegundos = (fim - inicio) / 1e9;
                                                                                                                                                                                System.out.println("Thread " + num + " executou em " + tempoSegundos + " segundos.");
                                                                                                                                                                                    }

                                                                                                                                                                                        public static void main(String[] args) {
                                                                                                                                                                                                int[] vetor = new Random().ints(1000, 1, 101).toArray();
                                                                                                                                                                                                        new ThreadVetor(1, vetor).start();
                                                                                                                                                                                                                new ThreadVetor(2, vetor).start();
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    }