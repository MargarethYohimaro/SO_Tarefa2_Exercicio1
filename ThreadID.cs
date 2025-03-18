public class ThreadID extends Thread {
        @Override
            public void run() {
                    int id = (int) this.threadId();
                    
                            System.out.println("Thread ID: " + id);
                                }

                                    public static void main(String[] args) {
                                            for (int i = 0; i < 5; i++) {
                                                        new ThreadID().start();
                                                                }
                                                                    }
                                                                    }
}