import java.util.Random;
import java.util.concurrent.atomic.AtomicInteger;

class Sapo extends Thread {
    private static final int DISTANCIA_TOTAL = 50;
        private static final int SALTO_MAXIMO = 5;
            private static AtomicInteger colocacao = new AtomicInteger(0);

                private String nome;
                    private int distanciaPercorrida = 0;
                        private Random rand = new Random();

                            public Sapo(String nome) {
                                    this.nome = nome;
                                        }

                                            @Override
                                                public void run() {
                                                        while (distanciaPercorrida < DISTANCIA_TOTAL) {
                                                                    int salto = rand.nextInt(SALTO_MAXIMO) + 1;
                                                                                distanciaPercorrida += salto;
                                                                                            System.out.println(nome + " pulou " + salto + " metros. Distância total: " + distanciaPercorrida);
                                                                                                        try {
                                                                                                                        Thread.sleep(200);
                                                                                                                                    } catch (InterruptedException e) {
                                                                                                                                                    e.printStackTrace();
                                                                                                                                                                }
                                                                                                                                                                        }
                                                                                                                                                                                System.out.println(nome + " chegou em " + colocacao.incrementAndGet() + "° lugar!");
                                                                                                                                                                                    }

                                                                                                                                                                                        public static void main(String[] args) {
                                                                                                                                                                                                Sapo[] sapos = {
                                                                                                                                                                                                            new Sapo("Sapo 1"),
                                                                                                                                                                                                                        new Sapo("Sapo 2"),
                                                                                                                                                                                                                                    new Sapo("Sapo 3"),
                                                                                                                                                                                                                                                new Sapo("Sapo 4"),
                                                                                                                                                                                                                                                            new Sapo("Sapo 5")
                                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                                            for (Sapo s : sapos) {
                                                                                                                                                                                                                                                                                        s.start();
                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                    }